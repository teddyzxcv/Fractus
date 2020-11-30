using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;
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
            trackBar2.Value = 1;

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
                numericUpDown1.Visible = false;
                label10.Visible = false;

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
                numericUpDown1.Visible = false;
                label10.Visible = false;


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
            Fractus.GenerateColorList(endColor.BackColor, startColor.BackColor, (int)StepOfRecursion.Value);
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
                DrawSierpinskiCarpet();
            }
            else
            if (SierpinskiTriangle.Checked)
            {
                DrawSierpinskiTriangle();
            }
            else
            if (CantorSet.Checked)
            {
                DrawCantorSet();
            }

        }
        public void DrawPythagorasTree()
        {
            double zoom = trackBar2.Value;
            PythagorasTreeR pt = new PythagorasTreeR()
            {

                PythagorasAngle1 = trackBar1.Value,
                PythagorasAngle2 = trackBar3.Value,
                FractionBetweenRecursion = trackBar4.Value,
                LevelRecursion = (int)StepOfRecursion.Value,
                bm = new Bitmap(panel1.Size.Width * (int)zoom, panel1.Size.Height * (int)zoom),
                StartPoint = new Point(panel1.Size.Width * (int)zoom / 2, 100),
                Size = (int)(300 * zoom)
            };
            pt.Paint();
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = pt.bm;
            pictureBox1.Size = pt.bm.Size;
        }
        public void DrawKochSnowflake()
        {
            double zoom = trackBar2.Value;
            Bitmap bmp = new Bitmap(panel1.Size.Width * (int)zoom, panel1.Size.Height * (int)zoom);
            KochSnowflakeR kf = new KochSnowflakeR()
            {
                LevelRecursion = (int)StepOfRecursion.Value,
                bm = bmp,
                StartPoint = new Point(bmp.Size.Width / 2 + 500, bmp.Size.Height / 2 + 200),
                Size = (int)(1000 * zoom)
            };
            kf.Paint();
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = kf.bm;
            pictureBox1.Size = kf.bm.Size;
        }
        public void DrawSierpinskiCarpet()
        {
            double zoom = trackBar2.Value;
            Bitmap bmp = new Bitmap(panel1.Size.Width * (int)zoom, panel1.Size.Height * (int)zoom);
            Point Center = new Point(bmp.Size.Width / 2 - 250, bmp.Size.Height / 2 - 250);
            SiepinskiCarpetR siecar = new SiepinskiCarpetR()
            {
                LevelRecursion = (int)StepOfRecursion.Value,
                bm = bmp,
                StartPoint = Center,
                Size = (int)(500 * zoom)
            };

            siecar.Paint();
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = siecar.bm;
            pictureBox1.Size = siecar.bm.Size;
        }
        public void DrawSierpinskiTriangle()
        {

            double zoom = trackBar2.Value;
            double size = 500 * zoom;
            Bitmap bmp = new Bitmap(panel1.Size.Width * (int)zoom, panel1.Size.Height * (int)zoom);
            Point Center = new Point(bmp.Size.Width / 2, bmp.Size.Height / 2);
            SiepinskiTriangleR sr = new SiepinskiTriangleR()
            {
                LevelRecursion = (int)StepOfRecursion.Value - 1,
                bm = bmp,
                StartPoint = Center,
                Size = (int)(500 * zoom)
            };
            sr.Paint();
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = sr.bm;
            pictureBox1.Size = sr.bm.Size;
        }
        public void DrawCantorSet()
        {
            double zoom = trackBar2.Value;
            Bitmap bmp = new Bitmap(panel1.Size.Width * (int)zoom, panel1.Size.Height * (int)zoom);
            Point Center = new Point(bmp.Size.Width / 2, bmp.Size.Height / 2);
            CantorSetR cr = new CantorSetR()
            {
                LevelRecursion = (int)StepOfRecursion.Value,
                bm = bmp,
                StartPoint = Center,
                Size = 1000 * (int)zoom,
                Distance = (int)numericUpDown1.Value
            };
            cr.Paint();
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = cr.bm;
            pictureBox1.Size = cr.bm.Size;
        }

        private void StepOfRecursion_ValueChanged(object sender, EventArgs e)
        {
            if ((KochSnowflake.Checked && (StepOfRecursion.Value <= 5 || trackBar2.Value > 3)) || !KochSnowflake.Checked)
                DrawFractus();
            else
                StepOfRecursion.Value = 5;

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
            panel1.AutoScrollPosition = new Point(pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2);
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
            trackBar2.Value = 1;


            DrawFractus();
        }

        private void KochSnowflake_CheckedChanged(object sender, EventArgs e)
        {
            trackBar2.Value = 1;

            StepOfRecursion.Value = 0;
            DrawFractus();
        }

        private void SierpinskiCarpet_CheckedChanged(object sender, EventArgs e)
        {
            trackBar2.Value = 1;

            StepOfRecursion.Value = 0;
            DrawFractus();
        }

        private void SierpinskiTriangle_CheckedChanged(object sender, EventArgs e)
        {
            trackBar2.Value = 1;

            StepOfRecursion.Value = 0;
            DrawFractus();
        }

        private void CantorSet_CheckedChanged(object sender, EventArgs e)
        {
            trackBar2.Value = 1;

            if (CantorSet.Checked)
            {
                numericUpDown1.Visible = true;
                label10.Visible = true;
            }
            else
            {
                numericUpDown1.Visible = false;
                label10.Visible = false;
            }
            StepOfRecursion.Value = 0;
            DrawFractus();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            DrawFractus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(dialog.FileName, ImageFormat.Jpeg);

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Fractus.PenSize = (int)numericUpDown2.Value;
            DrawFractus();  
        }
    }
}
