using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NotesAppCsharp
{
    public partial class DeleteUser : Form
    { 

        NoteApp main;
        public DeleteUser(NoteApp main)
        {
            InitializeComponent();
            this.main = main;
            comboBoxSecret.Items.Add("Favorite color?");
            comboBoxSecret.Items.Add("Favorite food?");
            comboBoxSecret.Items.Add("Favorite holiday?");
            comboBoxSecret.Items.Add("Favorite candy?");
        }

        private void noButton_Click(object sender, EventArgs e)
        {   
            this.Close();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUsername.Text))
            {
                MessageBox.Show("There is no username typed in!");
                return;
            }


            if (String.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("There is no password typed in!");
                return;
            }

            if (comboBoxSecret.SelectedIndex == -1)
            {
                MessageBox.Show("A secret question was not selected!");
                return;
            }

            if (String.IsNullOrEmpty(textBoxSecretAnswer.Text))
            {
                MessageBox.Show("There is no secret answer typed in!");
                return;
            }

            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string answer = textBoxSecretAnswer.Text.Trim();
            string question = comboBoxSecret.Text.Trim();
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\salil\Desktop\Coding Stuf\Notes-App\NotesAppCsharp\loginInfo.mdf;
            Integrated Security=True;Connect Timeout=30");
            string query1 = "Select * from [dbo].[Table] Where username = '" + username + "' and password = '" + password + 
                "' and secret = '" + answer + "' and secretQuestion = '" + question + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query1, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count != 1)
            {
                MessageBox.Show("Not the correction information! Closing window...");
                sqlcon.Close();
                this.Close();
                return;
            }
            int userIndex = (int)dtbl.Rows[0][0];
            
            
            string query;
            SqlCommand command;    
            sqlcon.Open();
            query = "DELETE FROM [dbo].[Table1]  WHERE userId = '" + userIndex + "'";
            command = new SqlCommand(query, sqlcon);
            command.ExecuteNonQuery();
            sqlcon.Close();

            sqlcon.Open();
            query = "DELETE FROM [dbo].[Table] WHERE Id = '" + userIndex + "'";
            command = new SqlCommand(query, sqlcon);
            command.ExecuteNonQuery();
            sqlcon.Close();

            main.Close();
            Login newLoginApp = new Login();
            newLoginApp.Show();
            this.Hide();
        }


        
    }
}
