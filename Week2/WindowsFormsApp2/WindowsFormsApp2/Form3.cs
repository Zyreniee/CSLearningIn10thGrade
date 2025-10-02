using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int y1, y2, performans;
            int ortalama;


            ad = textBox1.Text;
            soyad = textBox2.Text;

            y1= Convert.ToInt32(textBox3.Text);
            y2 = Convert.ToInt32(textBox6.Text);
            performans = Convert.ToInt32(textBox5.Text);

            ortalama = (y1 + y2 + performans) / 3;

            textBox4.Text = ortalama.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
