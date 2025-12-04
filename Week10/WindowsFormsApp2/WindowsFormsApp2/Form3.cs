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
    public partial class Form3 : Form
    {
        public float totalfiyat , kdvversion ,cocukindirimi;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalfiyat = Convert.ToInt32(comboBox1.Text) * Convert.ToInt32(comboBox2.Text) *1000;
            float cocukindirimi = (totalfiyat * 10) / 100;
            float kdvversion = (totalfiyat * 15) / 100;
            float kdvvecocukindirimi = (totalfiyat * 5) / 100;


            if (checkBox1.Checked)
            {
                totalfiyat = totalfiyat + kdvversion;
                textBox1.Text = totalfiyat.ToString();
                label7.Text = Convert.ToString(totalfiyat-kdvversion);
                label8.Text = "";
                label9.Text = kdvversion.ToString();
            }
            if (checkBox1.Checked && radioButton1.Checked)
            {
                totalfiyat = totalfiyat + kdvvecocukindirimi;
                textBox1.Text = totalfiyat.ToString();
                label7.Text = Convert.ToString(totalfiyat - kdvvecocukindirimi);
                label8.Text = cocukindirimi.ToString();
                label9.Text = kdvversion.ToString();
            }
            if (checkBox1.Checked && radioButton2.Checked)
            {
                totalfiyat = totalfiyat + kdvversion;
                textBox1.Text = totalfiyat.ToString();
                label7.Text = Convert.ToString(totalfiyat - kdvversion);
                label8.Text = "";
                label9.Text = kdvversion.ToString();

            }
            if (!checkBox1.Checked &&radioButton1.Checked)
            {
                totalfiyat = totalfiyat - cocukindirimi;
                textBox1.Text = totalfiyat.ToString();
                label7.Text = Convert.ToString(totalfiyat+cocukindirimi);
                label8.Text = cocukindirimi.ToString();
                label9.Text = "";


            }
            if (radioButton2.Checked)
            {
                textBox1.Text = totalfiyat.ToString();
                label7.Text = totalfiyat.ToString();
                label8.Text = "";

            }
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                comboBox1.Items.Add(i);
                comboBox2.Items.Add(i);
            }
        }
    }
}
