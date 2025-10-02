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
        DialogResult cevap;
        public static int sayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           cevap = MessageBox.Show("Kapatmak İstiyormusun?", "Uyarı!",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(cevap == DialogResult.Yes )
            {
                Application.Exit();
            }
            else
            {
             MessageBox.Show("İşlem iptal edildi" , null ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Focus();
            }
        }
    }
}
