using Microsoft.VisualBasic;
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
    public partial class Form1 : Form
    {
        int elemansayisi;
        public Form1()
        {
            InitializeComponent();
        }
        string[] kitaplar = new string[100];
        private void button1_Click(object sender, EventArgs e)
        {
            elemansayisi = Convert.ToInt32(Interaction.InputBox("Kaç Adet Kitap Girmek İstersiniz?", "Kitap Girişi", "", -1, -1));
            string[] kitaplar = new string[elemansayisi];

            for (int i = 0; i < elemansayisi; i++)
            {
                kitaplar[i] = Interaction.InputBox((i + 1) + "Kitabı giriniz", "Kitap Girişi", "", -1, -1);
            }


            for (int i = 0; i < kitaplar.Length; i++)
            {
                listBox1.Items.Add(kitaplar[i]);
            }
            label2.Text = listBox1.Items.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value - 1;
            label5.Text = progressBar1.Value.ToString();
            if(progressBar1.Value == progressBar1.Minimum){
                Application.Exit();
            }
        }
    }
}
