namespace DocService {
    partial class FInsertUpdateDoc {
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
            this.DgvSections = new System.Windows.Forms.DataGridView();
            this.Alternate_Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TbDocTitle = new TextBoxtest.TxtProNet();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtViewDocAsLive = new System.Windows.Forms.Button();
            this.BtEditSection = new System.Windows.Forms.Button();
            this.BtDeleteSection = new System.Windows.Forms.Button();
            this.BtAddSection = new System.Windows.Forms.Button();
            this.BtSaveChanges = new System.Windows.Forms.Button();
            this.BtClose = new System.Windows.Forms.Button();
            this.BtHelp = new System.Windows.Forms.Button();
            this.BtCancelAndClose = new System.Windows.Forms.Button();
            this.BtMaximize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSections)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtBorderFucker
            // 
            this.BtBorderFucker.FlatAppearance.BorderSize = 0;
            this.BtBorderFucker.Location = new System.Drawing.Point(0, 526);
            this.BtBorderFucker.Size = new System.Drawing.Size(637, 1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Shabnam", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.label1.Size = new System.Drawing.Size(637, 40);
            this.label1.TabIndex = 25;
            this.label1.Text = "ثبت / ویرایش سند";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DgvSections
            // 
            this.DgvSections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSections.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alternate_Action,
            this.Section_Title,
            this.Column1});
            this.DgvSections.Location = new System.Drawing.Point(12, 173);
            this.DgvSections.Name = "DgvSections";
            this.DgvSections.Size = new System.Drawing.Size(613, 235);
            this.DgvSections.TabIndex = 29;
            this.DgvSections.DoubleClick += new System.EventHandler(this.DgvSections_DoubleClick);
            // 
            // Alternate_Action
            // 
            this.Alternate_Action.DataPropertyName = "Alternate_Action";
            this.Alternate_Action.HeaderText = "اکشن اضافه";
            this.Alternate_Action.Name = "Alternate_Action";
            this.Alternate_Action.Visible = false;
            // 
            // Section_Title
            // 
            this.Section_Title.DataPropertyName = "Section_Title";
            this.Section_Title.HeaderText = "عنوان سوال / مبحث / مشکل / مسئله";
            this.Section_Title.Name = "Section_Title";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Section_Text";
            this.Column1.HeaderText = "پاسخ / راه حل / مستندات متنی";
            this.Column1.Name = "Column1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Shabnam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(512, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 30;
            this.label2.Text = "عنوان : *";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbDocTitle
            // 
            this.TbDocTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDocTitle.AutoSprator = false;
            this.TbDocTitle.BackColor = System.Drawing.Color.White;
            this.TbDocTitle.EnterToTab = true;
            this.TbDocTitle.EscToClose = true;
            this.TbDocTitle.FocusBackColor = System.Drawing.Color.WhiteSmoke;
            this.TbDocTitle.FocusFont = new System.Drawing.Font("Shabnam", 15.75F, System.Drawing.FontStyle.Bold);
            this.TbDocTitle.FocusForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TbDocTitle.FocusTextSelect = true;
            this.TbDocTitle.Font = new System.Drawing.Font("Shabnam", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDocTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TbDocTitle.Location = new System.Drawing.Point(12, 88);
            this.TbDocTitle.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.TbDocTitle.MessageEmptyShowDialog = false;
            this.TbDocTitle.MessegeEmpty = "";
            this.TbDocTitle.MessegeEmptyInFormRight = true;
            this.TbDocTitle.MessegeEmptyShowInForm = false;
            this.TbDocTitle.Name = "TbDocTitle";
            this.TbDocTitle.Size = new System.Drawing.Size(613, 36);
            this.TbDocTitle.TabIndex = 0;
            this.TbDocTitle.TypeAllChar = true;
            this.TbDocTitle.TypeDateShamsi = false;
            this.TbDocTitle.TypeEnglishOnly = false;
            this.TbDocTitle.TypeFarsiOnly = false;
            this.TbDocTitle.TypeNumricOnly = false;
            this.TbDocTitle.TypeOtherChar = "";
            this.TbDocTitle.TypeTime = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Shabnam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(350, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 27);
            this.label3.TabIndex = 32;
            this.label3.Text = "مفاد مندرج : * (حداقل یک مورد)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtViewDocAsLive);
            this.panel1.Controls.Add(this.BtEditSection);
            this.panel1.Controls.Add(this.BtDeleteSection);
            this.panel1.Controls.Add(this.BtAddSection);
            this.panel1.Location = new System.Drawing.Point(12, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 57);
            this.panel1.TabIndex = 33;
            // 
            // BtViewDocAsLive
            // 
            this.BtViewDocAsLive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtViewDocAsLive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtViewDocAsLive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtViewDocAsLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtViewDocAsLive.Font = new System.Drawing.Font("Shabnam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtViewDocAsLive.ForeColor = System.Drawing.Color.Teal;
            this.BtViewDocAsLive.Image = global::DocService.Properties.Resources.thin_0078_document_file_word_office_doc_text;
            this.BtViewDocAsLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtViewDocAsLive.Location = new System.Drawing.Point(7, 8);
            this.BtViewDocAsLive.Name = "BtViewDocAsLive";
            this.BtViewDocAsLive.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.BtViewDocAsLive.Size = new System.Drawing.Size(168, 40);
            this.BtViewDocAsLive.TabIndex = 4;
            this.BtViewDocAsLive.Text = "پیشنمایش سند";
            this.BtViewDocAsLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtViewDocAsLive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtViewDocAsLive.UseVisualStyleBackColor = true;
            this.BtViewDocAsLive.Click += new System.EventHandler(this.BtViewDocAsLive_Click);
            // 
            // BtEditSection
            // 
            this.BtEditSection.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtEditSection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.BtEditSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtEditSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEditSection.Font = new System.Drawing.Font("Shabnam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEditSection.ForeColor = System.Drawing.Color.Indigo;
            this.BtEditSection.Image = global::DocService.Properties.Resources.thin_0003_write_pencil_new_edit;
            this.BtEditSection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtEditSection.Location = new System.Drawing.Point(308, 8);
            this.BtEditSection.Name = "BtEditSection";
            this.BtEditSection.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.BtEditSection.Size = new System.Drawing.Size(139, 40);
            this.BtEditSection.TabIndex = 2;
            this.BtEditSection.Text = " ویرایش مفاد";
            this.BtEditSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtEditSection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtEditSection.UseVisualStyleBackColor = true;
            this.BtEditSection.Click += new System.EventHandler(this.BtEditSection_Click);
            // 
            // BtDeleteSection
            // 
            this.BtDeleteSection.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtDeleteSection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtDeleteSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtDeleteSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDeleteSection.Font = new System.Drawing.Font("Shabnam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDeleteSection.ForeColor = System.Drawing.Color.Maroon;
            this.BtDeleteSection.Image = global::DocService.Properties.Resources.thin_0056_bin_trash_recycle_delete_garbage_empty;
            this.BtDeleteSection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtDeleteSection.Location = new System.Drawing.Point(183, 8);
            this.BtDeleteSection.Name = "BtDeleteSection";
            this.BtDeleteSection.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.BtDeleteSection.Size = new System.Drawing.Size(117, 40);
            this.BtDeleteSection.TabIndex = 3;
            this.BtDeleteSection.Text = "حذف مفاد";
            this.BtDeleteSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtDeleteSection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtDeleteSection.UseVisualStyleBackColor = true;
            this.BtDeleteSection.Click += new System.EventHandler(this.BtDeleteSection_Click);
            // 
            // BtAddSection
            // 
            this.BtAddSection.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtAddSection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.BtAddSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtAddSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAddSection.Font = new System.Drawing.Font("Shabnam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAddSection.ForeColor = System.Drawing.Color.Indigo;
            this.BtAddSection.Image = global::DocService.Properties.Resources.thin_0151_plus_add_new;
            this.BtAddSection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAddSection.Location = new System.Drawing.Point(455, 8);
            this.BtAddSection.Name = "BtAddSection";
            this.BtAddSection.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.BtAddSection.Size = new System.Drawing.Size(149, 40);
            this.BtAddSection.TabIndex = 1;
            this.BtAddSection.Text = "درج مفاد جدید";
            this.BtAddSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAddSection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtAddSection.UseVisualStyleBackColor = true;
            this.BtAddSection.Click += new System.EventHandler(this.BtAddSection_Click);
            // 
            // BtSaveChanges
            // 
            this.BtSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSaveChanges.BackColor = System.Drawing.Color.White;
            this.BtSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSaveChanges.Font = new System.Drawing.Font("Shabnam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSaveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtSaveChanges.Image = global::DocService.Properties.Resources.thin_0156_checkbox_ok_successful;
            this.BtSaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtSaveChanges.Location = new System.Drawing.Point(196, 475);
            this.BtSaveChanges.Name = "BtSaveChanges";
            this.BtSaveChanges.Padding = new System.Windows.Forms.Padding(0, 0, 4, 2);
            this.BtSaveChanges.Size = new System.Drawing.Size(429, 40);
            this.BtSaveChanges.TabIndex = 5;
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
            this.BtClose.Size = new System.Drawing.Size(40, 40);
            this.BtClose.TabIndex = 9;
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
            this.BtHelp.Location = new System.Drawing.Point(80, 0);
            this.BtHelp.Name = "BtHelp";
            this.BtHelp.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.BtHelp.Size = new System.Drawing.Size(40, 40);
            this.BtHelp.TabIndex = 7;
            this.BtHelp.Text = " ";
            this.BtHelp.UseVisualStyleBackColor = false;
            this.BtHelp.Click += new System.EventHandler(this.BtHelp_Click);
            // 
            // BtCancelAndClose
            // 
            this.BtCancelAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtCancelAndClose.BackColor = System.Drawing.Color.White;
            this.BtCancelAndClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtCancelAndClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtCancelAndClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCancelAndClose.Font = new System.Drawing.Font("Shabnam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancelAndClose.ForeColor = System.Drawing.Color.Maroon;
            this.BtCancelAndClose.Image = global::DocService.Properties.Resources.thin_0060_error_warning_danger_stop_delete_exit;
            this.BtCancelAndClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCancelAndClose.Location = new System.Drawing.Point(12, 475);
            this.BtCancelAndClose.Name = "BtCancelAndClose";
            this.BtCancelAndClose.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.BtCancelAndClose.Size = new System.Drawing.Size(176, 40);
            this.BtCancelAndClose.TabIndex = 6;
            this.BtCancelAndClose.Text = " انصراف و بازگشت";
            this.BtCancelAndClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCancelAndClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtCancelAndClose.UseVisualStyleBackColor = false;
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
            this.BtMaximize.Location = new System.Drawing.Point(40, 0);
            this.BtMaximize.Name = "BtMaximize";
            this.BtMaximize.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.BtMaximize.Size = new System.Drawing.Size(40, 40);
            this.BtMaximize.TabIndex = 8;
            this.BtMaximize.UseVisualStyleBackColor = false;
            // 
            // FInsertUpdateDoc
            // 
            this.AcceptButton = this.BtSaveChanges;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtClose;
            this.ClientSize = new System.Drawing.Size(637, 527);
            this.Controls.Add(this.BtHelp);
            this.Controls.Add(this.BtCancelAndClose);
            this.Controls.Add(this.BtSaveChanges);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbDocTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvSections);
            this.Controls.Add(this.BtMaximize);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.label1);
            this.Name = "FInsertUpdateDoc";
            this.Text = "FInsertUpdateDoc";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.BtClose, 0);
            this.Controls.SetChildIndex(this.BtMaximize, 0);
            this.Controls.SetChildIndex(this.DgvSections, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TbDocTitle, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.BtBorderFucker, 0);
            this.Controls.SetChildIndex(this.BtSaveChanges, 0);
            this.Controls.SetChildIndex(this.BtCancelAndClose, 0);
            this.Controls.SetChildIndex(this.BtHelp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSections)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtMaximize;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvSections;
        private System.Windows.Forms.Label label2;
        private TextBoxtest.TxtProNet TbDocTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtViewDocAsLive;
        private System.Windows.Forms.Button BtEditSection;
        private System.Windows.Forms.Button BtDeleteSection;
        private System.Windows.Forms.Button BtAddSection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtSaveChanges;
        private System.Windows.Forms.Button BtCancelAndClose;
        private System.Windows.Forms.Button BtHelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alternate_Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}