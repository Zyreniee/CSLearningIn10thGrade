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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(1+"x" + i + "=" + 1*i);
            }
            listBox1.BackColor = button1.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(2 + "x" + i + "=" + 2 * i);
            }
            listBox1.BackColor = button2.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(3 + "x" + i + "=" + 3 * i);
            }
            listBox1.BackColor = button3.BackColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(4 + "x" + i + "=" + 4 * i);
            }
            listBox1.BackColor = button4.BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(5 + "x" + i + "=" + 5 * i);
            }
            listBox1.BackColor = button5.BackColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(6 + "x" + i + "=" + 6 * i);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(7 + "x" + i + "=" + 7 * i);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(8 + "x" + i + "=" + 8 * i);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(9 + "x" + i + "=" + 9 * i);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(10 + "x" + i + "=" + 10 * i);
            }
        }
    }
}