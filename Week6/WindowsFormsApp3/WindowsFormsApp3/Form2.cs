using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public static int cekilecekparamiktari;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cekilecekparamiktari = 10;
            Form4 f4 = new Form4();
            f4.ShowDialog();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cekilecekparamiktari = 20;
            Form4 f4 = new Form4();
            f4.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cekilecekparamiktari = 50;
            Form4 f4 = new Form4();
            f4.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cekilecekparamiktari = 100;
            Form4 f4 = new Form4();
            f4.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cekilecekparamiktari = 150;
            Form4 f4 = new Form4();
            f4.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            cekilecekparamiktari = 200;
            Form4 f4 = new Form4();
            f4.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            cekilecekparamiktari = 250;
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Para çekme ekranından çıkmak istiyormusunuz?","Çıkış İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
