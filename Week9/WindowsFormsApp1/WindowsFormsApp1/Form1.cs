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
    
    public partial class Form1 : Form
    {
        public string dersadi;
        public string dersad;
        public int sira;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = listBox2.Items.Count.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dersadi = textBox1.Text;
            listBox1.Items.Add(dersadi);
            int derssayisi =Convert.ToInt32(listBox1.Items.Count);
            label3.Text = derssayisi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object secilen =listBox1.SelectedItems;
            listBox1.Items.Remove(secilen);
            int derssayisi = Convert.ToInt32(listBox1.Items.Count);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int derssayisi = Convert.ToInt32(listBox1.Items.Count);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dersad = textBox2.Text;
            sira = Convert.ToInt32(textBox3.Text);
            listBox1.Items.Insert(sira-1, dersad);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int elemansayisi = listBox1.Items.Count;

            for (int i = 0; i < elemansayisi; i++)
            {
                listBox2.Items.Add(listBox1.Items[i].ToString());
            }
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string secilen = listBox1.Text;
            listBox2.Items.Add(secilen);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            label7.Text = listBox2.Items.Count.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int secilielemansayisi = listBox1.SelectedItems.Count;
            //MessageBox.Show(secilielemansayisi.ToString());
            for (int i = 0; i < secilielemansayisi; i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
            }

            while (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}
