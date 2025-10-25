using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public string urunadi, fiyat;
        public int adet = 0;
        public int urunsayisi , toplam;

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            listBox1.BackColor = colorDialog1.Color;
            listBox2.BackColor = colorDialog1.Color;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.ceptelefonu != null)
            {
                label2.Text = "Cep Telefonu";
                label3.Text = Form1.ceptelefonu;
            }
            if(Form1.sifre != null)
            {
                label2.Text = "Şifre";
                label3.Text = Form1.sifre;

            }
            if (Form1.tc != null)
            {
                label2.Text = "Tc";
                label3.Text = Form1.tc;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Adet 1 arttırılsın mı?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                adet = adet + 1;
                label7.Text = adet.ToString();

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Adet 1 azaltılsın mı?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                adet = adet - 1;
                label7.Text = adet.ToString();
            }
            if(adet < 0)
            {
                adet = 0;
                label7.Text = adet.ToString();

                MessageBox.Show("Adet 0 dan küçük olamaz");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("ÜRÜN ADI YADA FİYAT BİLGİSİ BOŞ GEÇİLEMEZ!");

            }
            else
            {

                urunadi = textBox1.Text;
                urunsayisi = urunsayisi + 1;
                label13.Text = urunsayisi.ToString();
                fiyat = textBox2.Text;
                toplam = Convert.ToInt32(fiyat) + toplam;
                label12.Text = toplam.ToString();
                listBox1.Items.Add(urunadi);
                listBox2.Items.Add(fiyat);
                textBox1.Clear();
                textBox2.Clear();
               
            }

            
        }
    }
}
