using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NotesAppCsharp
{
    public partial class NoteApp : Form
    {
        string name;
        DataTable table;
        int userId;
        //bool imageUpload;
        bool openedNote = false;
        int openedIndex;
        int noteIndex;

        public NoteApp(int userId, string name)
        {
            InitializeComponent();
            this.userId = userId;
            this.name = name;
            
        }


        private void NoteApp_Load(object sender, EventArgs e)
        {
            //string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\salil\Desktop\Coding Stuf\Notes-App\NotesAppCsharp\loginInfo.mdf;
            Integrated Security=True;Connect Timeout=30");
            string query = "Select * from [dbo].[Table1] Where userId = '" + this.userId + "' order by noteId desc";
            sqlcon.Open();


            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            table = new DataTable();
            sda.Fill(table);
            //if size of rows is 0, display welcome to, else welcome back to
            if (table.Rows.Count == 0)
            {
                titleofapp.Text = "Welcome to Draw Note " + this.name + "!";
            } else
            {
                titleofapp.Text = "Welcome back to Draw Note " + this.name + "!";
            }
            
            noteNames.DataSource = table;
            noteNames.Columns["userId"].Visible = false;
            noteNames.Columns["NoteContent"].Visible = false;
            noteNames.Columns["Image"].Visible = false;
            noteNames.Columns["noteId"].Visible = false;
            noteNames.Columns["NoteName"].Width = 220;
            sqlcon.Close();
        }


        private void buttonNew_Click(object sender, EventArgs e)
        {

            this.openedNote = false;
            textBoxNoteName.Clear();
            textBoxNoteContent.Clear();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            string noteContent = textBoxNoteContent.Text;
            
            if (textBoxNoteName.Text == "" && noteContent == "")
            {
                MessageBox.Show("You can not save a blank note!");
                return;
            }

            
            string noteName;
            if (textBoxNoteName.Text == "")
            {
                int lenContent = noteContent.Length;
                if (lenContent < 10)
                {
                    noteName = textBoxNoteContent.Text.Substring(0, lenContent);
                } else if (lenContent > 50) {
                    noteName = textBoxNoteContent.Text.Substring(0, 50);
                } else
                {
                    noteName = textBoxNoteContent.Text.Substring(0, 9);
                }
            } else if (textBoxNoteName.TextLength > 50)
            {
                noteName = textBoxNoteName.Text.Substring(0, 50);
            } else
            {
                noteName = textBoxNoteName.Text;
            }


            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\salil\Desktop\Coding Stuf\Notes-App\NotesAppCsharp\loginInfo.mdf;
            Integrated Security=True;Connect Timeout=30");
            string query;
            
            if (this.openedNote == true)
            {
                table.Rows.RemoveAt(openedIndex);

                using (sqlcon)
                {
                    sqlcon.Open();
                    query = "UPDATE [dbo].[Table1] SET NoteName = '" + noteName + "', NoteContent = '" + noteContent + "' WHERE noteId = '" + noteIndex + "'";
                    using (SqlCommand command = new SqlCommand(query, sqlcon))
                    {
                        
                        command.CommandType = CommandType.Text; 
                        command.ExecuteNonQuery();
                        
                        this.openedNote = false;
                        sqlcon.Close();
                    }
                    
                }

            }
            else
            {
                using (sqlcon)
                {
                    sqlcon.Open();
                    query = "INSERT INTO [dbo].[Table1] (userId, NoteName, NoteContent) VALUES (@userId, @noteName, @content)";

                    using (SqlCommand command = new SqlCommand(query, sqlcon))
                    {
                        
                        command.Parameters.AddWithValue("@userId", this.userId);
                        command.Parameters.AddWithValue("@noteName", noteName);
                        command.Parameters.AddWithValue("@content", noteContent);
                        
                        command.ExecuteNonQuery();
                        
                        
                    }
                }
                
            }
            sqlcon.Close();


            SqlConnection sqlcon1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\salil\Desktop\Coding Stuf\Notes-App\NotesAppCsharp\loginInfo.mdf;
            Integrated Security=True;Connect Timeout=30");
            sqlcon1.Open();
            string query1 = "Select noteId from [dbo].[Table1] Where NoteName = '" + noteName + "' AND NoteContent = '" + noteContent + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query1, sqlcon1);
            DataTable temp = new DataTable();
            sda.Fill(temp);
            sqlcon1.Close();

            int lastRow = temp.Rows.Count;
            int noteId = (int) temp.Rows[lastRow - 1][0];



            table.Rows.Add(this.userId, noteName, noteContent, null, noteId);


            textBoxNoteName.Clear();
            textBoxNoteContent.Clear();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            int index = noteNames.CurrentCell.RowIndex;
            if (index > -1)
            {
                string noteName = table.Rows[index].ItemArray[1].ToString();
                string noteContent = table.Rows[index].ItemArray[2].ToString();

                textBoxNoteName.Text = noteName;
                textBoxNoteContent.Text = noteContent;
                this.openedNote = true;
                this.openedIndex = index;
                
                this.noteIndex = (int) table.Rows[index][4];
                System.Diagnostics.Debug.WriteLine(noteIndex);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\salil\Desktop\Coding Stuf\Notes-App\NotesAppCsharp\loginInfo.mdf;
            Integrated Security=True;Connect Timeout=30");
            string query;
            SqlCommand command;
            if (this.openedNote == true)
            {
                table.Rows.RemoveAt(openedIndex);

                sqlcon.Open();
                query = "DELETE FROM [dbo].[Table1]  WHERE noteId = '" + noteIndex + "'";
                command = new SqlCommand(query, sqlcon);
                command.ExecuteNonQuery();
                sqlcon.Close();
                this.openedNote = false;
                textBoxNoteName.Clear();
                textBoxNoteContent.Clear();
            }
        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            string fileName;
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|*.png|PNG", ValidateNames = true, Multiselect = false})
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    //lblFileName.Text = fileName;
                    //pictureBox1.Image = Image.FromFile(fileName);
                }
            }
        }

        private void drawImageButton_Click(object sender, EventArgs e)
        {

        }

        private void buttonViewInPaint_Click(object sender, EventArgs e)
        {

            string filePath = @"""C:\Users\salil\Desktop\Coding Stuf\Notes App\NotesAppCsharp\TestPhotos\Hawaii.jpg"""; //temp path, later to sql database

            System.Diagnostics.ProcessStartInfo procInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "mspaint.exe",
                Arguments = filePath //Full Path to an image
            };

            System.Diagnostics.Process.Start(procInfo);
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Login newLoginApp = new Login();
            this.Hide();
            newLoginApp.Show();
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {

            DeleteUser newDeleteApp = new DeleteUser(this);
            newDeleteApp.Show();

        }
    }
}
