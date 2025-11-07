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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public int koltukno;
        public string adsoyad, hareketsaati, kalkisyeri, varisyeri,hersey;

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox4.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox4.Items.Remove(listBox4.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = listBox1.SelectedIndex;
            hersey = adsoyad + hareketsaati + kalkisyeri + varisyeri;
            listBox2.Items.Insert(sayi,hersey);
            listBox1.Items.Remove(hersey);
            listBox1.Items.Insert(sayi,hersey);
            listBox4.Items.Remove(koltukno);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
            listBox3.Items.Remove(listBox3.SelectedItem);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string secim = Interaction.InputBox("Hangi arabanın yoğunluğunu öğrenmek istersiniz = \n 1,2","Seçim","",300,300);
            if(secim == "1")
            {
                MessageBox.Show("Toplam yolcu sayısı " +listBox4.Items.Count);
            }
            if(secim == "2")
            {
                MessageBox.Show("Toplam yolcu sayısı " + listBox3.Items.Count);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            koltukno = Convert.ToInt32(textBox1.Text);
            adsoyad = textBox2.Text;
            hareketsaati = textBox3.Text;
            kalkisyeri = textBox4.Text;
            varisyeri = textBox5.Text;

            if(comboBox1.Text == "1")
            {
                if (!listBox4.Items.Contains(koltukno))
                {
                    listBox1.Items.Add(adsoyad + " " +  hareketsaati + " " + kalkisyeri + " " + varisyeri); 
                    listBox4.Items.Add(koltukno);


                }
                else
                {
                    MessageBox.Show("Bu Koltuk Dolu!");
                }
            }
           
            if (comboBox1.Text == "2")
            {
                if (!listBox3.Items.Contains(koltukno)){

                    listBox2.Items.Add(adsoyad + " " + hareketsaati + " " + kalkisyeri + " " + varisyeri);
                    listBox3.Items.Add(koltukno);
                }
                else
                {
                    MessageBox.Show("Bu koltuk dolu!");
                }
            }
        }
    }
}
