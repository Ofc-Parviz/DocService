using Sm.Ui.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocService {

    /// <summary>
    /// فرم اصلی ابزار مدیریت مستندات
    /// </summary>
    public partial class FMain : DefWin {

        #region Constructor

        public FMain() {

            InitializeComponent();

            // پیاده سازی استایل سفارشی روی دیتاگریدویو
            DataGridViewStyler.Apply(DgvDocs);

            // بهینه سازی تغییر سایز دیتاگرید جهت جلوگیری از لگ زدن
            SetupGridResizeOptimization(DgvDocs);

            // قابل جابجایی کردن لیبل ها و لوگو - طوری که
            // بتوان با کشیدن آنها پنجره رو جابجا کرد
            this.Make_Movable(label1, label2, label3, label4, pictureBox1);

            // درج نگارش فعلی برنامه
            label3.Text = $"نگارش {GuiCore.Current_Config.AppVersion}";

            // ست کردن متن هاور برای سه دکمه بالا سمت چپ
            HelpTooltip.SetToolTip(BtHelpDoc, "راهنمای استفاده");
            HelpTooltip.SetToolTip(BtMaximize, "حالت تمام صفحه");
            HelpTooltip.SetToolTip(BtClose, "بستن برنامه");

            // راه اندازی دکمه تمام صفحه
            BtMaximize.Click += (s, e) => this.MiniMaxiMize_Action();

            // دکمه بستن
            Add_CloserBtn(BtClose);

            // حذف ایونت داخلی sm.ui.core
            Load -= InsiderLoadEvent;

            // رویداد لود شدن فرم
            Load += FMain_Load;

            // تنظیم نمایش متن هنگام خالی بودن دیتاگرید
            DgvDocs.Set_Title_When_No_Data

                // اگر رفرش در حال انجام بود
                (() => CurrentlyRefreshing

                // میگیم در حال بارگیری
                ? "در حال دریافت اطلاعات مستندات . . . "

                // در غیر اینصورت میگیم اطلاعاتی وجود نداره
                : "هنوز هیچ مستندات ثبت شده ای ندارید.\n" +
                " برای اینکار از گزینه ثبت سند جدید اقدام کنید.",

                // رنگ و فونت اختصاصی هم واسش ست می کنیم
                Alternate_ForeColor: Color.DarkSlateBlue,
                Alternate_Font: BtInsert.Font);
        }

        #endregion

        #region Load Event

        private async void FMain_Load(object sender, EventArgs e) {

            // راه اندازی دیتابیس
            DocSvc.Database.Load();

            // نمایش فرم راه اندازی اولیه
            this.Call_Win<FStartup>();

            // بازیابی رفتار داخلی sm.ui
            // بعد از فرم راه اندازی اولیه
            InsiderLoadEvent(sender, e);

            // صبر کردن برای یک ثانیه
            await Task.Delay(1000);

            // لود اطلاعات در دیتاگرید پس از یک ثانیه
            // جهت جلوگیری از لگ و تداخل
            BtRefresh_Click(sender, e);

            // تنظیم سایز ستون های دیتاگرید به اندازه های مناسب
            DgvDocs.Set_Columns_FillWeights(8, 50, 30, 30);
        }

        #endregion

        #region Show Help

        private void BtHelpDoc_Click(object sender, EventArgs e) {

            this.Run_Document(Properties.Resources
                .HelpJsonDoc.Json_To_Ui<Document_Entry>());
        }

        #endregion

        #region Refresh Data

        /// <summary>
        /// کلیک دکمه رفرش
        /// </summary>
        private void BtRefresh_Click(object sender, EventArgs e) {

            CurrentlyRefreshing = true;

            // دریافت اطلاعات همه مستندات و نمایش در دیتاگرید
            DgvDocs.DataSource = DocSvc.Database.GetAllDocs();

            CurrentlyRefreshing = false;
        }
        public bool CurrentlyRefreshing { get; set; } = true;

        #endregion

        #region Insert Doc

        /// <summary>
        /// کلیک دکمه ثبت سند جدید
        /// </summary>
        private void BtInsert_Click(object sender, EventArgs e) {

            if (!this
                // صدا زدن فرم ثبت / ویرایش سند
                .Call_Win<FInsertUpdateDoc>()
                // بررسی اینکه بعد از بسته
                // شدنش عملیات کنسل شده یا نه
                .OperationCancelled) {

                // اگر کنسل نشده بود یعنی
                // عملیات ثبت اتفاق افتاده

                // پس نوتیفیکیشن پیغام موفق میدیم
                UiNotif.Defults.Success_Inserted();

                // و بعد رفرش میکنیم تا ردیف
                // جدید قابل مشاهده بشه
                BtRefresh_Click(sender, e);
            }
        }

        #endregion

        #region Update Doc

        /// <summary>
        /// کلیک دکمه ویرایش سند
        /// </summary>
        private void BtUpdate_Click(object sender, EventArgs e) {

            // اگر هیچ سندی انتخاب نشده باشه،
            // پیغام داده و ادامه نمیدیم
            if (!DgvDocs.RowIsSelected(this)) return;

            // دریافت شناسه عددی سند انتخاب شده
            var selected = (long)DgvDocs.CurrentRow.Cells["شماره"].Value;

            // ایجاد شی جدید فرم ویرایش
            var editor = new FInsertUpdateDoc();

            // معرفی شناسه سند انتخاب شده
            // به فرم ویرایش جهت شناسایی
            editor.EditDocId = selected;

            // فراخوانی فرم ویرایش سند
            this.Call_Win(Alternate_Instance: editor);

            if (!editor.OperationCancelled) {

                // اگر عملیات کنسل نشده بود
                // یعنی ویرایش اتفاق افتاده

                // پس نوتیفیکیشن پیغام موفق میدیم
                UiNotif.Defults.Success_Edited();

                // و رفرش میکنیم تا تغییرات قابل مشاهده بشن
                BtRefresh_Click(sender, e);
            }
        }

        /// <summary>
        /// دابل کلیک روی دیتاگرید
        /// </summary>
        private void DgvDocs_DoubleClick(object sender, EventArgs e) {

            // اگر سندی انتخاب نشده بود، بی سروصدا متوقف میشیم
            if (!DgvDocs.RowIsSelected(this, false)) return;

            // اگر انتخاب شده بود، میدیمش دست دکمه ویرایش
            BtUpdate_Click(sender, e);
        }

        #endregion

        #region Delete Doc

        /// <summary>
        /// کلید دکمه حذف سند
        /// </summary>
        private void BtDelete_Click(object sender, EventArgs e) {

            // اگر هیچ سندی انتخاب نشده باشه،
            // پیغام داده و ادامه نمیدیم
            if (!DgvDocs.RowIsSelected(this)) return;

            // دریافت شناسه عددی سند انتخاب شده
            var selected = (long)DgvDocs.CurrentRow.Cells["شماره"].Value;

            // دریافت عنوان سند انتخاب شده
            var selected_title = DgvDocs.CurrentRow.Cells["عنوان"].Value.ToString();

            // دریافت تایید از کاربر
            var confirmed_delete = this.Question_Dialog
                ($"سند شماره «{selected}» با عنوان «{selected_title}» حذف شود؟");

            // اگر کاربر منصرف شد ادامه نمیدیم
            if (!confirmed_delete) return;

            // حذف سنداز دیتابیس
            var success_deleted = DocSvc.Database.DeleteDoc(selected);

            // اگر حذف سند ناموفق بود، ادامه نمیدیم
            if (!success_deleted) {

                UiNotif.Defults.Fail_Operation();
                return;
            }

            // در غیر اینصورت، نوتیفیکیشن پیغام موفق میدیم
            UiNotif.Defults.Success_Deleted();

            // بهمراه رفرش جهت مشاهده تغییرات
            BtRefresh_Click(sender, e);
        }

        #endregion

        #region Export Doc

        /// <summary>
        /// کلیک دکمه دریافت خروجی از سند
        /// </summary>
        private void BtExportDoc_Click(object sender, EventArgs e) {

            // اگر هیچ سندی انتخاب نشده باشه،
            // پیغام داده و ادامه نمیدیم
            if (!DgvDocs.RowIsSelected(this)) return;

            // دریافت شناسه عددی سند انتخاب شده
            var selected = (long)DgvDocs.CurrentRow.Cells["شماره"].Value;

            // دریافت عنوان سند انتخاب شده
            var selected_title = DgvDocs.CurrentRow.Cells["عنوان"].Value.ToString();

            // دریافت اطلاعات کامل سند از دیتابیس
            var selected_data = DocSvc.Database.GetDocById(selected);

            if (selected_data == null) {

                this.Info_Notic("این سند در پایگاه داده پیدا نشد");
                return;
            }

            // متن دیالوگ
            var dialog_txt = $"دریافت خروجی Json از سند شماره «{selected}» با عنوان «{selected_title}»";

            var exporter = new FExport();

            exporter.DocJson = selected_data.AsEntry().Ui_To_Json(true);

            exporter.Title = dialog_txt;

            this.Call_Win(Alternate_Instance: exporter);
        }

        #region Ill Add This Features Someday

        ///// <summary>
        ///// گزینه های در دسترس جهت دریافت خروجی از سند
        ///// </summary>
        //public enum ExportOptions {

        //    /// <summary>
        //    /// کپی کردن دیتای سند در قالب متن جیسون
        //    /// </summary>
        //    CopyAs_JsonText,

        //    /// <summary>
        //    /// ذخیره دیتای سند در قالب فایل جیسون
        //    /// </summary>
        //    SaveAs_JsonFile,

        //    /// <summary>
        //    /// ایجاد یه صفحه وب ساده و ایستا از سند
        //    /// </summary>
        //    SaveAs_StaticHtmlFile,

        //    /// <summary>
        //    /// ایجاد یه ویو از سند جهت استفاده در دات نت کور
        //    /// </summary>
        //    SaveAs_RazorViewFile
        //}

        #endregion

        #endregion

        #region Export All Docs

        private void BtExportAllDocs_Click(object sender, EventArgs e) {

            if (DgvDocs.Rows.Count <= 0) {

                this.Info_Notic("سندی برای خروجی گرفتن وجود ندارد، رفرش کنید یا ثبت کنید");
                return;
            }

            var accepted = this.Question_Dialog("از تمامی مستندات موجود خروجی میگیرید؟");

            if (!accepted) return;

            var data = DocSvc.Database.GetAllDocsWithMapping();

            var entries = new List<Document_Entry>();

            foreach (var doc in data)
                entries.Add(doc.AsEntry());

            var exporter = new FExport();

            exporter.DocJson = entries.ToArray().Ui_To_Json(true);

            exporter.Title = $"خروجی Json یکپارچه از همه مستندات موجود({data.Length} مورد)";

            this.Call_Win(Alternate_Instance: exporter);
        }

        #endregion

        #region Grid Resize Optimization

        // اینجا یه سری کد نوشتم برای
        // بهینه سازی تغییر سایز دیتاگرید

        // هدف اینه که وقتی سایز دیتاگرید در حال تغییره
        // از محاسبات ریل-تایم دیتاگرید و تغییر لحظه ای
        // جلوگیری کنیم تا حین تغییر سایز پنجره لگ نزنه

        // این راهکار برای زمانی که
        // دیتاگرید پر از اطلاعاته خیلی موثره

        /// <summary>
        /// تایمر مورد استفاده برای بهینه
        /// سازی تغییر سایز دیتاگرید
        /// </summary>
        private readonly Timer _resizeTimer = new Timer {
            Interval = 300
        };

        /// <summary>
        /// راه اندازی تغییر سایز بهینه برای دیتاگرید
        /// </summary>
        private void SetupGridResizeOptimization(DataGridView grid) {

            grid.Resize += (s, e) =>
            {
                // جلوگیری از محاسبه مجدد عرض ستون‌ها در حین تغییر سایز
                _resizeTimer.Stop();

                if (grid.AutoSizeColumnsMode != DataGridViewAutoSizeColumnsMode.None) {


                    grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    ControlRedraw.Suspend(DgvDocs);
                  //  grid.SuspendLayout();
                }

                _resizeTimer.Start();
            };

            _resizeTimer.Tick += (s, e) =>
            {
                _resizeTimer.Stop();

                // محاسبه مجدد عرض ستون‌ها پس از پایان تغییر سایز
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ControlRedraw.Resume(DgvDocs);
                //grid.ResumeLayout();
            };
        }



        #endregion
    }
}
