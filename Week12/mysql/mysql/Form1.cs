using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace mysql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //VERİ TABANINA BAĞLAN BUTONU
            MySqlConnection baglan=new MySqlConnection("server=localhost;user=root;password=;database=okul");
            //baglan.ConnectionString = "server=localhost;user=root;password=;database=okul";
            baglan.Open();

            if (baglan.State == ConnectionState.Open)
            {
                MessageBox.Show("Bağlanıldı");
            }
            else
            {
                MessageBox.Show("Bağlantı Hatası");
            }
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //KAYDET BUTONU
            MySqlConnection baglan = new MySqlConnection("server=localhost;user=root;password='';database=okul");
            baglan.Open();
            MySqlCommand kaydet = new MySqlCommand();
            kaydet.CommandText = "insert into ogrenciler values(@okulno,@ad,@soyad,@sinif)";
            kaydet.Connection = baglan;
            kaydet.Parameters.Add("@okulno",int.Parse(textBox1.Text));
            kaydet.Parameters.Add("@ad", textBox2.Text);
            kaydet.Parameters.Add("@soyad", textBox3.Text);
            kaydet.Parameters.Add("@sinif", comboBox1.Text);
            //PARAMETRELER ÖNEMLİ
            if(kaydet.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Kayıt oldu.");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!");
            }
            //0dan büyükse başarılıdır.
            baglan.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Silmek istediğinden emin misin?", "Silme İşlemi", MessageBoxButtons.OKCancel);
            if(cevap == DialogResult.OK)
            {
            MySqlConnection baglan = new MySqlConnection("server=localhost;user=root;password='';database=okul");
            baglan.Open();
            MySqlCommand sil = new MySqlCommand();
            sil.CommandText = "delete from ogrenciler where okulno=@silinecekokulno";
            sil.Connection = baglan;
            sil.Parameters.Add("@silinecekokulno", int.Parse(textBox4.Text));
            if(sil.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Kayit silindi.");
                }
            else
                {
                    MessageBox.Show("Silme işlemi başarısız oldu.");
                }
            baglan.Close();

            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi!.");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //SİL BUTONU
            DialogResult cevap = MessageBox.Show("HERŞEYİNİZİ SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?");
            if (cevap == DialogResult.OK)
            {
                MySqlConnection baglan = new MySqlConnection("server=localhost;user=root;password='';database=okul");
                baglan.Open();
                MySqlCommand sil = new MySqlCommand();
                sil.CommandText = "delete from ogrenciler;";
                sil.Connection = baglan;
                if (sil.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Kayit silindi.");
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız oldu.");
                }
                baglan.Close();

            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi!.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //GÜNCELLE BUTONU
            MySqlConnection baglan = new MySqlConnection("server=localhost;user=root;password='';database=okul");
            baglan.Open();
            MySqlCommand guncelle = new MySqlCommand();
            guncelle.CommandText = "update ogrenciler set ad=@ad, soyad=@soyad, sinif=@sinif where okulno=@okulno";
            guncelle.Connection = baglan;
            guncelle.Parameters.Add("@ad", textBox2.Text);
            guncelle.Parameters.Add("@soyad", textBox3.Text);
            guncelle.Parameters.Add("@sinif", comboBox1.Text);
            guncelle.Parameters.Add("@okulno", textBox1.Text);
            if (guncelle.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Kayit guncellendi.");
            }
            else
            {
                MessageBox.Show("Guncelleme işlemi başarısız oldu.");
            }
            baglan.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //OKULNO GÜNCELLE BUTONU
            MySqlConnection baglan = new MySqlConnection("server=localhost;user=root;password='';database=okul");
            baglan.Open();
            MySqlCommand noguncelle = new MySqlCommand();
            noguncelle.CommandText = "update ogrenciler set okulno=@yeniokulno,ad=@ad,soyad=@soyad,sinif=@sinif where okulno=@eskiokulno;";
            noguncelle.Connection = baglan;
            noguncelle.Parameters.Add("@ad", textBox2.Text);
            noguncelle.Parameters.Add("@soyad", textBox3.Text);
            noguncelle.Parameters.Add("@sinif", comboBox1.Text);
            noguncelle.Parameters.Add("@yeniokulno", textBox1.Text);
            noguncelle.Parameters.Add("@eskiokulno", textBox5.Text);
            if (noguncelle.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Kayit guncellendi.");
            }
            else
            {
                MessageBox.Show("Guncelleme işlemi başarısız oldu.");
            }
            baglan.Close();

        }
    }
}
