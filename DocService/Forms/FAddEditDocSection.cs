using Sm.Ui.Core;
using System;
namespace DocService {
    public partial class FAddEditDocSection : DefWin {

        public bool OperationCancelled { get; private set; } = true;
        public Document_Entry.Section Result_Section { get; set; } = null;

        #region Constructor

        public FAddEditDocSection() {

            InitializeComponent();

            this.Make_Movable(label1, label2, label3);

            Load += FAddEditDocSection_Load;

            BtMaximize.Click += (s, e) => this.MiniMaxiMize_Action();

            Add_CloserBtn(BtClose);
        }

        #endregion

        #region Load Event

        private void FAddEditDocSection_Load(object sender, EventArgs e) {

            if (Result_Section != null) {

                Text = label1.Text = "ویرایش یکی از مفاد سند";

                TbSectionTitle.Text = Result_Section.Section_Title;

                TbSectionText.Text = Result_Section.Section_Text;
            }
            else Text = label1.Text = "افزودن ماده جدید به مفاد سند";
        }

        #endregion

        #region Show Help Event

        private void BtHelp_Click(object sender, EventArgs e) {

            this.Info_Notic("مفاد سند شامل لیستی" +
                " از بخش هایی میشود که از عنوان و توضیحات " +
                "تشکیل شده اند. بعنوان مثال، برای تهیه مستندات برای " +
                "یک برنامه حسابداری، باید اینچنین عمل کنید : سندی با " +
                "عنوان «راهنمای استفاده از برنامه حسابداری» ثبت کنید که " +
                "ماده هایی مثل «طرز کار پشتیبان گیری» یا «شیوه محاسبه بدهکاران» داشته باشد");
        }

        #endregion

        #region Save Changes Event

        private void BtSaveChanges_Click(object sender, EventArgs e) {

            if (!new object[] {
                TbSectionTitle,
                TbSectionText
            }
            .isNotEmptyWithError(this)) return;

            if (Result_Section != null) {

                Result_Section.Section_Title = TbSectionTitle.Text;
                Result_Section.Section_Text = TbSectionText.Text;
            }
            else Result_Section = new Document_Entry
                    .Section(TbSectionTitle.Text, TbSectionText.Text);

            OperationCancelled = false;

            Close();
        }

        #endregion
    }
}
