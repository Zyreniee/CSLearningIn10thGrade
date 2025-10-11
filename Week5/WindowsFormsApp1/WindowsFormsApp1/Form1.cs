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
        public int sayi1, sayi2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for(int i = 0; i <= 100; i++)
            {
                listBox1.Items.Add(i+"--> Yusuf");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 100; i >= 0; i--)
            {
                listBox1.Items.Add(i + "--> Yusuf");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            if (sayi2 > sayi1)
            {
            
                for(int i = sayi1; i <= sayi2; i++)
                {
                    listBox1.Items.Add(i);
                }
            }
            else if (sayi1 > sayi2)
            {
                for(int j = sayi1; j >= sayi2; j--)
                {
                    listBox1.Items.Add(j);
                }
            }
        }
    }
}