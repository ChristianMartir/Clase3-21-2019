using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, r;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a + b;
            textBox3.Text = r.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, r;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a - b;
            textBox3.Text = r.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            int a, b, r;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a * b;
            textBox3.Text = r.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int a, b, r;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a - b;
            textBox3.Text = r.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int a, b, r;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
           
        

            if (b > 0)
            {
                r = a / b;
                textBox3.Text = r.ToString();
            }
            else
            {
                r = 0;
                textBox3.Text = r.ToString();
            }

        }
    }
}
