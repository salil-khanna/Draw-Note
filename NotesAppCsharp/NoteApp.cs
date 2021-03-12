using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

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
        Image curImage = null;

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
            labelUploaded.Text = "No";
            noteNames.DataSource = table;
            noteNames.Columns["userId"].Visible = false;
            noteNames.Columns["NoteContent"].Visible = false;
            noteNames.Columns["ImageName"].Visible = false;
            noteNames.Columns["noteId"].Visible = false;
            noteNames.Columns["NoteName"].Width = 220;
            sqlcon.Close();
        }


        private void buttonNew_Click(object sender, EventArgs e)
        {

            this.openedNote = false;
            this.curImage = null;
            labelUploaded.Text = "No";
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


            byte[] convert = null;
            if (curImage != null)
            {
                convert = ConvertImageToBinary(curImage);
            }

            if (this.openedNote == true)
            {
                table.Rows.RemoveAt(openedIndex);

                using (sqlcon)
                {
                    sqlcon.Open();

                    if (curImage != null)
                    {
                        query = "UPDATE [dbo].[Table1] SET NoteName = '" + noteName + "', NoteContent = '" + noteContent +
                                                "', ImageName = CONVERT(varbinary, @bytes) WHERE noteId = '" + noteIndex + "'";
                    } else
                    {
                        query = "UPDATE [dbo].[Table1] SET NoteName = '" + noteName + "', NoteContent = '" + noteContent +
                                                "' WHERE noteId = '" + noteIndex + "'";
                    }
                    
                    using (SqlCommand command = new SqlCommand(query, sqlcon))
                    {
                        if (curImage != null)
                        {
                            command.Parameters.Add("@bytes", SqlDbType.VarBinary).Value = convert;
                        }
                        
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
                    if (curImage == null)
                    {
                        query = "INSERT INTO [dbo].[Table1] (userId, NoteName, NoteContent) VALUES (@userId, @noteName, @content)";
                    } else
                    {
                        query = "INSERT INTO [dbo].[Table1] (userId, NoteName, NoteContent, ImageName) VALUES (@userId, @noteName, @content, @image)";
                    }
                    

                    using (SqlCommand command = new SqlCommand(query, sqlcon))
                    {
                        
                        command.Parameters.AddWithValue("@userId", this.userId);
                        command.Parameters.AddWithValue("@noteName", noteName);
                        command.Parameters.AddWithValue("@content", noteContent);
                        if (curImage != null)
                        {
                            command.Parameters.AddWithValue("@image", convert);
                        }

                        
                        command.ExecuteNonQuery();
                        sqlcon.Close();


                    }
                }
                
            }
            


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



            table.Rows.Add(this.userId, noteName, noteContent, convert, noteId);

            this.curImage = null;
            labelUploaded.Text = "No";
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

                Image noteImage;
                if (table.Rows[index][3] == DBNull.Value)
                {
                    labelUploaded.Text = "No";
                    noteImage = null;
                }
                else
                {

                    labelUploaded.Text = "Yes";
                    noteImage = ConvertBinaryToImage((byte []) table.Rows[index][3]);
                    
                }


                textBoxNoteName.Text = noteName;
                textBoxNoteContent.Text = noteContent;
                this.openedNote = true;
                this.openedIndex = index;
                
                this.noteIndex = (int) table.Rows[index][4];
                this.curImage = noteImage;
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\salil\Desktop\Coding Stuf\Notes-App\NotesAppCsharp\loginInfo.mdf;
            Integrated Security=True;Connect Timeout=30");
            string query;
            SqlCommand command;
            //if ()

            int index;
            try
            {
                index = (int) noteNames.CurrentCell.RowIndex;
            } catch
            {
                MessageBox.Show("You can not delete a blank note!");
                return;
            }
            
            if (this.openedNote == true || index > -1)
            {
                
                if (openedNote)
                {
                    table.Rows.RemoveAt(openedIndex);
                    query = "DELETE FROM [dbo].[Table1]  WHERE noteId = '" + noteIndex + "'";
                } else
                {
                    int noteVal = (int)table.Rows[index][4];
                    table.Rows.RemoveAt(index);
                    query = "DELETE FROM [dbo].[Table1]  WHERE noteId = '" + noteVal + "'";
                }
                

                sqlcon.Open();
                
                command = new SqlCommand(query, sqlcon);
                command.ExecuteNonQuery();
                sqlcon.Close();
                this.openedNote = false;
                labelUploaded.Text = "No";
                textBoxNoteName.Clear();
                textBoxNoteContent.Clear();
                this.curImage = null;
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
                    Image image = Image.FromFile(fileName);
                    curImage = image;
                    ImageViewer newViewer = new ImageViewer(image);
                    newViewer.Show();

                }
                labelUploaded.Text = "Yes";
            }
        }

        public void setImage(byte[] set)
        {
            labelUploaded.Text = "Yes";
            Image temp = ConvertBinaryToImage(set);
            curImage = temp;
            
        }

        private void drawImageButton_Click(object sender, EventArgs e)
        {
            DrawTool drawTool = new DrawTool(this);
            drawTool.Show();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            if (curImage == null)
            {
                MessageBox.Show("There is no image to view!");
                return;
            }
            ImageViewer newViewer = new ImageViewer(curImage);
            newViewer.Show();

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

        byte [] ConvertImageToBinary(Image img)
        {
            using (MemoryStream m = new MemoryStream())
            {
                img.Save(m, img.RawFormat);
                byte[] data = m.ToArray();
                Convert.ToBase64String(data);
                            
                
                return data;
            }

           
        }

        Image ConvertBinaryToImage(byte [] data)
        {
            string base64string = Convert.ToBase64String(data);

            Image convert = null; 
            try
            {
                convert = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64string)));
            } catch
            {
                MessageBox.Show("Image File was corrupted...");
                labelUploaded.Text = "Yes";
                return convert;
            }
            
            return convert;
        }

    }
}
