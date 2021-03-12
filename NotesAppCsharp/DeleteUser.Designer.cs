
namespace NotesAppCsharp
{
    partial class DeleteUser
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
            this.comboBoxSecret = new System.Windows.Forms.ComboBox();
            this.textBoxSecretAnswer = new System.Windows.Forms.TextBox();
            this.answerToSecret = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.greeting = new System.Windows.Forms.Label();
            this.noButton = new System.Windows.Forms.Button();
            this.yes = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.greeting2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSecret
            // 
            this.comboBoxSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSecret.FormattingEnabled = true;
            this.comboBoxSecret.Location = new System.Drawing.Point(284, 186);
            this.comboBoxSecret.Name = "comboBoxSecret";
            this.comboBoxSecret.Size = new System.Drawing.Size(204, 37);
            this.comboBoxSecret.TabIndex = 30;
            // 
            // textBoxSecretAnswer
            // 
            this.textBoxSecretAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSecretAnswer.Location = new System.Drawing.Point(162, 244);
            this.textBoxSecretAnswer.Multiline = true;
            this.textBoxSecretAnswer.Name = "textBoxSecretAnswer";
            this.textBoxSecretAnswer.Size = new System.Drawing.Size(326, 39);
            this.textBoxSecretAnswer.TabIndex = 29;
            // 
            // answerToSecret
            // 
            this.answerToSecret.AutoSize = true;
            this.answerToSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerToSecret.Location = new System.Drawing.Point(23, 241);
            this.answerToSecret.Name = "answerToSecret";
            this.answerToSecret.Size = new System.Drawing.Size(133, 37);
            this.answerToSecret.TabIndex = 28;
            this.answerToSecret.Text = "Answer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "Secret Question:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(196, 130);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(292, 39);
            this.textBoxPassword.TabIndex = 26;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(196, 78);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(292, 39);
            this.textBoxUsername.TabIndex = 25;
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.greeting.Location = new System.Drawing.Point(25, 9);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(545, 29);
            this.greeting.TabIndex = 24;
            this.greeting.Text = "Are you sure you want to delete your account?";
            this.greeting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // noButton
            // 
            this.noButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.noButton.Location = new System.Drawing.Point(324, 316);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(150, 70);
            this.noButton.TabIndex = 23;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // yes
            // 
            this.yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.yes.Location = new System.Drawing.Point(132, 316);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(150, 70);
            this.yes.TabIndex = 22;
            this.yes.Text = "Yes";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(23, 130);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(167, 37);
            this.password.TabIndex = 21;
            this.password.Text = "Password:";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(23, 78);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(173, 37);
            this.userName.TabIndex = 20;
            this.userName.Text = "Username:";
            // 
            // greeting2
            // 
            this.greeting2.AutoSize = true;
            this.greeting2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.greeting2.Location = new System.Drawing.Point(158, 38);
            this.greeting2.Name = "greeting2";
            this.greeting2.Size = new System.Drawing.Size(284, 24);
            this.greeting2.TabIndex = 31;
            this.greeting2.Text = "Enter all your info to continue";
            this.greeting2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.greeting2);
            this.Controls.Add(this.comboBoxSecret);
            this.Controls.Add(this.textBoxSecretAnswer);
            this.Controls.Add(this.answerToSecret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "DeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSecret;
        private System.Windows.Forms.TextBox textBoxSecretAnswer;
        private System.Windows.Forms.Label answerToSecret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label greeting2;
    }
}