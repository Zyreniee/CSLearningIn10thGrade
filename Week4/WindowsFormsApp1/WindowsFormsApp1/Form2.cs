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
    public partial class Form2 : Form
    {
        string degisken;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            degisken = comboBox1.Text;

            switch (degisken)
            {
                case "RED":
                    this.BackColor = Color.Red;

                    MessageBox.Show(comboBox1.Text);
                    break;

                case "GREEN":
                    this.BackColor = Color.Green;

                    MessageBox.Show(comboBox1.Text);
                    break;

                case "WHİTE":
                    this.BackColor = Color.White;

                    MessageBox.Show(comboBox1.Text);

                    break;

                case "BLUE":
                    this.BackColor = Color.Blue;

                    MessageBox.Show(comboBox1.Text);

                    break;

                case "YELLOW":
                    this.BackColor = Color.Yellow;

                    MessageBox.Show(comboBox1.Text);

                    break;

                default:
                    MessageBox.Show("PLEASE CHOOSE ANY COLOR NAME IN"+ " "+ comboBox1.Name);
                    break;
                case "BLACK":
                    this.BackColor = Color.Black;
                    MessageBox.Show(comboBox1.Text);
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
         colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }
    }
}
