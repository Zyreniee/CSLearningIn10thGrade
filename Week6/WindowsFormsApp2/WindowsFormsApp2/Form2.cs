using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 100)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 100;
            while (i >= 1)
            {
                listBox1.Items.Add(i);
                i--;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 1;
            while(i <= 100)
            {
                if (i % 2 != 0)
                {
                    listBox1.Items.Add(i);
                }
                i++;
            }
            
        }
        public int baslangic, bitis;

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 100;
            while (i >= 1)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
                i--;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
             baslangic= Convert.ToInt32(textBox1.Text);
             bitis = Convert.ToInt32(textBox2.Text);

            if (baslangic < bitis)
            {
                while (bitis >= baslangic)
                {
                    listBox1.Items.Add(baslangic);
                    baslangic++;

                }
            }

            else if(bitis < baslangic)
            {
                while(baslangic >= bitis)
                {
                    listBox1.Items.Add(baslangic);
                    baslangic--;

                }
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
