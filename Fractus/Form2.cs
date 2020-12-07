using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fractus
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// Initialize the error form.
        /// </summary>
        public Form2()
        {
            InitializeComponent();
            Form1 obj = new Form1();
            obj.Close();
        }
        /// <summary>
        /// Close when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
