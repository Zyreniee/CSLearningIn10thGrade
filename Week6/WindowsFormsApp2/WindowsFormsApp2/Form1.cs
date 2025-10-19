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
        public int toplam;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(Interaction.InputBox("Lütfen Bir Sayı Giriniz","Sayı Alma"," ",400,400));
            if (sayi % 2 != 0)
            {
                listBox1.Items.Add(sayi);
                toplam = toplam + sayi;
            }
            label2.Text = toplam.ToString();

        }
    }
}
//This Was a Quiz and i had 100.