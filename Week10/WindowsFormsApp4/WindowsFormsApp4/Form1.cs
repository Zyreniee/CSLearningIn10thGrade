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
    public partial class Form1 : Form
    {
        public decimal oynananSaat,urunFiyati,hesap,ucret;
        public string masa,urun;

        public Form1()
        {
            InitializeComponent();
        }

        private void masa1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Add("Simit");
            comboBox4.Items.Add("Tost");
            comboBox4.Items.Add("Hamburger");

            if (radioButton2.Checked)
            {
                comboBox4.Items.Clear();

                comboBox4.Items.Add("Kola");
                comboBox4.Items.Add("Ayran");
                comboBox4.Items.Add("Meyve Suyu");
                comboBox4.Items.Add("Çay");
            }
            else if (radioButton1.Checked)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Simit");
                comboBox4.Items.Add("Tost");
                comboBox4.Items.Add("Hamburger");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   


        private void masa1ToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            if (masa1ToolStripMenuItem.Checked)
            {
                listBox1.BackColor = Color.White;
            }
            else if (!masa1ToolStripMenuItem.Checked)
            {
                listBox1.BackColor = Color.IndianRed;
            }
        }

        private void masa1ToolStripMenuItem1_CheckStateChanged(object sender, EventArgs e)
        {
            if (masa1ToolStripMenuItem1.Checked)
            {
                listBox2.BackColor = Color.White;
            }
            else if (!masa1ToolStripMenuItem.Checked)
            {
                listBox2.BackColor = Color.IndianRed;
            }
        }

        private void masa1ToolStripMenuItem2_CheckStateChanged(object sender, EventArgs e)
        {
            if (masa1ToolStripMenuItem2.Checked)
            {
                listBox3.BackColor = Color.White;
            }
            else if (!masa1ToolStripMenuItem.Checked)
            {
                listBox3.BackColor = Color.IndianRed;
            }
        }

        private void masa1ToolStripMenuItem3_CheckStateChanged(object sender, EventArgs e)
        {
            if (masa1ToolStripMenuItem3.Checked)
            {
                listBox4.BackColor = Color.White;
            }
            else if (!masa1ToolStripMenuItem.Checked)
            {
                listBox4.BackColor = Color.IndianRed;
            }
        }

        private void masa1ToolStripMenuItem4_CheckStateChanged(object sender, EventArgs e)
        {
            if (masa1ToolStripMenuItem4.Checked)
            {
                listBox5.BackColor = Color.White;
            }
            else if (!masa1ToolStripMenuItem.Checked)
            {
                listBox5.BackColor = Color.IndianRed;
            }
        }

        private void masa1ToolStripMenuItem5_CheckStateChanged(object sender, EventArgs e)
        {
            if (masa1ToolStripMenuItem5.Checked)
            {
                listBox6.BackColor = Color.White;
            }
            else if (!masa1ToolStripMenuItem.Checked)
            {
                listBox6.BackColor = Color.IndianRed;
            }
        }

        private void masa1ToolStripMenuItem6_CheckStateChanged(object sender, EventArgs e)
        {
            if (masa1ToolStripMenuItem6.Checked)
            {
                listBox7.BackColor = Color.White;
            }
            else if (!masa1ToolStripMenuItem.Checked)
            {
                listBox7.BackColor = Color.IndianRed;
            }
        }

        private void masa1ToolStripMenuItem7_CheckStateChanged(object sender, EventArgs e)
        {
            if (masa1ToolStripMenuItem7.Checked)
            {
                listBox8.BackColor = Color.White;
            }
            else if (!masa1ToolStripMenuItem.Checked)
            {
                listBox8.BackColor = Color.IndianRed;
            }
        }

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItems);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItems);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox3.Items.Remove(listBox3.SelectedItems);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox4.Items.Remove(listBox4.SelectedItems);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox5.Items.Remove(listBox5.SelectedItems);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox6.Items.Remove(listBox6.SelectedItems);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            listBox7.Items.Remove(listBox7.SelectedItems);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            listBox8.Items.Remove(listBox8.SelectedItems);

        }

        private void masa8ToolStripMenuItem1_CheckStateChanged(object sender, EventArgs e)
        {
          
        }

        private void masa8ToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            if (masa8ToolStripMenuItem.Checked)
            {
                listBox8.BackColor = Color.White;
            }
            else if (!masa8ToolStripMenuItem.Checked)
            {
                listBox8.BackColor = Color.IndianRed;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            urun = comboBox4.Text;

            switch (urun)
            {
                case "Simit": urunFiyati = 0.5m;ucret = Convert.ToDecimal(textBox2.Text) * urunFiyati;textBox3.Text = ucret.ToString(); ; break;
                case "Tost": urunFiyati = 1m; ucret = Convert.ToDecimal(textBox2.Text) * urunFiyati; textBox3.Text = ucret.ToString(); break;
                case "Hamburger": urunFiyati = 3m; ucret = Convert.ToDecimal(textBox2.Text) * urunFiyati; textBox3.Text = ucret.ToString(); break;
                case "Kola": urunFiyati = 2m; ucret = Convert.ToDecimal(textBox2.Text) * urunFiyati; textBox3.Text = ucret.ToString(); break;
                case "Ayran": urunFiyati = 1m; ucret = Convert.ToDecimal(textBox2.Text) * urunFiyati; textBox3.Text = ucret.ToString(); break;
                case "Meyve Suyu": urunFiyati = 2m; ucret = Convert.ToDecimal(textBox2.Text) * urunFiyati; textBox3.Text = ucret.ToString(); break;
                case "Çay": urunFiyati = 0.5m; ucret = Convert.ToDecimal(textBox2.Text) * urunFiyati; textBox3.Text = ucret.ToString(); break;
            }

            switch (masa)
            {
                case "1":listBox1.Items.Add(ucret);break;
                case "2": listBox2.Items.Add(ucret); break;
                case "3": listBox3.Items.Add(ucret); break;
                case "4": listBox4.Items.Add(ucret); break;
                case "5": listBox5.Items.Add(ucret); break;
                case "6": listBox6.Items.Add(ucret); break;
                case "7": listBox7.Items.Add(ucret); break;
                case "8": listBox8.Items.Add(ucret); break;         
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hesap =(Convert.ToDecimal(comboBox2.Text))*1;
            textBox1.Text = hesap.ToString();
            masa = comboBox1.Text;

            switch (masa)
            {
                case "1": listBox1.Items.Add(hesap); break;
                case "2": listBox2.Items.Add(hesap); break;
                case "3": listBox3.Items.Add(hesap); break;
                case "4": listBox4.Items.Add(hesap); break;
                case "5": listBox5.Items.Add(hesap); break;
                case "6": listBox6.Items.Add(hesap); break;
                case "7": listBox7.Items.Add(hesap); break;
                case "8": listBox8.Items.Add(hesap); break;
            }
        }
    }
}
