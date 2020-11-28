using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fractus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Size ScreenSize = Screen.PrimaryScreen.Bounds.Size;
            this.MaximumSize = ScreenSize;
            ScreenSize.Width /= 2;
            ScreenSize.Height /= 2;
            ScreenSize.Height += 200;
            this.MinimumSize = ScreenSize;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                endColor.BackColor = colorDialog1.Color;
                endColor.ForeColor = Color.FromArgb(255 - endColor.BackColor.R, 255 - endColor.BackColor.G, 255 - endColor.BackColor.B);
                DrawFractus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                startColor.BackColor = colorDialog1.Color;
                startColor.ForeColor = Color.FromArgb(255 - startColor.BackColor.R, 255 - startColor.BackColor.G, 255 - startColor.BackColor.B);
                DrawFractus();
            }
        }

        private void PythagorasTree_CheckedChanged(object sender, EventArgs e)
        {
            //pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            DrawPythagorasTree();
            if (PythagorasTree.Checked)
            {
                label2.Visible = true;
                trackBar1.Visible = true;
                label3.Visible = true;
            }
            else
            {
                trackBar1.Visible = false;
                label3.Visible = false;
                label2.Visible = false;

            }
            label3.Refresh();
            label2.Refresh();
            trackBar1.Refresh();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            label2.Text = trackBar1.Value.ToString() + "°";
            label2.Refresh();
            DrawPythagorasTree();

        }

        private void DrawFractus()
        {
            FractusRecursion.GenerateColorList(endColor.BackColor, startColor.BackColor, (int)StepOfRecursion.Value);
            if (PythagorasTree.Checked)
            {
                DrawPythagorasTree();
            }
        }
        public void DrawPythagorasTree()
        {
            int zoom = trackBar2.Value;
            Bitmap bm = new Bitmap(panel1.Size.Width * zoom, panel1.Size.Height * zoom);
            Point Center = new Point(panel1.Size.Width / 2, panel1.Size.Height / 2);
            FractusRecursion.PythagorasTreeRecursion(Center, (int)StepOfRecursion.Value, bm, 0, 100 * zoom, trackBar1.Value);
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = bm;
            pictureBox1.Size = bm.Size;
        }

        private void StepOfRecursion_ValueChanged(object sender, EventArgs e)
        {
            DrawFractus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label4.Text = "Zoom" + "X" + trackBar2.Value.ToString();
            label4.Refresh();
            DrawFractus();
        }
    }
}
