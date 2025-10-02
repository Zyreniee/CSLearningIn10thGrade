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
    
    public partial class Form5 : Form
    {
        string ad, soyad;
        float caliscakgunsayisi, izinligun, yevmiye;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            // 8 9 10 12 14
            label8.Text = null;
            label9.Text = null;
            label10.Text = null;
            label12.Text = null;
            label14.Text = null;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ad = textBox1.Text;
            soyad = textBox2.Text;
            caliscakgunsayisi = Convert.ToInt32(textBox3.Text);
            izinligun = Convert.ToInt32(textBox4.Text);
            yevmiye = Convert.ToInt32(textBox5.Text);
            float brutmaas = (caliscakgunsayisi - izinligun) * yevmiye;
            float vergi = brutmaas * 18 / 100;
            float netmaas = brutmaas - vergi;

            label8.Text = ad;
            label9.Text = soyad;
            label10.Text = brutmaas.ToString();
            label12.Text = vergi.ToString();
            label14.Text = netmaas.ToString();



        }
    }
}
