using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lcs
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Application Quit

        private void button1_Click_1(object sender, EventArgs e)
        {
        
            MessageBox.Show("Hello Lcs!");
        }
        //Mesaj kutusu
    }
      
}
