namespace NotesAppCsharp
{
    partial class NoteApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameofnote = new System.Windows.Forms.Label();
            this.titleofapp = new System.Windows.Forms.Label();
            this.notecontents = new System.Windows.Forms.Label();
            this.textBoxNoteName = new System.Windows.Forms.TextBox();
            this.textBoxNoteContent = new System.Windows.Forms.TextBox();
            this.imageLabel = new System.Windows.Forms.Label();
            this.drawImageButton = new System.Windows.Forms.Button();
            this.noteNames = new System.Windows.Forms.DataGridView();
            this.uploadImageButton = new System.Windows.Forms.Button();
            this.imageStatusLabel = new System.Windows.Forms.Label();
            this.labelUploaded = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noteNames)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameofnote
            // 
            this.nameofnote.AutoSize = true;
            this.nameofnote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameofnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.nameofnote.Location = new System.Drawing.Point(3, 0);
            this.nameofnote.Name = "nameofnote";
            this.nameofnote.Size = new System.Drawing.Size(157, 40);
            this.nameofnote.TabIndex = 0;
            this.nameofnote.Text = "Name of Note:";
            this.nameofnote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleofapp
            // 
            this.titleofapp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleofapp.AutoSize = true;
            this.titleofapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.titleofapp.Location = new System.Drawing.Point(23, 9);
            this.titleofapp.Name = "titleofapp";
            this.titleofapp.Size = new System.Drawing.Size(339, 36);
            this.titleofapp.TabIndex = 1;
            this.titleofapp.Text = "Welcome to DrawNote!";
            this.titleofapp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // notecontents
            // 
            this.notecontents.AutoSize = true;
            this.notecontents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notecontents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.notecontents.Location = new System.Drawing.Point(3, 40);
            this.notecontents.Name = "notecontents";
            this.notecontents.Size = new System.Drawing.Size(157, 357);
            this.notecontents.TabIndex = 2;
            this.notecontents.Text = "Note Contents:";
            this.notecontents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNoteName
            // 
            this.textBoxNoteName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNoteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxNoteName.Location = new System.Drawing.Point(166, 3);
            this.textBoxNoteName.Multiline = true;
            this.textBoxNoteName.Name = "textBoxNoteName";
            this.textBoxNoteName.Size = new System.Drawing.Size(317, 34);
            this.textBoxNoteName.TabIndex = 3;
            // 
            // textBoxNoteContent
            // 
            this.textBoxNoteContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNoteContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxNoteContent.Location = new System.Drawing.Point(188, 65);
            this.textBoxNoteContent.Margin = new System.Windows.Forms.Padding(25);
            this.textBoxNoteContent.Multiline = true;
            this.textBoxNoteContent.Name = "textBoxNoteContent";
            this.textBoxNoteContent.Size = new System.Drawing.Size(273, 307);
            this.textBoxNoteContent.TabIndex = 4;
            // 
            // imageLabel
            // 
            this.imageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imageLabel.AutoSize = true;
            this.imageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.imageLabel.Location = new System.Drawing.Point(24, 489);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(135, 25);
            this.imageLabel.TabIndex = 5;
            this.imageLabel.Text = "Add Image?:";
            // 
            // drawImageButton
            // 
            this.drawImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.drawImageButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.drawImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.drawImageButton.Location = new System.Drawing.Point(329, 475);
            this.drawImageButton.Name = "drawImageButton";
            this.drawImageButton.Size = new System.Drawing.Size(110, 69);
            this.drawImageButton.TabIndex = 7;
            this.drawImageButton.Text = "Draw Image";
            this.drawImageButton.UseVisualStyleBackColor = true;
            this.drawImageButton.Click += new System.EventHandler(this.drawImageButton_Click);
            // 
            // noteNames
            // 
            this.noteNames.AllowUserToAddRows = false;
            this.noteNames.AllowUserToDeleteRows = false;
            this.noteNames.AllowUserToResizeColumns = false;
            this.noteNames.AllowUserToResizeRows = false;
            this.noteNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteNames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.noteNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.noteNames.DefaultCellStyle = dataGridViewCellStyle1;
            this.noteNames.Location = new System.Drawing.Point(544, 129);
            this.noteNames.Name = "noteNames";
            this.noteNames.ReadOnly = true;
            this.noteNames.RowHeadersVisible = false;
            this.noteNames.Size = new System.Drawing.Size(225, 307);
            this.noteNames.TabIndex = 8;
            // 
            // uploadImageButton
            // 
            this.uploadImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uploadImageButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.uploadImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uploadImageButton.Location = new System.Drawing.Point(181, 475);
            this.uploadImageButton.Name = "uploadImageButton";
            this.uploadImageButton.Size = new System.Drawing.Size(110, 69);
            this.uploadImageButton.TabIndex = 9;
            this.uploadImageButton.Text = "Upload Image";
            this.uploadImageButton.UseVisualStyleBackColor = true;
            this.uploadImageButton.Click += new System.EventHandler(this.uploadImageButton_Click);
            // 
            // imageStatusLabel
            // 
            this.imageStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imageStatusLabel.AutoSize = true;
            this.imageStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.imageStatusLabel.Location = new System.Drawing.Point(16, 576);
            this.imageStatusLabel.Name = "imageStatusLabel";
            this.imageStatusLabel.Size = new System.Drawing.Size(146, 25);
            this.imageStatusLabel.TabIndex = 10;
            this.imageStatusLabel.Text = "Image Status:";
            // 
            // labelUploaded
            // 
            this.labelUploaded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUploaded.AutoSize = true;
            this.labelUploaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUploaded.Location = new System.Drawing.Point(177, 553);
            this.labelUploaded.Name = "labelUploaded";
            this.labelUploaded.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelUploaded.Size = new System.Drawing.Size(116, 73);
            this.labelUploaded.TabIndex = 11;
            this.labelUploaded.Text = "No";
            // 
            // buttonView
            // 
            this.buttonView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonView.Location = new System.Drawing.Point(329, 553);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(110, 71);
            this.buttonView.TabIndex = 12;
            this.buttonView.Text = "View Image";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonNew.Location = new System.Drawing.Point(595, 454);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(109, 38);
            this.buttonNew.TabIndex = 13;
            this.buttonNew.Text = "New Note";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonSave.Location = new System.Drawing.Point(595, 498);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(109, 38);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save Note";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonOpen.Location = new System.Drawing.Point(595, 542);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(109, 38);
            this.buttonOpen.TabIndex = 15;
            this.buttonOpen.Text = "Open Note";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDelete.Location = new System.Drawing.Point(595, 586);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 38);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete Note";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonLogOut.Location = new System.Drawing.Point(660, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(109, 38);
            this.buttonLogOut.TabIndex = 17;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.nameofnote, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNoteContent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.notecontents, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNoteName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 397);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // deleteUser
            // 
            this.deleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F);
            this.deleteUser.Location = new System.Drawing.Point(544, 67);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(225, 38);
            this.deleteUser.TabIndex = 19;
            this.deleteUser.Text = "Delete User and All Notes";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // NoteApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 636);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.labelUploaded);
            this.Controls.Add(this.imageStatusLabel);
            this.Controls.Add(this.uploadImageButton);
            this.Controls.Add(this.noteNames);
            this.Controls.Add(this.drawImageButton);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.titleofapp);
            this.MinimumSize = new System.Drawing.Size(800, 675);
            this.Name = "NoteApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.NoteApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noteNames)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameofnote;
        private System.Windows.Forms.Label titleofapp;
        private System.Windows.Forms.Label notecontents;
        private System.Windows.Forms.TextBox textBoxNoteName;
        private System.Windows.Forms.TextBox textBoxNoteContent;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Button drawImageButton;
        private System.Windows.Forms.DataGridView noteNames;
        private System.Windows.Forms.Button uploadImageButton;
        private System.Windows.Forms.Label imageStatusLabel;
        private System.Windows.Forms.Label labelUploaded;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button deleteUser;
    }
}

