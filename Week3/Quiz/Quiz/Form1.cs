using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public float ortalama, y1, y2, performans;
        public string durum;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            y1 = Convert.ToInt32(textBox1.Text);
            y2 = Convert.ToInt32(textBox2.Text);
            performans = Convert.ToInt32(textBox3.Text);
            ortalama = (y1 + y2 + performans) / 3;
            label5.Text = ortalama.ToString();

            if(ortalama >= 85)
            {
                label6.Text = "Pek İyi";
                label8.Text = "Geçti!";
            }

            else if (ortalama >= 70 && ortalama <= 84)
            {
                label6.Text = "İyi";
                label8.Text = "Geçti!";
            }

            else if (ortalama >= 50 && ortalama <=69)
            {
                label6.Text = "Orta";
                label8.Text = "Geçti!";
            }

            else if (ortalama >= 25 && ortalama <= 49)
            {
                label6.Text = "Zayıf";
                label8.Text = "Kaldı!";
            }

            else if (ortalama >= 0 && ortalama <= 24)
            {
                label6.Text = "Etkisiz!";
                label8.Text = "Kaldı!";
            }

            else
            {
                MessageBox.Show("Ortalama referans dışı!");
            }

        }
    }
}
