using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         if (comboBox1.Text == "1-100 ARASI")
            {
                for(int i = 0; i <= 100; i++)
                {
                    listBox1.Items.Add(i);
                }
            }
         else if(comboBox1.Text == "1-100 ARASI TEK")
            {
                for (int i = 0; i <= 100; i=i+2)
                {
                    listBox1.Items.Add(i);
                }
            }
         else if(comboBox1.Text == "1-100 ARASI ÇİFT")
            {
                for (int i=2;i<=100; i = i + 2)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
