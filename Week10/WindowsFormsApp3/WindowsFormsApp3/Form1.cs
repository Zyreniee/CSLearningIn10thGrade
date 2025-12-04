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
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1ToolStripMenuItem.Checked == true)
            {
                listBox1.BackColor = Color.Yellow;
            }

            else
            {
                listBox1.BackColor = Color.White;
            }
        }

        private void listBox2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox2ToolStripMenuItem.Checked == true)
            {
                listBox2.BackColor = Color.Yellow;
            }

            else
            {
                listBox2.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            int toplam = 0;

            for (int i = 0; i <listBox1.Items.Count; i++)
            {
                int sayi = Convert.ToInt32(listBox1.Items[i].ToString());
                toplam =toplam+sayi;
            }
            label4.Text = toplam.ToString();                                                                         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
            int toplam = 0;

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                int sayi = Convert.ToInt32(listBox2.Items[i].ToString());
                toplam = toplam + sayi;
            }
            label5.Text = toplam.ToString();
        }
    }
}
