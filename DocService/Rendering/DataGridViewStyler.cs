
using System.Drawing;
using System.Windows.Forms;

namespace DocService {
    internal static class DataGridViewStyler {
        public static void Apply(DataGridView grid) {
            grid.SuspendLayout();

            try {
                grid.BackgroundColor = Color.White;
                grid.BorderStyle = BorderStyle.Fixed3D;
                grid.CellBorderStyle =
                    DataGridViewCellBorderStyle.Single;
                grid.GridColor = Color.FromArgb(225, 225, 225);

                grid.EnableHeadersVisualStyles = false;

                // سرستون‌ها
                grid.ColumnHeadersDefaultCellStyle.BackColor =
                    Color.FromArgb(245, 245, 245);
                grid.ColumnHeadersDefaultCellStyle.ForeColor =
                    Color.DarkSlateBlue;//.FromArgb(40, 40, 40);
                grid.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Shabnam", 9.5F, FontStyle.Bold);
                grid.ColumnHeadersDefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                grid.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                    Color.FromArgb(245, 245, 245);
                grid.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                    Color.FromArgb(40, 40, 40);

                grid.ColumnHeadersBorderStyle =
                    DataGridViewHeaderBorderStyle.Single;

                grid.ColumnHeadersHeight = 38;
                grid.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

                // سلول‌ها
                grid.DefaultCellStyle.Font =
                    new Font("Shabnam", 9.5F, FontStyle.Regular);
                grid.DefaultCellStyle.ForeColor =
                    Color/*.Indigo;//.DarkSlateBlue;//*/.Teal;//.FromArgb(45, 45, 45);
                grid.DefaultCellStyle.BackColor = Color.White;
                grid.DefaultCellStyle.SelectionBackColor =
                    Color.FromArgb(220, 235, 250);
                grid.DefaultCellStyle.SelectionForeColor =
                    Color.FromArgb(25, 55, 85);
                grid.DefaultCellStyle.Padding =
                    new Padding(0);// 4, 2, 4, 2);
                grid.DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                // سطرهای یک‌درمیان سفید می‌مانند
                grid.AlternatingRowsDefaultCellStyle.BackColor =
                    Color.White;

                grid.RowTemplate.Height = 32;
                grid.AllowUserToAddRows = false;
                grid.AllowUserToDeleteRows = false;
                grid.AllowUserToResizeRows = false;
                grid.MultiSelect = false;
                grid.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                grid.ReadOnly = true;

                grid.RowHeadersVisible = false;

                // جلوگیری از اندازه‌گیری پرهزینهٔ خودکار
                grid.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                grid.AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.None;
            }
            finally {
                grid.ResumeLayout();
            }
        }
    }
}
