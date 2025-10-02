using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public int sicaklik;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if(textBox1.Text == "")
            {
                MessageBox.Show("bişey   gir");
            }
            else
            {
                sicaklik = Convert.ToInt32(textBox1.Text);
                if (sicaklik >= 0 && sicaklik <= 15)
                {
                    label2.Text = "Soğuk";
                }
                else if (sicaklik >= 16 && sicaklik <= 25)
                {
                    label2.Text = "Ilık";
                }
                else if (sicaklik >= 26 && sicaklik <= 40)
                {
                    label2.Text = "Sıcak";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "....................................";
        }
    }
}
