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
    public partial class Form2 : Form
    {

        string ad, soyad;
        float y1, y2, performans, ortalama;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            //6 7  10 12

            label6.Text = null;
            label7.Text = null;
            label10.Text = null;
            label12.Text = null;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            ad = textBox1.Text;
            soyad = textBox2.Text;
            y1 = Convert.ToInt32(textBox3.Text);
            y2 = Convert.ToInt32(textBox4.Text);
            performans = Convert.ToInt32(textBox5.Text);
            ortalama = (y1 + y2 + performans) / 3;



            label6.Text = textBox1.Text;
            label7.Text = textBox2.Text;
            label10.Text = ortalama.ToString();
            

            
            if (ortalama >= 50)
            {
                label12.Text = "Sınıfı Geçmiştir!";
            }
            else
            {
                label12.Text = "Sınıfta Kalmıştır!";
            }


        }
    }
}
