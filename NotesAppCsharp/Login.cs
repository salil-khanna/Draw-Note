using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NotesAppCsharp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public Login(string user, string pass)
        {
            InitializeComponent();
            textBoxUsername.Text = user;
            textBoxPassword.Text = pass;
        }

        private void button1_Click(object sender, EventArgs e)
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


            //string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\salil\Desktop\Coding Stuf\Notes-App\NotesAppCsharp\loginInfo.mdf;
            Integrated Security=True;Connect Timeout=30");
            string query = "Select * from [dbo].[Table] Where username = '" + textBoxUsername.Text.Trim() + "' and password = '" + textBoxPassword.Text.Trim() + "'";
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                int id = (int) dtbl.Rows[0][0];
                string name = (string)dtbl.Rows[0][1];
                NoteApp newNoteApp = new NoteApp(id, name);
                sqlcon.Close();
                this.Hide();
                newNoteApp.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!");
            }

        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            CreateUser newUserApp = new CreateUser(textBoxUsername.Text, textBoxPassword.Text, this);
            newUserApp.Show();
        }

        private void forgetPass_Click(object sender, EventArgs e)
        {
            ForgetPassword newPasswordApp = new ForgetPassword(textBoxUsername.Text);
            newPasswordApp.Show();
        }
    }
}
