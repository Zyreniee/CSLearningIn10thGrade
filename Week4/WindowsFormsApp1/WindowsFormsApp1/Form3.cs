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
        float sayi1, sayi2,sonuc;
        string isaret;
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            isaret = comboBox1.Text;

            switch (isaret)
            {
                case "+" :
                    sonuc = sayi1 + sayi2;
                label5.Text = sonuc.ToString();
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    label5.Text = sonuc.ToString();
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    label5.Text = sonuc.ToString();
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    label5.Text = sonuc.ToString();
                    break;
                default:
                    MessageBox.Show("Please use the combo box for calculator.");
                    break;
            }
        }
    }
}