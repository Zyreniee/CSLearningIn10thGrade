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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Form2.dogrusayisi = Form2.dogrusayisi+1;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                label3.Text = "DOĞRU!";


            }

            else if (radioButton2.Checked == true)
            {
                Form2.yanlissayisi = Form2.yanlissayisi+1;
                radioButton1.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                label3.Text = "YANLIŞ!";

            }

            else if (radioButton3.Checked == true)
            {
                Form2.yanlissayisi = Form2.yanlissayisi+1;
                radioButton2.Enabled = false;
                radioButton1.Enabled = false;
                radioButton4.Enabled = false;
                label3.Text = "YANLIŞ!";

            }

            else if (radioButton4.Checked == true)
            {
                Form2.yanlissayisi = Form2.yanlissayisi+1;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                label3.Text = "YANLIŞ!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
