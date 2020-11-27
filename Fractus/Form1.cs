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
            ScreenSize.Height += 50;
            this.MinimumSize = ScreenSize;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                endColor.BackColor = colorDialog1.Color;
                endColor.ForeColor = Color.FromArgb(255 - endColor.BackColor.R, 255 - endColor.BackColor.G, 255 - endColor.BackColor.B);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                startColor.BackColor = colorDialog1.Color;
                startColor.ForeColor = Color.FromArgb(255 - startColor.BackColor.R, 255 - startColor.BackColor.G, 255 - startColor.BackColor.B);


            }
        }

        private void PythagorasTree_CheckedChanged(object sender, EventArgs e)
        {
            //pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            Bitmap bm = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            Point Center = new Point(pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2);
            FractusRecursion.PythagorasTreeRecursion(Center, 2, bm);
            pictureBox1.Image = bm;

        }


    }
}
