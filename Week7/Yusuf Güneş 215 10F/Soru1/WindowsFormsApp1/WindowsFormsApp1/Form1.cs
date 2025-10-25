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
    public partial class Form1 : Form
    {
        public static string girissecimi , ceptelefonu,tc,sifre;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == ".......")
            {
                MessageBox.Show("Lütfen Giriş Seçiminizi Yapınız");
            }
            else
            {
                 if (label1.Text == "Cep Telefonu")
                {
                    ceptelefonu = textBox1.Text;
                }
                 if (label1.Text == "Şifre")
                {
                    sifre = textBox1.Text;
                }
                 if (label1.Text == "Tc Kimlik")
                {
                    tc = textBox1.Text;
                }
            }

            Form2 f2 = new Form2();

            if(label1.Text == "Cep Telefonu" && textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Cep Telefonunuzu giriniz!");

            }

            else if (textBox1.Text != "")
            {
                f2.Show();
                this.Hide();

            }
            if (label1.Text == "Şifre" && textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Şifrenizi  giriniz!");
            }
            if (label1.Text == "Tc Kimlik" && textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Tc Kimliğinizi giriniz!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            girissecimi = Interaction.InputBox("Giriş Seçiniz \n 1.Cep Telefonu \n 2.Şifre \n 3.Tckimlik","Giriş","",300,300);
            switch (girissecimi)
            {
                case "1":
                    label1.Text = "Cep Telefonu";
                    textBox1.Text = ceptelefonu;
                    break;
                case "2":
                    label1.Text = "Şifre";
                    textBox1.Text = sifre;
                    break;
                case "3":
                    label1.Text = "Tc Kimlik";
                    textBox1.Text = tc;
                    break;


            }
        }
    }
}
