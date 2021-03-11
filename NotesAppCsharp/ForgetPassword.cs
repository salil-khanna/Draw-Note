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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
            comboBoxSecret.Items.Add("Favorite color?");
            comboBoxSecret.Items.Add("Favorite food?");
            comboBoxSecret.Items.Add("Favorite holiday?");
            comboBoxSecret.Items.Add("Favorite candy?");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getPassword_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUsername.Text))
            {
                MessageBox.Show("There is no username typed in!");
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
            string answer = textBoxSecretAnswer.Text.Trim();
            string question = comboBoxSecret.Text.Trim();
            


            SqlConnection sqlcon1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\salil\Desktop\Coding Stuf\Notes-App\NotesAppCsharp\loginInfo.mdf;
            Integrated Security=True;Connect Timeout=30");
            string query1 = "Select * from [dbo].[Table] Where username = '" + username + "' and secret = '" + answer + "' and secretQuestion = '" + question + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query1, sqlcon1);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                textBoxPassword.Text = (string)dtbl.Rows[0][2];

            }
            else
            {
                MessageBox.Show("Username, Secret Question, or Answer is incorrect!");
            }



        }
    }
}
