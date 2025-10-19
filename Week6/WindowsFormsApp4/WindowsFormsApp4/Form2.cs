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
    public partial class Form2 : Form
    {
        public static int dogrusayisi=0, yanlissayisi=0;
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                yanlissayisi = 1;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                label3.Text = "YANLIŞ!";


            }

            else if(radioButton2.Checked == true)
            {
                dogrusayisi = 1;
                radioButton1.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                label3.Text = "DOĞRU!";

            }

            else if(radioButton3.Checked == true)
            {
                yanlissayisi = 1;
                radioButton2.Enabled = false;
                radioButton1.Enabled = false;
                radioButton4.Enabled = false;
                label3.Text = "YANLIŞ!";

            }

            else if(radioButton4.Checked == true)
            {
                yanlissayisi = 1;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                label3.Text = "YANLIŞ!";

            }
        }
    }
}
