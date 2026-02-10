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
    public partial class Form2 : Form
    {
        public string yemekTuru;
        public decimal yemekFiyati,toplamFiyat,kdvOrani,toplam;
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Çorbalar")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Mercimek Çorbası");
                comboBox2.Items.Add("Domates Çorbası");
            }
            if (comboBox1.Text == "Pilavlar")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Pirinç Pilavı");
                comboBox2.Items.Add("Bulgur Pilavı");
            }
            if (comboBox1.Text == "Tatlılar")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Kabak Tatlısı");
            }
            if (comboBox1.Text == "Et Yemekleri")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Tava");
                comboBox2.Items.Add("Bezelye");
            }
            if (comboBox1.Text == "İçecekler")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Kola");
                comboBox2.Items.Add("Ayran");
            }      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Mercimek Çorbası" && radioButton1.Checked)
            {
                yemekFiyati = 2.5m;
                listBox1.Items.Add("Mercimek Çorbası");
                listBox2.Items.Add(yemekFiyati);
            }
            else if (comboBox2.Text == "Mercimek Çorbası" && radioButton2.Checked)
            {
                yemekFiyati = 1.25m;
                listBox1.Items.Add("Mercimek Çorbası");
                listBox2.Items.Add(yemekFiyati);
            }

            if (comboBox2.Text == "Domates Çorbası" && radioButton1.Checked)
            {
                yemekFiyati = 3m;
                listBox1.Items.Add("Domates Çorbası");
                listBox2.Items.Add(yemekFiyati);
            }
            else if (comboBox2.Text == "Domates Çorbası" && radioButton2.Checked)
            {
                yemekFiyati = 1.5m;
                listBox1.Items.Add("Domates Çorbası");
                listBox2.Items.Add(yemekFiyati);
            }

            if (comboBox2.Text == "Pirinç Pilavı" && radioButton1.Checked)
            {
                yemekFiyati = 3m;
                listBox1.Items.Add("Pirinç Pilavı");
                listBox2.Items.Add(yemekFiyati);
            }
            else if (comboBox2.Text == "Pirinç Pilavı" && radioButton2.Checked)
            {
                yemekFiyati = 1.5m;
                listBox1.Items.Add("Pirinç Pilavı");
                listBox2.Items.Add(yemekFiyati);
            }

            if (comboBox2.Text == "Bulgur Pilavı" && radioButton1.Checked)
            {
                yemekFiyati = 2.5m;
                listBox1.Items.Add("Bulgur Pilavı");
                listBox2.Items.Add(yemekFiyati);
            }
            else if (comboBox2.Text == "Bulgur Pilavı" && radioButton2.Checked)
            {
                yemekFiyati = 1.25m;
                listBox1.Items.Add("Bulgur Pilavı");
                listBox2.Items.Add(yemekFiyati);
            }

            if (comboBox2.Text == "Kabak Tatlısı" && radioButton1.Checked)
            {
                yemekFiyati = 5m;
                listBox1.Items.Add("Kabak Tatlısı");
                listBox2.Items.Add(yemekFiyati);
            }
            else if (comboBox2.Text == "Kabak Tatlısı" && radioButton2.Checked)
            {
                yemekFiyati = 2.5m;
                listBox1.Items.Add("Kabak Tatlısı");
                listBox2.Items.Add(yemekFiyati);
            }

            if (comboBox2.Text == "Bezelye" && radioButton1.Checked)
            {
                yemekFiyati = 5m;
                listBox1.Items.Add("Bezelye");
                listBox2.Items.Add(yemekFiyati);
            }
            else if (comboBox2.Text == "Bezelye" && radioButton2.Checked)
            {
                yemekFiyati = 2.5m;
                listBox1.Items.Add("Bezelye");
                listBox2.Items.Add(yemekFiyati);
            }

            if (comboBox2.Text == "Tava" && radioButton1.Checked)
            {
                yemekFiyati = 7m;
                listBox1.Items.Add("Tava");
                listBox2.Items.Add(yemekFiyati);
            }
            else if (comboBox2.Text == "Tava" && radioButton2.Checked)
            {
                yemekFiyati = 3.5m;
                listBox1.Items.Add("Tava");
                listBox2.Items.Add(yemekFiyati);
            }

            if (comboBox2.Text == "Kola" && radioButton1.Checked)
            {
                yemekFiyati = 2m;
                listBox1.Items.Add("Kola");
                listBox2.Items.Add(yemekFiyati);
            }
            else if (comboBox2.Text == "Kola" && radioButton2.Checked)
            {
                yemekFiyati = 2m;
                listBox1.Items.Add("Kola");
                listBox2.Items.Add(yemekFiyati);
            }

            if (comboBox2.Text == "Ayran" && radioButton1.Checked)
            {
                yemekFiyati = 1m;
                listBox1.Items.Add("Ayran");
                listBox2.Items.Add(yemekFiyati);
            }
            else if (comboBox2.Text == "Ayran" && radioButton2.Checked)
            {
                yemekFiyati = 1m;
                listBox1.Items.Add("Ayran");
                listBox2.Items.Add(yemekFiyati);
            }
            //------------------------------------------
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                decimal sayi = Convert.ToDecimal(listBox2.Items[i].ToString());
                toplamFiyat = yemekFiyati + sayi;
            }
            label10.Text = listBox1.Items.Count.ToString();
            label11.Text = toplamFiyat.ToString();


            textBox1.Text = label11.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
            
        }

        private void tümünüSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                kdvOrani = (toplamFiyat * 8) / 100;
                toplam = toplamFiyat + kdvOrani;
            }
            else if (checkBox1.Checked == false)
            {
                toplam = toplamFiyat;
            }

            textBox2.Text = kdvOrani.ToString();
            textBox3.Text = toplam.ToString();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
