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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(Interaction.InputBox("İlk Sayıyı Giriniz", "Sayı Bilgi Sistemi", "", 500, 500));
            int sayi2 = Convert.ToInt32(Interaction.InputBox("İkinci Sayıyı Giriniz", "Sayı Bilgi Sistemi", "", 500, 500));
            string islem = Interaction.InputBox("İşlemi Giriniz", "Sayı Bilgi Sistemi", "", 500, 500);
            int toplam;
         switch (islem)
            {
                case "+":toplam = sayi1 + sayi2;label2.Text = toplam.ToString();break;

                case "-": toplam = sayi1 - sayi2; label2.Text = toplam.ToString(); break;

                case "*": toplam = sayi1 * sayi2; label2.Text = toplam.ToString(); break;

                case "/": toplam = sayi1 / sayi2; label2.Text = toplam.ToString(); break;


                default:
                    MessageBox.Show("You decided wrong!");
                    break;
            }
            

        }
    }
}
