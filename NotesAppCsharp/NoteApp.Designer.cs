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
            this.buttonViewInPaint = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noteNames)).BeginInit();
            this.SuspendLayout();
            // 
            // nameofnote
            // 
            this.nameofnote.AutoSize = true;
            this.nameofnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.nameofnote.Location = new System.Drawing.Point(12, 85);
            this.nameofnote.Name = "nameofnote";
            this.nameofnote.Size = new System.Drawing.Size(150, 25);
            this.nameofnote.TabIndex = 0;
            this.nameofnote.Text = "Name of Note:";
            this.nameofnote.Click += new System.EventHandler(this.label1_Click);
            // 
            // titleofapp
            // 
            this.titleofapp.AutoSize = true;
            this.titleofapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.titleofapp.Location = new System.Drawing.Point(157, 9);
            this.titleofapp.Name = "titleofapp";
            this.titleofapp.Size = new System.Drawing.Size(339, 36);
            this.titleofapp.TabIndex = 1;
            this.titleofapp.Text = "Welcome to DrawNote!";
            this.titleofapp.Click += new System.EventHandler(this.label2_Click);
            // 
            // notecontents
            // 
            this.notecontents.AutoSize = true;
            this.notecontents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.notecontents.Location = new System.Drawing.Point(5, 140);
            this.notecontents.Name = "notecontents";
            this.notecontents.Size = new System.Drawing.Size(157, 25);
            this.notecontents.TabIndex = 2;
            this.notecontents.Text = "Note Contents:";
            // 
            // textBoxNoteName
            // 
            this.textBoxNoteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxNoteName.Location = new System.Drawing.Point(168, 85);
            this.textBoxNoteName.Multiline = true;
            this.textBoxNoteName.Name = "textBoxNoteName";
            this.textBoxNoteName.Size = new System.Drawing.Size(231, 34);
            this.textBoxNoteName.TabIndex = 3;
            this.textBoxNoteName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNoteContent
            // 
            this.textBoxNoteContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxNoteContent.Location = new System.Drawing.Point(168, 140);
            this.textBoxNoteContent.Multiline = true;
            this.textBoxNoteContent.Name = "textBoxNoteContent";
            this.textBoxNoteContent.Size = new System.Drawing.Size(231, 180);
            this.textBoxNoteContent.TabIndex = 4;
            this.textBoxNoteContent.TextChanged += new System.EventHandler(this.textBoxNoteContent_TextChanged);
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.imageLabel.Location = new System.Drawing.Point(27, 339);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(135, 25);
            this.imageLabel.TabIndex = 5;
            this.imageLabel.Text = "Add Image?:";
            this.imageLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // drawImageButton
            // 
            this.drawImageButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.drawImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.drawImageButton.Location = new System.Drawing.Point(299, 339);
            this.drawImageButton.Name = "drawImageButton";
            this.drawImageButton.Size = new System.Drawing.Size(100, 68);
            this.drawImageButton.TabIndex = 7;
            this.drawImageButton.Text = "Draw Image";
            this.drawImageButton.UseVisualStyleBackColor = true;
            this.drawImageButton.Click += new System.EventHandler(this.drawImageButton_Click);
            // 
            // noteNames
            // 
            this.noteNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.noteNames.DefaultCellStyle = dataGridViewCellStyle1;
            this.noteNames.Location = new System.Drawing.Point(469, 67);
            this.noteNames.Name = "noteNames";
            this.noteNames.Size = new System.Drawing.Size(225, 235);
            this.noteNames.TabIndex = 8;
            this.noteNames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.noteNames_CellContentClick);
            // 
            // uploadImageButton
            // 
            this.uploadImageButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.uploadImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uploadImageButton.Location = new System.Drawing.Point(168, 339);
            this.uploadImageButton.Name = "uploadImageButton";
            this.uploadImageButton.Size = new System.Drawing.Size(104, 68);
            this.uploadImageButton.TabIndex = 9;
            this.uploadImageButton.Text = "Upload Image";
            this.uploadImageButton.UseVisualStyleBackColor = true;
            this.uploadImageButton.Click += new System.EventHandler(this.uploadImageButton_Click);
            // 
            // imageStatusLabel
            // 
            this.imageStatusLabel.AutoSize = true;
            this.imageStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.imageStatusLabel.Location = new System.Drawing.Point(16, 444);
            this.imageStatusLabel.Name = "imageStatusLabel";
            this.imageStatusLabel.Size = new System.Drawing.Size(146, 25);
            this.imageStatusLabel.TabIndex = 10;
            this.imageStatusLabel.Text = "Image Status:";
            // 
            // labelUploaded
            // 
            this.labelUploaded.AutoSize = true;
            this.labelUploaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelUploaded.Location = new System.Drawing.Point(168, 444);
            this.labelUploaded.Name = "labelUploaded";
            this.labelUploaded.Size = new System.Drawing.Size(116, 25);
            this.labelUploaded.TabIndex = 11;
            this.labelUploaded.Text = "@Uploaded";
            this.labelUploaded.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // buttonViewInPaint
            // 
            this.buttonViewInPaint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonViewInPaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonViewInPaint.Location = new System.Drawing.Point(299, 428);
            this.buttonViewInPaint.Name = "buttonViewInPaint";
            this.buttonViewInPaint.Size = new System.Drawing.Size(110, 71);
            this.buttonViewInPaint.TabIndex = 12;
            this.buttonViewInPaint.Text = "View Image in Paint";
            this.buttonViewInPaint.UseVisualStyleBackColor = true;
            this.buttonViewInPaint.Click += new System.EventHandler(this.buttonViewInPaint_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonNew.Location = new System.Drawing.Point(520, 308);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(109, 38);
            this.buttonNew.TabIndex = 13;
            this.buttonNew.Text = "New Note";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonSave.Location = new System.Drawing.Point(520, 354);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(109, 38);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save Note";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonOpen.Location = new System.Drawing.Point(520, 398);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(109, 38);
            this.buttonOpen.TabIndex = 15;
            this.buttonOpen.Text = "Open Note";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDelete.Location = new System.Drawing.Point(520, 445);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 38);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete Note";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonLogOut.Location = new System.Drawing.Point(585, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(109, 38);
            this.buttonLogOut.TabIndex = 17;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // NoteApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 511);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonViewInPaint);
            this.Controls.Add(this.labelUploaded);
            this.Controls.Add(this.imageStatusLabel);
            this.Controls.Add(this.uploadImageButton);
            this.Controls.Add(this.noteNames);
            this.Controls.Add(this.drawImageButton);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.textBoxNoteContent);
            this.Controls.Add(this.textBoxNoteName);
            this.Controls.Add(this.notecontents);
            this.Controls.Add(this.titleofapp);
            this.Controls.Add(this.nameofnote);
            this.Name = "NoteApp";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.NoteApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noteNames)).EndInit();
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
        private System.Windows.Forms.Button buttonViewInPaint;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonLogOut;
    }
}

