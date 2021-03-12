using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NotesAppCsharp
{
    public partial class CreateUser : Form
    {
        Login form;
        public CreateUser(string user, string password, Login form)
        {
            InitializeComponent();

            comboBoxSecret.Items.Add("Favorite color?");
            comboBoxSecret.Items.Add("Favorite food?");
            comboBoxSecret.Items.Add("Favorite holiday?");
            comboBoxSecret.Items.Add("Favorite candy?");
            textBoxUsername.Text = user;
            textBoxPassword.Text = password;
            this.form = form;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createAccount_Click(object sender, EventArgs e)
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
            
            if (username.Length > 50 || password.Length > 50 || answer.Length > 50)
            {
                MessageBox.Show("Length of inputted values must be less than 50 characters!");
                return;
            }


            SqlConnection sqlcon1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\salil\Desktop\Coding Stuf\Notes-App\NotesAppCsharp\loginInfo.mdf;
            Integrated Security=True;Connect Timeout=30");
            string query1 = "Select * from [dbo].[Table] Where username = '" + username + "' and password = '" + password + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query1, sqlcon1);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                MessageBox.Show("This user and password combination already exists!");
                return;
            }


            //string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\salil\Desktop\Coding Stuf\Notes-App\NotesAppCsharp\loginInfo.mdf;
            Integrated Security=True;Connect Timeout=30"))
            {
                string query = "INSERT INTO [dbo].[Table] (username, password, secret, secretQuestion) VALUES (@username, @password, @secret, @question)";

                using(SqlCommand command = new SqlCommand(query, sqlcon))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@secret", answer);
                    command.Parameters.AddWithValue("@question", question);

                    sqlcon.Open();
                    command.ExecuteNonQuery();



                }
            }

            Login newLoginApp = new Login(username, password);
            newLoginApp.Show();
            form.Hide();
            this.Close();
        }
    }

}
