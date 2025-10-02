using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(this.Opacity == 0)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
                timer1.Stop();
            }
            else
            {
                this.Opacity = this.Opacity - 0.100;
            }
        }
    }
}
