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
    public partial class Form1 : Form
    {
        float degisken;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            degisken = Convert.ToInt32(textBox1.Text);       
                switch (degisken)
                {
                    case 1:
                        degisken = 1;
                        MessageBox.Show("IT'S SUNDAY");
                        break;
                    case 2:
                        degisken = 2;
                        MessageBox.Show("IT'S TUESDAY");
                        break;

                                                                                                                  
                    case 3:
                        degisken = 3;
                        MessageBox.Show("IT'S WEDNESDAY");

                        break;

                    case 4:
                        degisken = 4;
                        MessageBox.Show("IT'S THURSDAY");

                        break;

                    case 5:
                        degisken = 5;
                        MessageBox.Show("IT'S FRİDAY");

                        break;

                    case 6:
                        degisken = 6;
                        MessageBox.Show("IT'S SATURDAY");

                        break;

                    case 7:
                        degisken = 7;
                        MessageBox.Show("IT'S MONDAY");

                        break;

                    default:
                        MessageBox.Show("PLEASE INPUT A VALID NUMBER!");
                    textBox1.Clear();
                    textBox1.Focus();
                        break;
                }
            }
        }
    }
