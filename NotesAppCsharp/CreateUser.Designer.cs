
namespace NotesAppCsharp
{
    partial class CreateUser
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.greeting = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.createAccount = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.answerToSecret = new System.Windows.Forms.Label();
            this.textBoxSecretAnswer = new System.Windows.Forms.TextBox();
            this.comboBoxSecret = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(194, 131);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(292, 39);
            this.textBoxPassword.TabIndex = 15;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(194, 79);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(292, 39);
            this.textBoxUsername.TabIndex = 14;
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.Location = new System.Drawing.Point(27, 25);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(532, 37);
            this.greeting.TabIndex = 13;
            this.greeting.Text = "Create an Account for Draw Note!";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(322, 317);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 70);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // createAccount
            // 
            this.createAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccount.Location = new System.Drawing.Point(130, 317);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(150, 70);
            this.createAccount.TabIndex = 11;
            this.createAccount.Text = "Create Account";
            this.createAccount.UseVisualStyleBackColor = true;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(21, 131);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(167, 37);
            this.password.TabIndex = 10;
            this.password.Text = "Password:";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(21, 79);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(173, 37);
            this.userName.TabIndex = 9;
            this.userName.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Secret Question:";
            // 
            // answerToSecret
            // 
            this.answerToSecret.AutoSize = true;
            this.answerToSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerToSecret.Location = new System.Drawing.Point(21, 242);
            this.answerToSecret.Name = "answerToSecret";
            this.answerToSecret.Size = new System.Drawing.Size(133, 37);
            this.answerToSecret.TabIndex = 17;
            this.answerToSecret.Text = "Answer:";
            // 
            // textBoxSecretAnswer
            // 
            this.textBoxSecretAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSecretAnswer.Location = new System.Drawing.Point(160, 245);
            this.textBoxSecretAnswer.Multiline = true;
            this.textBoxSecretAnswer.Name = "textBoxSecretAnswer";
            this.textBoxSecretAnswer.Size = new System.Drawing.Size(326, 39);
            this.textBoxSecretAnswer.TabIndex = 18;
            // 
            // comboBoxSecret
            // 
            this.comboBoxSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSecret.FormattingEnabled = true;
            this.comboBoxSecret.Location = new System.Drawing.Point(282, 187);
            this.comboBoxSecret.Name = "comboBoxSecret";
            this.comboBoxSecret.Size = new System.Drawing.Size(204, 37);
            this.comboBoxSecret.TabIndex = 19;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.comboBoxSecret);
            this.Controls.Add(this.textBoxSecretAnswer);
            this.Controls.Add(this.answerToSecret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "CreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button createAccount;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label answerToSecret;
        private System.Windows.Forms.TextBox textBoxSecretAnswer;
        private System.Windows.Forms.ComboBox comboBoxSecret;
    }
}