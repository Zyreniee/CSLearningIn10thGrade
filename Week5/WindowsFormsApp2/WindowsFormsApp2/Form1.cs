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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad =Interaction.InputBox("Adınızı Girin " , "Bilgi Girişi", "",500,500);
            label3.Text = ad;
            string soyad = Interaction.InputBox("Soyadınızı Girin ", "Bilgi Girişi", "", 500, 500);
            label4.Text = soyad;



        }
    }
}
