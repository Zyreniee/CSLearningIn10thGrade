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
        public string comboBoxtexti;
        float birinciislem, ikinciislem, sonuc;
        string isaret;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "TOPLA":textBox3.Text = "+";break;
                case "ÇIKAR": textBox3.Text = "-"; break;
                case "ÇARP": textBox3.Text = "*"; break;
                case "BÖL": textBox3.Text = "/"; break;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for(int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    listBox1.Items.Add(i);
                }
            }
            int j=0;
            while(j <= 100)
            {
             if(j % 2 == 0)
                {
                    listBox2.Items.Add(j);
                }

                j++;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string listBoxitemi = listBox1.SelectedItem.ToString();
            textBox4.Text = listBoxitemi;

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            listBox1.BackColor = colorDialog1.Color;
            listBox2.BackColor = colorDialog1.Color;
            listBox3.BackColor = colorDialog1.Color;
            textBox4.BackColor = colorDialog1.Color;
            textBox3.BackColor = colorDialog1.Color;
            textBox2.BackColor = colorDialog1.Color;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string listBoxitemi = listBox2.SelectedItem.ToString();
            textBox2.Text = listBoxitemi;
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            birinciislem = Convert.ToInt32(textBox4.Text);
            ikinciislem=Convert.ToInt32(textBox2.Text);
            isaret = textBox3.Text;

            switch (isaret) 
            {
                case "+": sonuc = birinciislem + ikinciislem;break;
                case "-": sonuc = birinciislem - ikinciislem; break;
                case "*": sonuc = birinciislem * ikinciislem; break;
                case "/": sonuc = birinciislem / ikinciislem; break;
            }
            MessageBox.Show("Sonuç = " + sonuc);
            listBox3.Items.Add(birinciislem + isaret.ToString() + ikinciislem + "=" + sonuc);
            label6.Text = listBox3.Items.Count.ToString();
        }
    }
}
