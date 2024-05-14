using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c;
            if (radioButton1.Checked)
            {
                c = a + b;
                label10.Text = "Sum: " + c.ToString();
            }
            if (radioButton2.Checked)
            {
                c = a - b;
                label10.Text = "Difference: " + c.ToString();
            }
            if (radioButton3.Checked)
            {
                c = a * b;
                label10.Text = "Product: " + c.ToString();
            }
            if (radioButton4.Checked)
            {
                c = a / b;
                label10.Text = "Quotient: " + c.ToString();
            }
            if (radioButton5.Checked)
            {
                c = a % b;
                label10.Text = "Modulo: " + c.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = " ";
            textBox1.Text = " ";
            textBox2.Text = " ";

        }
    }
}

