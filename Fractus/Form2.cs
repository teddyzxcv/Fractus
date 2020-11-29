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
        public Form2()
        {
            InitializeComponent();
            Form1 obj = new Form1();
            obj.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();           
        }
    }
}
