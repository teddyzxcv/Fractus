namespace Fractus
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.endColor = new System.Windows.Forms.Button();
            this.startColor = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChooseFractus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepOfRecursion)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            // 
            // PythagorasTree
            // 
            this.PythagorasTree.AutoSize = true;
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
            this.StepOfRecursion.Location = new System.Drawing.Point(28, 558);
            this.StepOfRecursion.Name = "StepOfRecursion";
            this.StepOfRecursion.Size = new System.Drawing.Size(240, 38);
            this.StepOfRecursion.TabIndex = 5;
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
            this.groupBox2.Controls.Add(this.endColor);
            this.groupBox2.Controls.Add(this.startColor);
            this.groupBox2.Location = new System.Drawing.Point(12, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 200);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose start and end color";
            // 
            // endColor
            // 
            this.endColor.Location = new System.Drawing.Point(124, 122);
            this.endColor.Name = "endColor";
            this.endColor.Size = new System.Drawing.Size(148, 46);
            this.endColor.TabIndex = 2;
            this.endColor.Text = "end color";
            this.endColor.UseVisualStyleBackColor = true;
            this.endColor.Click += new System.EventHandler(this.button3_Click);
            // 
            // startColor
            // 
            this.startColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startColor.Location = new System.Drawing.Point(124, 57);
            this.startColor.Name = "startColor";
            this.startColor.Size = new System.Drawing.Size(148, 46);
            this.startColor.TabIndex = 1;
            this.startColor.Text = "start color";
            this.startColor.UseVisualStyleBackColor = true;
            this.startColor.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(296, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 729);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1078, 753);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StepOfRecursion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChooseFractus);
            this.Name = "Form1";
            this.Text = "Fractus";
            this.ChooseFractus.ResumeLayout(false);
            this.ChooseFractus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepOfRecursion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox ChooseFractus;
        private System.Windows.Forms.RadioButton SierpinskiTriangle;
        private System.Windows.Forms.RadioButton SierpinskiCarpet;
        private System.Windows.Forms.RadioButton KochSnowflake;
        private System.Windows.Forms.RadioButton PythagorasTree;
        private System.Windows.Forms.RadioButton CantorSet;
        private System.Windows.Forms.NumericUpDown StepOfRecursion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button endColor;
        private System.Windows.Forms.Button startColor;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

