using Sm.Ui.Core;
using System;
using System.IO;
using System.Windows.Forms;

namespace DocService {
    public partial class FExport : DefWin {
        public FExport() {

            InitializeComponent();
            this.Make_Movable(label1);

            Load += FExport_Load;

            BtMaximize.Click += (s, e)
                => this.MiniMaxiMize_Action();

            Add_CloserBtn(BtClose);
            Add_CloserBtn(BtCancelAndClose);
        }

        public string Title { get; set; } = string.Empty;
        public string DocJson { get; set; } = string.Empty;

        private void FExport_Load(object sender, EventArgs e) {

            Text = label1.Text = Title;
            TbDocJson.Text = DocJson;
        }

        private void BtCopyDocJson_Click(object sender, EventArgs e) {

            Clipboard.SetText(TbDocJson.Text);
            UiNotif.Defults.Success_Operation();
        }

        private void BtSaveDocFile_Click(object sender, EventArgs e) {

            using (var dialog = new SaveFileDialog()) {

                dialog.Filter = "Json File(*.json)|*.json|Text File(*.txt)|*.txt|Any File(*.*)|*.*";

                try {

                    if (dialog.ShowDialog() != DialogResult.Cancel) {

                        File.WriteAllText(dialog.FileName, TbDocJson.Text);
                        UiNotif.Defults.Success_Operation();
                    }
                }
                catch {
                    UiNotif.Send_Info("ممکن است ذخیره نشده باشد","خطایی رخ داد");
                }
            }
        }

        private void BtHelp_Click(object sender, EventArgs e) {

            this.Info_Notic("خروجی Json از سند برای استفاده در جاهای دیگر کاربرد دارد");
        }
    }
}
