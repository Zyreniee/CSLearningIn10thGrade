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
    public partial class Form2 : Form
    {
        public float denemeSayisi;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            float arananSayi, tahminSayi;
            arananSayi = Convert.ToInt32(textBox1.Text);
            tahminSayi = Convert.ToInt32(textBox2.Text);


            if (arananSayi < tahminSayi)
            {
                MessageBox.Show("Aradığınız Sayı Daha küçük!");
                textBox2.Clear();
                textBox2.Focus();
                denemeSayisi++;
                label5.Text = denemeSayisi.ToString();
            }
            else if (arananSayi > tahminSayi)
            {
                MessageBox.Show("Aradığınız Sayı Daha büyük!");
                textBox2.Clear();
                textBox2.Focus();
                denemeSayisi++;
                label5.Text = denemeSayisi.ToString();
            }
            else if (arananSayi == tahminSayi)
            {
                MessageBox.Show("Tebrikler Sayıyı Buldunuz!");
                textBox2.Clear();
                textBox2.Focus();
                denemeSayisi++;
                label5.Text = denemeSayisi.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "0"; 
            denemeSayisi = 0;
        }
    }
}
