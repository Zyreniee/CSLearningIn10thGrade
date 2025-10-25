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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.GreenYellow;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Red;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.Blue;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Aqua;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text.Length < 6)
            {
                MessageBox.Show("Şifre 6 haneden küçük olamaz");
                textBox3.Clear();
                textBox3.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label9.Visible = false;
            label8.Visible = false;
            label7.Visible = false;
            label6.Visible = false;

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label9.Visible = true;
                MessageBox.Show("Ad Boş geçilemez!");
                textBox1.Focus();
            }

            else
            {
                label9.Visible = false;
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                label8.Visible = true;
                MessageBox.Show("Soyad Boş geçilemez!");
                textBox2.Focus();
            }
            else
            {
                label8.Visible = false;
            }
        }

        private void textBox4_Validated(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                label7.Visible = true;
                MessageBox.Show("Kullanıcı Adı Boş geçilemez!");
                textBox4.Focus();
            }
            else
            {
                label7.Visible = false;
            }
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                label6.Visible = true;
                MessageBox.Show("Şifre Boş geçilemez!");
                textBox3.Focus();
            }
            else
            {
                label6.Visible = false;

            }
        }
    }
}
