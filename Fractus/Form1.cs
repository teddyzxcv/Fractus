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
            ScreenSize.Height += 400;
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
                trackBar3.Visible = true;
                trackBar4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;

            }
            else
            {
                trackBar1.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                trackBar3.Visible = false;
                trackBar4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;

            }
            label3.Refresh();
            label2.Refresh();
            trackBar1.Refresh();
            Refresh();

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
            else
            if (KochSnowflake.Checked)
            {
                DrawKochSnowflake();
            }
            else
            if (SierpinskiCarpet.Checked)
            {

            }
            else
            if (SierpinskiTriangle.Checked)
            {

            }
            else
            if (CantorSet.Checked)
            {

            }

        }
        public void DrawPythagorasTree()
        {
            double zoom = trackBar2.Value;
            FractusRecursion.PythagorasAngle1 = trackBar1.Value;
            FractusRecursion.PythagorasAngle2 = trackBar3.Value;
            FractusRecursion.FractionBetweenRecursion = trackBar4.Value;
            Bitmap bm = new Bitmap(panel1.Size.Width * (int)zoom, panel1.Size.Height * (int)zoom);
            Point Center = new Point(bm.Size.Width / 2, 100);
            FractusRecursion.PythagorasTreeRecursion(Center, (int)StepOfRecursion.Value, bm, 0, 100 * zoom);
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = bm;
            pictureBox1.Size = bm.Size;
        }
        public void DrawKochSnowflake()
        {
            double zoom = trackBar2.Value;

            Bitmap bm = new Bitmap(panel1.Size.Width * (int)zoom, panel1.Size.Height * (int)zoom);
            Point Center = new Point(bm.Size.Width / 2 + 200, bm.Size.Height / 2);
            FractusRecursion.KochSnowflakwRecursion(startColor.BackColor, (int)StepOfRecursion.Value, Center, 100, 90, bm);
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

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label7.Text = trackBar3.Value.ToString() + "°";
            label7.Refresh();
            DrawFractus();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label6.Text = "1/" + ((double)trackBar4.Value / 100).ToString();
            label6.Refresh();
            DrawFractus();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            DrawFractus();
        }

        private void KochSnowflake_CheckedChanged(object sender, EventArgs e)
        {
            DrawFractus();
        }
    }
}
