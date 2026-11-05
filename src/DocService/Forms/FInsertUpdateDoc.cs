using Sm.Ui.Core;
using System;
using System.Linq;
using System.ComponentModel;
using DocService.Data;

namespace DocService {

    /// <summary>
    /// فرم ثبت / ویرایش مستندات
    /// </summary>
    public partial class FInsertUpdateDoc : DefWin {

        #region Properties

        /// <summary>
        /// شناسه مستندات خواسته شده برای 
        /// ویرایش - اگر نال باشد یعنی ثبت جدید
        /// </summary>
        public long? EditDocId { get; set; } = null;

        /// <summary>
        /// شی انتری سند
        /// </summary>
        private Document_Entry Current_Entry { get; set; } = null;

        /// <summary>
        /// مدل دیتایی
        /// </summary>
        private DocumentModel Model { get; set; } = null;

        /// <summary>
        /// تغییرات ذخیره نشده ای وجود دارد یا نه
        /// </summary>
        private bool HasUnsavedChanges { get; set; } = false;

        public bool OperationCancelled { get; private set; } = true;

        /// <summary>
        /// مفاد مندرج
        /// </summary>
        private BindingList<Document_Entry.Section> DocSections { get; }
            = new BindingList<Document_Entry.Section>();

        #endregion

        #region Constructor

        public FInsertUpdateDoc() {

            InitializeComponent();

            DataGridViewStyler.Apply(DgvSections);

            this.Make_Movable(label1, label2, label3);

            Load += FInsertUpdateDoc_Load;

            BtMaximize.Click += (s, e) => this.MiniMaxiMize_Action();

            CurrentlyAllowToClose = false;

            BtClose.Click += Confirmation_BeforeClosing;

            BtCancelAndClose.Click += Confirmation_BeforeClosing;
        }

        #endregion

        #region Load Event

        private void FInsertUpdateDoc_Load(object sender, EventArgs e) {

            if (EditDocId != null) {

                Text = label1.Text = "ویرایش سند شماره " + EditDocId;

                var requestedDoc = Model = DocSvc
                    .Database.GetDocById(EditDocId.Value);

                if (requestedDoc is null) {

                    this.Error_Notic("سندی به شناسه " + EditDocId + " یافت نشد",
                        "خطایی حین انجام این عملیات رخ داد، اطلاعات بیشتر در جزئیات خطا.");
                    Freez_Loading_Effect();
                    Close();
                    return;
                }

                Current_Entry = requestedDoc.AsEntry();

                TbDocTitle.Text = requestedDoc.Title;

                DocSections.AddRange(Current_Entry.Sections);
            }
            else Text = label1.Text = "ثبت سند جدید";

            DgvSections.DataSource = DocSections;

            DgvSections.Set_Columns_FillWeights(40, 60);

            TbDocTitle.TextChanged += (s, e1) => HasUnsavedChanges = true;
        }

        #endregion

        #region Show Help Text

        private void BtHelp_Click(object sender, EventArgs e) {

            this.Info_Notic("در اینجا می توانید سند ا" +
                "یجاد و ویرایش کنید." +
                " عنوان بنویسید و مفاد اضافه کنید " +
                "و ذخیره کنید تا بعدا هر زمان که نیاز شد خروجی json بگیرید.");
        }

        #endregion

        #region Confirmation Before Closing

        private void Confirmation_BeforeClosing(object sender, EventArgs e) {

            if (HasUnsavedChanges) {

                var ClosureCancelled = this.Question_Dialog("تغییرات ذخیره نشده ای وجود " +
                    "دارد که در صورت بستن این پنجره از دست خواهند رفت.",
                    "باشه میمونم", "مهم نیست میخوام برم");

                if (ClosureCancelled) return;
            }

            CurrentlyAllowToClose = true;

            Close();
        }


        #endregion

        #region Add Section

        private void BtAddSection_Click(object sender, EventArgs e) {

            var result = this.Call_Win<FAddEditDocSection>().Result_Section;

            if (result != null) {

                DocSections.Add(result);
                HasUnsavedChanges = true;
                UiNotif.Send_Success("ماده جدید به مفاد این سند اضافه شد");
                BtAddSection.Focus();
            }
        }

