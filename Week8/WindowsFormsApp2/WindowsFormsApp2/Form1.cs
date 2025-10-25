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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
            listBox2.Items.Add(listBox1.SelectedItem.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Sakarya");
            listBox1.Items.Add("Ankara");
            listBox1.Items.Add("Istanbul");
            listBox1.Items.Add("Eskişehir");
            listBox1.Items.Add("Hakkari");
            listBox1.Items.Add("Adana");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}
