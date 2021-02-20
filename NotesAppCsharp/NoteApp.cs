using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesAppCsharp
{
    public partial class NoteApp : Form
    {
        DataTable table;
        bool imageUpload;

        public NoteApp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }


        private void NoteApp_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Note Name", typeof(String));
            table.Columns.Add("Note Content", typeof(String));


            noteNames.DataSource = table;
        }


        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxNoteName.Clear();
            textBoxNoteContent.Clear();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string noteName = textBoxNoteName.Text;
            string noteContent = textBoxNoteContent.Text;
            table.Rows.Add(noteName, noteContent);

            textBoxNoteName.Clear();
            textBoxNoteContent.Clear();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            int index = noteNames.CurrentCell.RowIndex;
            if (index > -1)
            {
                string noteName = table.Rows[index].ItemArray[0].ToString();
                string noteContent = table.Rows[index].ItemArray[1].ToString();

                textBoxNoteName.Text = noteName;
                textBoxNoteContent.Text = noteContent;

            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = noteNames.CurrentCell.RowIndex;
            if (index > -1)
            {
                table.Rows[index].Delete();
                //table.Rows.Remove(table.Rows[index]);


            }
        }

        private void textBoxNoteContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void noteNames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {

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

        }
    }
}
