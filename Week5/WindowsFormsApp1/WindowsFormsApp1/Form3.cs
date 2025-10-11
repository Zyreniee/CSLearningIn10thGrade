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
    public partial class Form3 : Form
    {
        public int sayi , tektoplam , cifttoplam;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox1.Text);//çift sayı
            if (sayi %2 == 0)
            {
                listBox2.Items.Add(sayi.ToString());
                cifttoplam = sayi + cifttoplam;
                label7.Text = cifttoplam.ToString();
            }
            else if (sayi%2 != 0)//tek sayı
            {
                listBox1.Items.Add(sayi);
                tektoplam = sayi + tektoplam;
                label5.Text = tektoplam.ToString();
            }
            // label 5 and label7
        }
    }
}
