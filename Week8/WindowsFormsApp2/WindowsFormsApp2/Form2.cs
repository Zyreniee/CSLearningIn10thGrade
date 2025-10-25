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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);

            int elemansayisi = listBox1.Items.Count;
            label5.Text = elemansayisi.ToString();
            textBox3.Clear();
            textBox3.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {                                                                                                                                                                                                                     
            int siraNo = Convert.ToInt32(textBox1.Text);
            string eleman = textBox2.Text;

            listBox1.Items.Insert(siraNo-1, eleman);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Text);
            int elemansayisi = listBox1.Items.Count;
            label5.Text = elemansayisi.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int siraNo = int.Parse(textBox4.Text);
            listBox1.Items.RemoveAt(siraNo-1);

            int elemansayisi = listBox1.Items.Count;
            label5.Text = elemansayisi.ToString();
        }
    }
}
