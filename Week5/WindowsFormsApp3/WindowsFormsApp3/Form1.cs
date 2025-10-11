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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        DialogResult result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Visible = true;
            label3.Visible = true;
            listBox1.Visible = false;
            listBox4.Visible = false;
            listBox3.Visible = false;
            label2.Visible=false;
            label4.Visible = false;
            label5.Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Visible = true;
            label4.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            listBox2.Visible = false;
            listBox4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox4.Visible = true;
            label5.Visible =true;
            label2.Visible = false;
            label3.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;
            label4.Visible = false;
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            string corbaadi = Interaction.InputBox("Eklemek istediğiniz çorba adı", "Çorba Ekle", "", 500, 500);
            result = MessageBox.Show(corbaadi +"Eklemek İstiyormusunuz?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                listBox1.Items.Add(corbaadi);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string pilavadi = Interaction.InputBox("Eklemek istediğiniz pilav adı", "Pilav Ekle", "", 500, 500);
            result = MessageBox.Show(pilavadi + "Eklemek İstiyormusunuz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                listBox2.Items.Add(pilavadi);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string icecekadi = Interaction.InputBox("Eklemek istediğiniz İçecek adı", "İçecek Ekle", "", 500, 500);
            result = MessageBox.Show(icecekadi + "Eklemek İstiyormusunuz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                listBox3.Items.Add(icecekadi);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string tatliadi = Interaction.InputBox("Eklemek istediğiniz Tatlı adı", "Tatlı Ekle", "", 500, 500);
            result = MessageBox.Show(tatliadi + "Eklemek İstiyormusunuz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                listBox4.Items.Add(tatliadi);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox2.Visible = true;
            listBox3.Visible = true;
            listBox4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string temizleme = Interaction.InputBox("Hangi Kategoriyi Temizlemek İstersiniz", "Menü Silme", "", 500, 500);
            switch (temizleme)
            {
                case "Çorbalar":listBox1.Items.Clear();break;
                case "Pilavlar": listBox1.Items.Clear(); break;
                case "İçecekler": listBox1.Items.Clear(); break;
                case "Tatlılar": listBox1.Items.Clear(); break;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string renksecimi = Interaction.InputBox("Hangi Menünün Rengini Değiştirmek İstersiniz?", "Renk Değiştirme", "", 500, 500);
            switch (renksecimi)
            {
                case "Çorbalar":colorDialog1.ShowDialog();listBox1.BackColor = colorDialog1.Color;break;
                case "Pilavlar": colorDialog1.ShowDialog(); listBox2.BackColor = colorDialog1.Color; break;
                case "İçecekler": colorDialog1.ShowDialog(); listBox3.BackColor = colorDialog1.Color; break;
                case "Tatlılar": colorDialog1.ShowDialog(); listBox4.BackColor = colorDialog1.Color; break;

            }
        }
    }
}