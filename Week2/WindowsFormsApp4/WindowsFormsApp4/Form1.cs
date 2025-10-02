using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        public string yolcuAdi, yolcuSoyadi;
        public float koltukNo, biletFiyati , odenenPara, paraUstu, KDV,sonucFiyat;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
            //9 - 22
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            label16.Text = null;
            label8.Text = null;
            label17.Text = null;
            label18.Text = null;
            label19.Text = null;
            label20.Text = null;
            label21.Text = null;
            label22.Text = null;
            MessageBox.Show("Faturanız Başarıyla Kesilmiştir!");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            biletFiyati = 50;
            KDV = (biletFiyati*18)/100;
            sonucFiyat = biletFiyati + KDV;
            sonucFiyat = 59;
            //Text Boxa gösterme veya ordan alma
            koltukNo = Convert.ToInt32(textBox1.Text);
            yolcuAdi = textBox2.Text;
            yolcuSoyadi = textBox3.Text;
            odenenPara = Convert.ToInt32(textBox5.Text);
            textBox4.Text = biletFiyati.ToString();
            paraUstu = odenenPara- sonucFiyat;
            biletFiyati = sonucFiyat;
            textBox6.Text = paraUstu.ToString();
            label22.Text = koltukNo.ToString();
            label21.Text = yolcuAdi.ToString();
            textBox4.Text = sonucFiyat.ToString();
            label8.Text = KDV.ToString();
            label16.Text = KDV.ToString();
            label20.Text = yolcuSoyadi.ToString();
            label19.Text = biletFiyati.ToString();
            label18.Text = odenenPara.ToString();
            label17.Text = paraUstu.ToString();
            label16.Text = KDV.ToString();
        }
    }
}
