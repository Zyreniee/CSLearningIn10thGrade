using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public string sifre, kadi;
        public float denemeHakki = 2;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kadi = textBox1.Text;
            sifre = textBox2.Text;
            label5.Text = denemeHakki.ToString();
            if (kadi == "admin" && sifre == "admin123")
            {
                MessageBox.Show("Başarıyla giriş yaptınız!");
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else if (kadi != "admin" && sifre != "admin123")
            {
                MessageBox.Show("İkisinide yanlış girdiniz!");
                denemeHakki--;
            }

            else if (kadi == "admin" && sifre != "admin123")
            {
                MessageBox.Show("Şifreyi yanlış girdiniz!");
                denemeHakki--;

            }

            else
            {
                MessageBox.Show("Kullanıcı adını yanlış girdiniz!");
                denemeHakki--;

            }

            if(denemeHakki < 0)
            {
                Application.Exit();
            }
        }
    }
}
