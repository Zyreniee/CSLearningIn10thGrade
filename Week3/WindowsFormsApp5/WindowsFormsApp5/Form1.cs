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
    public partial class Form1 : Form
    {
        public string sifre = "admin123", kullaniciad = "admin";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciad = textBox1.Text;
            sifre = textBox2.Text;
            if(kullaniciad == "admin" && sifre == "admin123")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }

            else if (kullaniciad != "admin" && sifre != "admin123")
            {
                MessageBox.Show("Yanlış her ikiside");

            }

            else if (kullaniciad == "admin" && sifre != "admin123")
            {
                MessageBox.Show("Şifre yanlış!");
            }
            else if(textBox1.Text == " " || textBox2.Text == " ")
            {
                MessageBox.Show("Lütfen değer gir!");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı yanlış!");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }

        }
    }
    }