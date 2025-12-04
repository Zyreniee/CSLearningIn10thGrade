using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox6_Click(object sender, EventArgs e)
        {

        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string eleman = Interaction.InputBox("Eklemek İstediğiniz elemanı girin","Veri Girişi","",300,300);
            listBox1.Items.Add(eleman);
        }

        private void textBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string elemantext = Interaction.InputBox("Text Box eklemek istediğiniz elemanı girin", "Veri Girişi", "", 300, 300);
            textBox1.Text = textBox1.Text + elemantext + "\r\n";
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count ==0)
            {
                MessageBox.Show("Liste kutusu zaten boş.");
            }

            else
            {
                DialogResult onayforlist;
                onayforlist = MessageBox.Show("Liste kutusu temizlensinmi ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onayforlist == DialogResult.Yes)
                {
                    listBox1.Items.Clear();
                }
            }
        }

        private void textBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Metin Kutusu Zaten Boş.");
            }
            else
            {
                DialogResult onay;
                onay = MessageBox.Show("Metin kutusu temizlensinmi ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    textBox1.Clear();
                }
            }
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void listBoxunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            listBox1.BackColor = colorDialog1.Color;
        }

        private void metinKutusununToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
        }

        private void formunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("404 Not Found");
        }

        private void temizleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string eleman = Interaction.InputBox("Eklemek İstediğiniz Elemanı Giriniz.", "Veri Girişi", "", 300, 300);
            listBox1.Items.Add(eleman);
        }

        private void renkDeğiştirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            listBox1.BackColor = colorDialog1.Color;
        }

        private void kapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void renkDeğiştirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            this.BackColor = colorDialog1.Color;
        }

        private void kapatToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}