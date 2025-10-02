using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            float y1, y2, performans,ortalama;
            ad = "Yusuf";
            soyad = "Gön";
            y1 = 99.9f;
            y2 = 50;
            performans = 75;

            ortalama = (y1 + y2 + performans) /3;

            label6.Text =ad;
            label7.Text = soyad;
            label8.Text =y1.ToString();
            label9.Text =y2.ToString();
            label10.Text = performans.ToString();
            label11.Text = ortalama.ToString();
        }
    }
}
