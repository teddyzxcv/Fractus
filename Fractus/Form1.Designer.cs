namespace Fractus
{
    public partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChooseFractus = new System.Windows.Forms.GroupBox();
            this.CantorSet = new System.Windows.Forms.RadioButton();
            this.SierpinskiTriangle = new System.Windows.Forms.RadioButton();
            this.SierpinskiCarpet = new System.Windows.Forms.RadioButton();
            this.KochSnowflake = new System.Windows.Forms.RadioButton();
            this.PythagorasTree = new System.Windows.Forms.RadioButton();
            this.StepOfRecursion = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.endColor = new System.Windows.Forms.Button();
            this.startColor = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.ChooseFractus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepOfRecursion)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseFractus
            // 
            this.ChooseFractus.Controls.Add(this.CantorSet);
            this.ChooseFractus.Controls.Add(this.SierpinskiTriangle);
            this.ChooseFractus.Controls.Add(this.SierpinskiCarpet);
            this.ChooseFractus.Controls.Add(this.KochSnowflake);
            this.ChooseFractus.Controls.Add(this.PythagorasTree);
            this.ChooseFractus.Location = new System.Drawing.Point(12, 12);
            this.ChooseFractus.Name = "ChooseFractus";
            this.ChooseFractus.Size = new System.Drawing.Size(278, 273);
            this.ChooseFractus.TabIndex = 2;
            this.ChooseFractus.TabStop = false;
            this.ChooseFractus.Text = "Choose your fractus:";
            // 
            // CantorSet
            // 
            this.CantorSet.AutoSize = true;
            this.CantorSet.Location = new System.Drawing.Point(16, 205);
            this.CantorSet.Name = "CantorSet";
            this.CantorSet.Size = new System.Drawing.Size(163, 35);
            this.CantorSet.TabIndex = 4;
            this.CantorSet.TabStop = true;
            this.CantorSet.Text = "Cantor set";
            this.CantorSet.UseVisualStyleBackColor = true;
            this.CantorSet.CheckedChanged += new System.EventHandler(this.CantorSet_CheckedChanged);
            // 
            // SierpinskiTriangle
            // 
            this.SierpinskiTriangle.AutoSize = true;
            this.SierpinskiTriangle.Location = new System.Drawing.Point(16, 163);
            this.SierpinskiTriangle.Name = "SierpinskiTriangle";
            this.SierpinskiTriangle.Size = new System.Drawing.Size(248, 35);
            this.SierpinskiTriangle.TabIndex = 3;
            this.SierpinskiTriangle.TabStop = true;
            this.SierpinskiTriangle.Text = "Sierpinski triangle";
            this.SierpinskiTriangle.UseVisualStyleBackColor = true;
            this.SierpinskiTriangle.CheckedChanged += new System.EventHandler(this.SierpinskiTriangle_CheckedChanged);
            // 
            // SierpinskiCarpet
            // 
            this.SierpinskiCarpet.AutoSize = true;
            this.SierpinskiCarpet.Location = new System.Drawing.Point(16, 122);
            this.SierpinskiCarpet.Name = "SierpinskiCarpet";
            this.SierpinskiCarpet.Size = new System.Drawing.Size(233, 35);
            this.SierpinskiCarpet.TabIndex = 2;
            this.SierpinskiCarpet.TabStop = true;
            this.SierpinskiCarpet.Text = "Sierpinski carpet";
            this.SierpinskiCarpet.UseVisualStyleBackColor = true;
            this.SierpinskiCarpet.CheckedChanged += new System.EventHandler(this.SierpinskiCarpet_CheckedChanged);
            // 
            // KochSnowflake
            // 
            this.KochSnowflake.AutoSize = true;
            this.KochSnowflake.Location = new System.Drawing.Point(16, 80);
            this.KochSnowflake.Name = "KochSnowflake";
            this.KochSnowflake.Size = new System.Drawing.Size(223, 35);
            this.KochSnowflake.TabIndex = 1;
            this.KochSnowflake.TabStop = true;
            this.KochSnowflake.Text = "Koch snowflake";
            this.KochSnowflake.UseVisualStyleBackColor = true;
            this.KochSnowflake.CheckedChanged += new System.EventHandler(this.KochSnowflake_CheckedChanged);
            // 
            // PythagorasTree
            // 
            this.PythagorasTree.AutoSize = true;
            this.PythagorasTree.Checked = true;
            this.PythagorasTree.Location = new System.Drawing.Point(16, 39);
            this.PythagorasTree.Name = "PythagorasTree";
            this.PythagorasTree.Size = new System.Drawing.Size(226, 35);
            this.PythagorasTree.TabIndex = 0;
            this.PythagorasTree.TabStop = true;
            this.PythagorasTree.Text = "Pythagoras tree";
            this.PythagorasTree.UseVisualStyleBackColor = true;
            this.PythagorasTree.CheckedChanged += new System.EventHandler(this.PythagorasTree_CheckedChanged);
            // 
            // StepOfRecursion
            // 
            this.StepOfRecursion.Location = new System.Drawing.Point(21, 540);
            this.StepOfRecursion.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.StepOfRecursion.Name = "StepOfRecursion";
            this.StepOfRecursion.Size = new System.Drawing.Size(240, 38);
            this.StepOfRecursion.TabIndex = 5;
            this.StepOfRecursion.ValueChanged += new System.EventHandler(this.StepOfRecursion_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(44, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Step recursion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.endColor);
            this.groupBox2.Controls.Add(this.startColor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 200);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose pen width, start and end color";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(14, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Pen width";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(32, 130);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(68, 35);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // endColor
            // 
            this.endColor.BackColor = System.Drawing.Color.Red;
            this.endColor.Location = new System.Drawing.Point(124, 130);
            this.endColor.Name = "endColor";
            this.endColor.Size = new System.Drawing.Size(148, 46);
            this.endColor.TabIndex = 2;
            this.endColor.Text = "end color";
            this.endColor.UseVisualStyleBackColor = false;
            this.endColor.Click += new System.EventHandler(this.button3_Click);
            // 
            // startColor
            // 
            this.startColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startColor.Location = new System.Drawing.Point(124, 70);
            this.startColor.Name = "startColor";
            this.startColor.Size = new System.Drawing.Size(148, 46);
            this.startColor.TabIndex = 1;
            this.startColor.Text = "start color";
            this.startColor.UseVisualStyleBackColor = true;
            this.startColor.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(15, 752);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(208, 90);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 30;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 752);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "30°";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 721);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Angle between recursion";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(308, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 950);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(12, 628);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(208, 90);
            this.trackBar2.TabIndex = 13;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 594);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Zoom X1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(15, 820);
            this.trackBar3.Maximum = 180;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(208, 90);
            this.trackBar3.TabIndex = 15;
            this.trackBar3.Value = 30;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(15, 916);
            this.trackBar4.Maximum = 600;
            this.trackBar4.Minimum = 125;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(208, 90);
            this.trackBar4.TabIndex = 16;
            this.trackBar4.Value = 155;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 916);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "1/1.55";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 830);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "30°";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 752);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 31);
            this.label8.TabIndex = 20;
            this.label8.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 820);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(15, 885);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Fraction between recursion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 690);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(278, 31);
            this.label10.TabIndex = 24;
            this.label10.Text = "Distance between lines";
            this.label10.Visible = false;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(21, 749);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(240, 38);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(998, 974);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StepOfRecursion);
            this.Controls.Add(this.ChooseFractus);
            this.Name = "Form1";
            this.Text = "Fractus";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ChooseFractus.ResumeLayout(false);
            this.ChooseFractus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepOfRecursion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.GroupBox ChooseFractus;
        public System.Windows.Forms.RadioButton SierpinskiTriangle;
        public System.Windows.Forms.RadioButton SierpinskiCarpet;
        public System.Windows.Forms.RadioButton KochSnowflake;
        public System.Windows.Forms.RadioButton PythagorasTree;
        public System.Windows.Forms.RadioButton CantorSet;
        public System.Windows.Forms.NumericUpDown StepOfRecursion;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button endColor;
        public System.Windows.Forms.Button startColor;
        public System.Windows.Forms.TrackBar trackBar1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TrackBar trackBar2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TrackBar trackBar3;
        public System.Windows.Forms.TrackBar trackBar4;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

