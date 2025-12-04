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
    public partial class Form2 : Form
    {
        public static string ad, soyad;
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "4")
            {
                comboBox3.Items.Add("3");
                comboBox3.Items.Add("4");
            }
            if (comboBox1.Text == "2")
            {
                comboBox3.Items.Remove("3");
                comboBox3.Items.Remove("4");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "2")
            {
                if(comboBox2.Text == "1")
                {
                    if (comboBox3.Text == "1")
                    {
                        radioButton1.Checked = true;
                    }
                    if(comboBox3.Text == "2")
                    {
                        radioButton2.Checked = true;
                    }
                }
                if(comboBox2.Text == "2")
                {
                    if(comboBox3.Text == "1")
                    {
                        radioButton4.Checked = true;
                    }
                    if(comboBox3.Text == "2")
                    {
                        radioButton3.Checked = true;
                    }
                }
            }

            if(comboBox1.Text == "4")
            {
                if(comboBox2.Text == "1")
                {
                    if(comboBox3.Text == "1")
                    {
                        radioButton8.Checked = true;
                    }
                    if(comboBox3.Text == "2")
                    {
                        radioButton7.Checked = true;
                    }
                    if (comboBox3.Text == "3")
                    {
                        radioButton6.Checked = true;
                    }
                    if (comboBox3.Text == "4")
                    {
                        radioButton5.Checked = true;
                    }
                }
                if(comboBox2.Text == "2")
                {

                    if (comboBox3.Text == "1")
                    {
                        radioButton11.Checked = true;
                    }
                    if (comboBox3.Text == "2")
                    {
                        radioButton12.Checked = true;
                    }
                    if (comboBox3.Text == "3")
                    {
                        radioButton10.Checked = true;
                    }
                    if (comboBox3.Text == "4")
                    {
                        radioButton9.Checked = true;
                    }
                }
            }
        }
    }
}
