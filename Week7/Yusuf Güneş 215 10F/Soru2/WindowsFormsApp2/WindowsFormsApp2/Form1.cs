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
        public int baslangic, bitis;
        public int bolunensayilar;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!");
            }
            else
            {
                if(radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Lütfen Seçim Yapınız");
                }
                else
                {
                    if (radioButton1.Checked)
                    {
                        baslangic = Convert.ToInt32(textBox1.Text);
                        bitis = Convert.ToInt32(textBox2.Text);
                        for (int i = baslangic; i <bitis; i++)
                        {
                            if(i%2 != 0)
                            {
                                bolunensayilar = i;
                                listBox1.Items.Add(bolunensayilar);

                            }
                        }
                    }
                    if (radioButton2.Checked)
                    {
                        baslangic = Convert.ToInt32(textBox1.Text);
                        bitis = Convert.ToInt32(textBox2.Text);
                        for (int i = baslangic ; i < bitis; i++)
                        {
                            if(i%2 == 0)
                            {
                                bolunensayilar = i;
                                listBox1.Items.Add(bolunensayilar);
                            }
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
