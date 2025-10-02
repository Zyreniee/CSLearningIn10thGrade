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
    public partial class Form4 : Form
    {
        decimal sonuc, sayi1, sayi2;

        private void button2_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 - sayi2;
            label4.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 * sayi2;
            label4.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 / sayi2;
            label4.Text = sonuc.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2=Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 + sayi2;
            label4.Text = sonuc.ToString();
        }
    }
}