        #endregion

        #region Edit Section

        private void BtEditSection_Click(object sender, EventArgs e) {

            if (!DgvSections.RowIsSelected(this)) return;

            var selected = DgvSections.CurrentRow
                .DataBoundItem as Document_Entry.Section;

            var editor = new FAddEditDocSection();

            editor.Result_Section = selected;

            this.Call_Win(Alternate_Instance: editor);

            if (!editor.OperationCancelled) {

                HasUnsavedChanges = true;
                UiNotif.Defults.Success_Edited();
                DgvSections.Refresh();
                BtEditSection.Focus();
            }
        }

        private void DgvSections_DoubleClick(object sender, EventArgs e) {

            if (!DgvSections.RowIsSelected(this, false)) return;

            BtEditSection_Click(sender, e);
        }

        #endregion

        #region Delete Section

        private void BtDeleteSection_Click(object sender, EventArgs e) {

            if (!DgvSections.RowIsSelected(this)) return;

            var selected = DgvSections.CurrentRow
                .DataBoundItem as Document_Entry.Section;

            var delete_confirmed = this.Question_Dialog
                ($"ماده «{selected.Section_Title}» از این سند حذف شود؟");

            if (!delete_confirmed) return;

            DocSections.Remove(selected);

            HasUnsavedChanges = true;

            UiNotif.Send_Danger("ماده انتخاب شده از مفاد این سند حذف شد", "حذف شد");
        }

        #endregion

        #region View Live Document

        private void BtViewDocAsLive_Click(object sender, EventArgs e) {

            if (!UpdateEntry()) return;

            this.Run_Document(Current_Entry);
        }

        #endregion

        #region Save Changes

        private void BtSaveChanges_Click(object sender, EventArgs e) {

            if (!UpdateModel()) return;

            var success_operation = EditDocId is null
                ? DocSvc.Database.InsertDoc(Model)
                : DocSvc.Database.UpdateDoc(Model);

            if (success_operation) {

                OperationCancelled = HasUnsavedChanges = false;
                CurrentlyAllowToClose = true;
                Close();
                return;
            }

            this.Info_Notic("عملیات ناموفق بود، دوباره امتحان کنید.");
        }

        #endregion


        // = = = Internal Shared

        #region Update Doc Entry Instance

        private bool UpdateEntry() {

            if (DocSections.Count is 0 || string
                .IsNullOrWhiteSpace(TbDocTitle.Text)) {

                this.Inputs_Not_Completed_Notic();
                return false;
            }

            if (Current_Entry != null) {

                Current_Entry.Title = TbDocTitle.Text;
                Current_Entry.Sections = DocSections.ToArray();
            }
            else Current_Entry = new Document_Entry() {

                Title = TbDocTitle.Text,
                Sections = DocSections.ToArray(),
                Last_Updated_Date = DateTime.UtcNow.Get_Shamsi_Short_Date(),
                Last_Updated_Clock = DateTime.UtcNow.Get_Shamsi_Short_Time(),
                Increase_Window_Size = false,
                Need_Update = false,
            };

            return true;
        }

        #endregion

        #region Update Document Model Instance

        private bool UpdateModel() {

            if (DocSections.Count is 0 || string
               .IsNullOrWhiteSpace(TbDocTitle.Text)) {

                this.Inputs_Not_Completed_Notic();
                return false;
            }

            if (Model != null) {

                Model.Title = TbDocTitle.Text;
                Model.SectionsJson = DocSections.ToArray().Ui_To_Json();
                Model.UpdatedAtUtc = DateTime.UtcNow;
            }
            else Model = new DocumentModel() {

                Id = EditDocId ?? -1 /* برای ثبت نادیده گرفته می شود */,
                Title = TbDocTitle.Text,
                SectionsJson = DocSections.ToArray().Ui_To_Json(),
                CreatedAtUtc = DateTime.UtcNow,
                UpdatedAtUtc = DateTime.UtcNow
            };

            return true;
        }

        #endregion
    }
}
