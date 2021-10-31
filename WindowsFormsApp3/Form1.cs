using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) ; 
            {
                int i = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(i, 2);
             }
            if(radioButton2.Checked);
            {
                int i = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(i, 8);
            }
            if (radioButton3.Checked)
            {
                int i = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(i, 16);

            }
        }
    }
}
