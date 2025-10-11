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
        public float sayi1, sayi2;
        public string islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            islem = comboBox1.Text;
            float toplam;
            switch (islem)
            {
                case "Topla":toplam = sayi1 + sayi2;label4.Text = toplam.ToString();break;
                case "Çıkar": toplam = sayi1 - sayi2; label4.Text = toplam.ToString(); break;
                case "Çarp": toplam = sayi1 * sayi2; label4.Text = toplam.ToString(); break;
                case "Böl": toplam = sayi1 / sayi2; label4.Text = toplam.ToString(); break;

            }
        }
    }
}
