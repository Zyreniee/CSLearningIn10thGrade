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
    public partial class Form2 : Form
    {
        public string takimadi;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            takimadi = textBox1.Text;
            if (!listBox1.Items.Contains(takimadi))
            {
                listBox1.Items.Add(takimadi);

            }
            else if (listBox1.Items.Contains(takimadi))
            {
               DialogResult result =MessageBox.Show("Bu değer listbox'ta var , eklemek istediğinize eminmisiniz?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    listBox1.Items.Add(takimadi);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sonuc;
            sonuc = listBox1.FindStringExact(textBox2.Text);

            if (sonuc < 0)
            {
                MessageBox.Show("Aranan Bulunamadı");
            }
            else
            {
                listBox1.SelectedIndex = sonuc;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            listBox1.BackColor = colorDialog1.Color;
            textBox1.BackColor = colorDialog1.Color;
            textBox2.BackColor = colorDialog1.Color;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sonuc;
            sonuc = listBox1.FindStringExact(textBox2.Text,listBox1.SelectedIndex);

            if (sonuc < 0)
            {
                MessageBox.Show("Aranan Bulunamadı");
            }
            else
            {
                if(sonuc < listBox1.SelectedIndex)
                {
                    MessageBox.Show("Aranan kayıttan başka yok");
                }
                else
                {
                    listBox1.SelectedIndex = sonuc;

                }
            }
        }
    }
}
