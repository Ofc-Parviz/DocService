namespace DocService {
    partial class FMain {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.label1 = new System.Windows.Forms.Label();
            this.DgvDocs = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtExportAllDocs = new System.Windows.Forms.Button();
            this.BtExportDoc = new System.Windows.Forms.Button();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.BtDelete = new System.Windows.Forms.Button();
            this.BtInsert = new System.Windows.Forms.Button();
            this.BtRefresh = new System.Windows.Forms.Button();
            this.HelpTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtHelpDoc = new System.Windows.Forms.Button();
            this.BtMaximize = new System.Windows.Forms.Button();
            this.BtClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocs)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtBorderFucker
            // 
            this.BtBorderFucker.FlatAppearance.BorderSize = 0;
            this.BtBorderFucker.Location = new System.Drawing.Point(0, 610);
            this.BtBorderFucker.Size = new System.Drawing.Size(984, 1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Shabnam", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 50, 0);
            this.label1.Size = new System.Drawing.Size(984, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "ابزار مدیریت مستندات";
            // 
            // DgvDocs
            // 
            this.DgvDocs.AllowUserToAddRows = false;
            this.DgvDocs.AllowUserToDeleteRows = false;
            this.DgvDocs.AllowUserToResizeRows = false;
            this.DgvDocs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDocs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDocs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvDocs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvDocs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Shabnam", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDocs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvDocs.ColumnHeadersHeight = 38;
            this.DgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Shabnam", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDocs.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDocs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvDocs.EnableHeadersVisualStyles = false;
            this.DgvDocs.GridColor = System.Drawing.Color.Gray;
            this.DgvDocs.Location = new System.Drawing.Point(10, 64);
            this.DgvDocs.MultiSelect = false;
            this.DgvDocs.Name = "DgvDocs";
            this.DgvDocs.RowHeadersVisible = false;
            this.DgvDocs.RowTemplate.Height = 45;
            this.DgvDocs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDocs.Size = new System.Drawing.Size(962, 466);
            this.DgvDocs.TabIndex = 13;
            this.DgvDocs.DoubleClick += new System.EventHandler(this.DgvDocs_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtExportAllDocs);
            this.panel1.Controls.Add(this.BtExportDoc);
            this.panel1.Controls.Add(this.BtUpdate);
            this.panel1.Controls.Add(this.BtDelete);
            this.panel1.Controls.Add(this.BtInsert);
            this.panel1.Controls.Add(this.BtRefresh);
            this.panel1.Location = new System.Drawing.Point(10, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 57);
            this.panel1.TabIndex = 14;
            // 
            // BtExportAllDocs
            // 
            this.BtExportAllDocs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtExportAllDocs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtExportAllDocs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtExportAllDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExportAllDocs.Font = new System.Drawing.Font("Shabnam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtExportAllDocs.ForeColor = System.Drawing.Color.Teal;
            this.BtExportAllDocs.Image = global::DocService.Properties.Resources.thin_0078_document_file_word_office_doc_text;
            this.BtExportAllDocs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtExportAllDocs.Location = new System.Drawing.Point(159, 8);
            this.BtExportAllDocs.Name = "BtExportAllDocs";
            this.BtExportAllDocs.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.BtExportAllDocs.Size = new System.Drawing.Size(191, 40);
            this.BtExportAllDocs.TabIndex = 8;
            this.BtExportAllDocs.Text = "خروجی کل مستندات";
            this.BtExportAllDocs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtExportAllDocs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtExportAllDocs.UseVisualStyleBackColor = true;
            this.BtExportAllDocs.Click += new System.EventHandler(this.BtExportAllDocs_Click);
            // 
            // BtExportDoc
            // 
            this.BtExportDoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtExportDoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtExportDoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtExportDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExportDoc.Font = new System.Drawing.Font("Shabnam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtExportDoc.ForeColor = System.Drawing.Color.Teal;
            this.BtExportDoc.Image = global::DocService.Properties.Resources.thin_0078_document_file_word_office_doc_text;
            this.BtExportDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtExportDoc.Location = new System.Drawing.Point(357, 8);
            this.BtExportDoc.Name = "BtExportDoc";
            this.BtExportDoc.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.BtExportDoc.Size = new System.Drawing.Size(168, 40);
            this.BtExportDoc.TabIndex = 7;
            this.BtExportDoc.Text = "خروجی تکی از سند";
            this.BtExportDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtExportDoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtExportDoc.UseVisualStyleBackColor = true;
            this.BtExportDoc.Click += new System.EventHandler(this.BtExportDoc_Click);
            // 
            // BtUpdate
            // 
            this.BtUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.BtUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtUpdate.Font = new System.Drawing.Font("Shabnam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtUpdate.ForeColor = System.Drawing.Color.Indigo;
            this.BtUpdate.Image = global::DocService.Properties.Resources.thin_0003_write_pencil_new_edit;
            this.BtUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtUpdate.Location = new System.Drawing.Point(657, 8);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.BtUpdate.Size = new System.Drawing.Size(139, 40);
            this.BtUpdate.TabIndex = 6;
            this.BtUpdate.Text = " ویرایش سند";
            this.BtUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtUpdate.UseVisualStyleBackColor = true;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // BtDelete
            // 
            this.BtDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDelete.Font = new System.Drawing.Font("Shabnam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDelete.ForeColor = System.Drawing.Color.Maroon;
            this.BtDelete.Image = global::DocService.Properties.Resources.thin_0056_bin_trash_recycle_delete_garbage_empty;
            this.BtDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtDelete.Location = new System.Drawing.Point(532, 8);
            this.BtDelete.Name = "BtDelete";
            this.BtDelete.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.BtDelete.Size = new System.Drawing.Size(117, 40);
            this.BtDelete.TabIndex = 5;
            this.BtDelete.Text = "حذف سند";
            this.BtDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtDelete.UseVisualStyleBackColor = true;
            this.BtDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // BtInsert
            // 
            this.BtInsert.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.BtInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtInsert.Font = new System.Drawing.Font("Shabnam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtInsert.ForeColor = System.Drawing.Color.Indigo;
            this.BtInsert.Image = global::DocService.Properties.Resources.thin_0151_plus_add_new;
            this.BtInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtInsert.Location = new System.Drawing.Point(804, 8);
            this.BtInsert.Name = "BtInsert";
            this.BtInsert.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.BtInsert.Size = new System.Drawing.Size(149, 40);
            this.BtInsert.TabIndex = 4;
            this.BtInsert.Text = "ثبت سند جدید";
            this.BtInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtInsert.UseVisualStyleBackColor = true;
            this.BtInsert.Click += new System.EventHandler(this.BtInsert_Click);
            // 
            // BtRefresh
            // 
            this.BtRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.BtRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtRefresh.Font = new System.Drawing.Font("Shabnam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRefresh.ForeColor = System.Drawing.Color.Indigo;
            this.BtRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtRefresh.Image")));
            this.BtRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtRefresh.Location = new System.Drawing.Point(7, 8);
            this.BtRefresh.Name = "BtRefresh";
            this.BtRefresh.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.BtRefresh.Size = new System.Drawing.Size(144, 40);
            this.BtRefresh.TabIndex = 3;
            this.BtRefresh.Text = "رفرش/بازخوانی";
            this.BtRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtRefresh.UseVisualStyleBackColor = true;
            this.BtRefresh.Click += new System.EventHandler(this.BtRefresh_Click);
            // 
            // HelpTooltip
            // 
            this.HelpTooltip.IsBalloon = true;
            this.HelpTooltip.ShowAlways = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Font = new System.Drawing.Font("Shabnam", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(143, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "اوپن سورس";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Font = new System.Drawing.Font("Shabnam", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(229, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "نگارش 1.0.0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(793, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Github.com/Ofc-Parviz";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = global::DocService.Properties.Resources.DocServiceLogo;
            this.pictureBox1.Location = new System.Drawing.Point(932, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // BtHelpDoc
            // 
            this.BtHelpDoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtHelpDoc.FlatAppearance.BorderSize = 0;
            this.BtHelpDoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtHelpDoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtHelpDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtHelpDoc.Font = new System.Drawing.Font("Shabnam", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtHelpDoc.ForeColor = System.Drawing.Color.Indigo;
            this.BtHelpDoc.Image = global::DocService.Properties.Resources.thin_0552_about_question_faq_help;
            this.BtHelpDoc.Location = new System.Drawing.Point(88, 0);
            this.BtHelpDoc.Name = "BtHelpDoc";
            this.BtHelpDoc.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.BtHelpDoc.Size = new System.Drawing.Size(44, 50);
            this.BtHelpDoc.TabIndex = 24;
            this.BtHelpDoc.Text = " ";
            this.BtHelpDoc.UseVisualStyleBackColor = false;
            this.BtHelpDoc.Click += new System.EventHandler(this.BtHelpDoc_Click);
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
            this.BtMaximize.Location = new System.Drawing.Point(44, 0);
            this.BtMaximize.Name = "BtMaximize";
            this.BtMaximize.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.BtMaximize.Size = new System.Drawing.Size(44, 50);
            this.BtMaximize.TabIndex = 21;
            this.BtMaximize.UseVisualStyleBackColor = false;
            // 
            // BtClose
            // 
            this.BtClose.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.BtClose.Size = new System.Drawing.Size(44, 50);
            this.BtClose.TabIndex = 22;
            this.BtClose.UseVisualStyleBackColor = false;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtHelpDoc);
            this.Controls.Add(this.BtMaximize);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvDocs);
            this.Controls.Add(this.label1);
            this.Name = "FMain";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.DgvDocs, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.BtClose, 0);
            this.Controls.SetChildIndex(this.BtMaximize, 0);
            this.Controls.SetChildIndex(this.BtHelpDoc, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.BtBorderFucker, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocs)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvDocs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtMaximize;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.Button BtHelpDoc;
        private System.Windows.Forms.Button BtRefresh;
        private System.Windows.Forms.Button BtInsert;
        private System.Windows.Forms.Button BtDelete;
        private System.Windows.Forms.Button BtUpdate;
        private System.Windows.Forms.Button BtExportDoc;
        private System.Windows.Forms.ToolTip HelpTooltip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtExportAllDocs;
    }
}

