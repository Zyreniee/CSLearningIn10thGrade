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
    public partial class Form1 : Form
    {
        int sayac = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            label1.Text = sayac.ToString();

            if (sayac == 0)
            {
                timer1.Stop();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Hide();

            }
        }
    }
}
