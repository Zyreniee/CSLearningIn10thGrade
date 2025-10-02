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
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "100")
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();

            }
            else if (textBox1.Text == "200")
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            else if (textBox1.Text == "300")
            {
                Form4 f4 = new Form4();
                f4.ShowDialog();
            }
            else if (textBox1.Text == "400")
            {
                Form5 f5 = new Form5();
                f5.ShowDialog   ();
            }
            else {
                MessageBox.Show("Girdiğiniz Sayı Hatalı!");
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}
