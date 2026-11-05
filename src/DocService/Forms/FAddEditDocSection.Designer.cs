namespace DocService {
    partial class FAddEditDocSection {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.TbSectionTitle = new TextBoxtest.TxtProNet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbSectionText = new TextBoxtest.TxtProNet();
            this.BtSaveChanges = new System.Windows.Forms.Button();
            this.BtClose = new System.Windows.Forms.Button();
            this.BtHelp = new System.Windows.Forms.Button();
            this.BtMaximize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtBorderFucker
            // 
            this.BtBorderFucker.FlatAppearance.BorderSize = 0;
            this.BtBorderFucker.Location = new System.Drawing.Point(0, 589);
            this.BtBorderFucker.Size = new System.Drawing.Size(761, 1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Shabnam", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.label1.Size = new System.Drawing.Size(761, 35);
            this.label1.TabIndex = 29;
            this.label1.Text = "افزودن / ویرایش ماده جدید به سند";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbSectionTitle
            // 
            this.TbSectionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSectionTitle.AutoSprator = false;
            this.TbSectionTitle.BackColor = System.Drawing.Color.White;
            this.TbSectionTitle.EnterToTab = true;
            this.TbSectionTitle.EscToClose = true;
            this.TbSectionTitle.FocusBackColor = System.Drawing.Color.WhiteSmoke;
            this.TbSectionTitle.FocusFont = new System.Drawing.Font("Shabnam", 15.75F, System.Drawing.FontStyle.Bold);
            this.TbSectionTitle.FocusForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TbSectionTitle.FocusTextSelect = true;
            this.TbSectionTitle.Font = new System.Drawing.Font("Shabnam", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSectionTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TbSectionTitle.Location = new System.Drawing.Point(12, 76);
            this.TbSectionTitle.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.TbSectionTitle.MessageEmptyShowDialog = false;
            this.TbSectionTitle.MessegeEmpty = "";
            this.TbSectionTitle.MessegeEmptyInFormRight = true;
            this.TbSectionTitle.MessegeEmptyShowInForm = false;
            this.TbSectionTitle.Name = "TbSectionTitle";
            this.TbSectionTitle.Size = new System.Drawing.Size(735, 36);
            this.TbSectionTitle.TabIndex = 0;
            this.TbSectionTitle.TypeAllChar = true;
            this.TbSectionTitle.TypeDateShamsi = false;
            this.TbSectionTitle.TypeEnglishOnly = false;
            this.TbSectionTitle.TypeFarsiOnly = false;
            this.TbSectionTitle.TypeNumricOnly = false;
            this.TbSectionTitle.TypeOtherChar = "";
            this.TbSectionTitle.TypeTime = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Shabnam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(460, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 27);
            this.label2.TabIndex = 32;
            this.label2.Text = "عنوان سوال / مبحث / مشکل / مسئله : *";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Shabnam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(258, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(493, 27);
            this.label3.TabIndex = 32;
            this.label3.Text = "مستندات متنی : *";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbSectionText
            // 
            this.TbSectionText.AcceptsReturn = true;
            this.TbSectionText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSectionText.AutoSprator = false;
            this.TbSectionText.BackColor = System.Drawing.Color.White;
            this.TbSectionText.EnterToTab = false;
            this.TbSectionText.EscToClose = true;
            this.TbSectionText.FocusBackColor = System.Drawing.Color.WhiteSmoke;
            this.TbSectionText.FocusFont = new System.Drawing.Font("Shabnam", 15.75F, System.Drawing.FontStyle.Bold);
            this.TbSectionText.FocusForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TbSectionText.FocusTextSelect = true;
            this.TbSectionText.Font = new System.Drawing.Font("Shabnam", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSectionText.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TbSectionText.Location = new System.Drawing.Point(12, 159);
            this.TbSectionText.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.TbSectionText.MessageEmptyShowDialog = false;
            this.TbSectionText.MessegeEmpty = "";
            this.TbSectionText.MessegeEmptyInFormRight = true;
            this.TbSectionText.MessegeEmptyShowInForm = false;
            this.TbSectionText.Multiline = true;
            this.TbSectionText.Name = "TbSectionText";
            this.TbSectionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbSectionText.Size = new System.Drawing.Size(735, 365);
            this.TbSectionText.TabIndex = 1;
            this.TbSectionText.TypeAllChar = true;
            this.TbSectionText.TypeDateShamsi = false;
            this.TbSectionText.TypeEnglishOnly = false;
            this.TbSectionText.TypeFarsiOnly = false;
            this.TbSectionText.TypeNumricOnly = false;
            this.TbSectionText.TypeOtherChar = "";
            this.TbSectionText.TypeTime = false;
            // 
            // BtSaveChanges
            // 
            this.BtSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSaveChanges.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSaveChanges.Font = new System.Drawing.Font("Shabnam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSaveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtSaveChanges.Image = global::DocService.Properties.Resources.thin_0156_checkbox_ok_successful;
            this.BtSaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtSaveChanges.Location = new System.Drawing.Point(12, 537);
            this.BtSaveChanges.Name = "BtSaveChanges";
            this.BtSaveChanges.Padding = new System.Windows.Forms.Padding(0, 0, 4, 2);
            this.BtSaveChanges.Size = new System.Drawing.Size(735, 40);
            this.BtSaveChanges.TabIndex = 2;
            this.BtSaveChanges.Text = "ثبت / ذخیره تغییرات - enter";
            this.BtSaveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtSaveChanges.UseVisualStyleBackColor = false;
            this.BtSaveChanges.Click += new System.EventHandler(this.BtSaveChanges_Click);
            // 
            // BtClose
            // 
            this.BtClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtClose.FlatAppearance.BorderSize = 0;
            this.BtClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtClose.Font = new System.Drawing.Font("Shabnam", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtClose.ForeColor = System.Drawing.Color.Maroon;
            this.BtClose.Image = global::DocService.Properties.Resources.thin_0155_delete_remove_exit_close_checkbox;
            this.BtClose.Location = new System.Drawing.Point(0, 0);
            this.BtClose.Name = "BtClose";
            this.BtClose.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.BtClose.Size = new System.Drawing.Size(35, 35);
            this.BtClose.TabIndex = 5;
            this.BtClose.UseVisualStyleBackColor = false;
            // 
            // BtHelp
            // 
            this.BtHelp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtHelp.FlatAppearance.BorderSize = 0;
            this.BtHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtHelp.Font = new System.Drawing.Font("Shabnam", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtHelp.ForeColor = System.Drawing.Color.Indigo;
            this.BtHelp.Image = global::DocService.Properties.Resources.thin_0552_about_question_faq_help;
            this.BtHelp.Location = new System.Drawing.Point(70, 0);
            this.BtHelp.Name = "BtHelp";
            this.BtHelp.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.BtHelp.Size = new System.Drawing.Size(35, 35);
            this.BtHelp.TabIndex = 3;
            this.BtHelp.Text = " ";
            this.BtHelp.UseVisualStyleBackColor = false;
            this.BtHelp.Click += new System.EventHandler(this.BtHelp_Click);
            // 
            // BtMaximize
            // 
            this.BtMaximize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtMaximize.FlatAppearance.BorderSize = 0;
            this.BtMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtMaximize.Font = new System.Drawing.Font("Shabnam", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMaximize.ForeColor = System.Drawing.Color.Indigo;
            this.BtMaximize.Image = global::DocService.Properties.Resources.thin_0137_zoom_expand_maximize_window;
            this.BtMaximize.Location = new System.Drawing.Point(35, 0);
            this.BtMaximize.Name = "BtMaximize";
            this.BtMaximize.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.BtMaximize.Size = new System.Drawing.Size(35, 35);
            this.BtMaximize.TabIndex = 4;
            this.BtMaximize.UseVisualStyleBackColor = false;
            // 
            // FAddEditDocSection
            // 
            this.AcceptButton = this.BtSaveChanges;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtClose;
            this.ClientSize = new System.Drawing.Size(761, 590);
            this.Controls.Add(this.BtSaveChanges);
            this.Controls.Add(this.TbSectionText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbSectionTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtHelp);
            this.Controls.Add(this.BtMaximize);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.label1);
            this.Name = "FAddEditDocSection";
            this.Text = "FAddEditDocSection";
            this.Controls.SetChildIndex(this.BtBorderFucker, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.BtClose, 0);
            this.Controls.SetChildIndex(this.BtMaximize, 0);
            this.Controls.SetChildIndex(this.BtHelp, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TbSectionTitle, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TbSectionText, 0);
            this.Controls.SetChildIndex(this.BtSaveChanges, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtHelp;
        private System.Windows.Forms.Button BtMaximize;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.Label label1;
        private TextBoxtest.TxtProNet TbSectionTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private TextBoxtest.TxtProNet TbSectionText;
        private System.Windows.Forms.Button BtSaveChanges;
    }
}