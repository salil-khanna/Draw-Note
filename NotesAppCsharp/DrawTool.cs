using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesAppCsharp
{

    public class TPanel : Panel
    {
        public TPanel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
    }



    public partial class DrawTool : Form
    {
        Point current = new Point();
        Point old = new Point();
        Graphics drawing;
        Pen p = new Pen(Color.Black, 10);
        Bitmap surface;
        Graphics graph;
        string save = "Picture";
        int i = 1;
        NoteApp noteApp;

        public DrawTool(NoteApp note)
        {
            InitializeComponent();
            drawing = panel1.CreateGraphics();
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, 
                System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            radioButton3.Checked = true;
            surface = new Bitmap(panel1.Width, panel1.Height);
            graph = Graphics.FromImage(surface);
            panel1.BackgroundImage = surface;
            panel1.BackgroundImageLayout = ImageLayout.None;
            this.noteApp = note;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
            if (radioButton1.Checked)
            {
                p.Width = 2;
            } else if (radioButton2.Checked)
            {
                p.Width = 6;
            }
            else if (radioButton3.Checked)
            {
                p.Width = 9;
            }
            else if (radioButton4.Checked)
            {
                p.Width = 15;
            }

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                

                if (radioButton5.Checked)
                {
                    current = e.Location;
                    Pen temp = new Pen(Color.FromArgb(240, 240, 240), 15);
                    temp.SetLineCap(System.Drawing.Drawing2D.LineCap.Round,
                        System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

                    graph.DrawLine(temp, old, current);
                    old = current;
                    panel1.Invalidate();
                } else
                {
                    current = e.Location;
                    graph.DrawLine(p, old, current);
                    old = current;
                    panel1.Invalidate();
                }

            }
        }

        private void colors_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                p.Color = cd.Color;
            }
        }

        private void downloadDrawing_Click(object sender, EventArgs e)
        {
            Image temp = (Image)surface;
            temp.Save(save, ImageFormat.Png);
            MessageBox.Show("The Drawing has been saved to this folders /bin/debug/ !");
            this.Close();
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            Image temp = (Image)surface;
            byte[] tempByte = ImageToByte(temp);
            noteApp.setImage(tempByte);

            MessageBox.Show("The Drawing has been saved to the note!");
            this.Close();
        }

        private static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}
