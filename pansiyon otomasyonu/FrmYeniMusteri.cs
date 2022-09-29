using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace pansiyon_otomasyonu
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-02O23ES;Initial Catalog=papatyapansiyon;Integrated Security=True");
        private void btnoda101_Click(object sender, EventArgs e)
        {
            txtodano.Text = "101";
            if (txtad.Text==""&&  txtucret.Text=="")
            {
                MessageBox.Show("Boş alanları doldurunuz  ve en son odayı Seciniz!!! ");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into oda101 (ad, soyad) values ( '" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
          
            
        }

        private void btnoda102_Click(object sender, EventArgs e)
        {
            txtodano.Text = "102";
            if (txtad.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz ve en son odayı Seciniz!!! ");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into oda102 (ad, soyad) values ( '" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
           
          
        }

        private void btnoda103_Click(object sender, EventArgs e)
        {
            txtodano.Text = "103";
            if (txtad.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz ve en son odayı Seciniz!!! ");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into oda103 (ad, soyad) values ( '" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
           
        
        }

        private void btnoda104_Click(object sender, EventArgs e)
        {
            txtodano.Text = "104";
            if (txtad.Text == "" )
            {
                MessageBox.Show("Boş alanları doldurunuz ve en son odayı Seciniz!!!");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into oda104 (ad, soyad) values ( '" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            
            
        }

        private void btnoda105_Click(object sender, EventArgs e)
        {
            txtodano.Text = "105";
            if (txtad.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz ve en son odayı Seciniz!!!");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into oda105 (ad, soyad) values ( '" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
          
           
        }

        private void btnoda106_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz ve en son odayı Seciniz!!!");
            }
            else
            {
                txtodano.Text = "106";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into oda106 (ad, soyad) values ( '" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
          
        }

        private void btnoda107_Click(object sender, EventArgs e)
        {
            txtodano.Text = "107";

            if (txtad.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz ve en son odayı Seciniz!!!");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into oda107 (ad, soyad) values ( '" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
           
        }

        private void btnoda108_Click(object sender, EventArgs e)
        {
            txtodano.Text = "108";
            if (txtad.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz ve en son odayı Seciniz!!!");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into oda108 (ad, soyad) values ( '" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            
        }

        private void btnoda109_Click(object sender, EventArgs e)
        {
            txtodano.Text = "109";
            if (txtad.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz ve en son odayı Seciniz!!!");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into oda109 (ad, soyad) values ( '" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
         
        }

        private void btndoluoda_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Kırmızı renkli butonlar dolu odaları gösterir");
        }

        private void btnbosoada_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odaları gösterir");
        }

        private void dtpcıkıs_ValueChanged(object sender, EventArgs e)
        {
            //çıkıs tarihi belirlendigi zaman ucret kısmına hesaplanan ucretin yazılması için gereken işlemler 

            int ucret;
            DateTime kucuktarih = Convert.ToDateTime(dtpgiris.Text);
            DateTime buyuktarih = Convert.ToDateTime(dtpcıkıs.Text);

            //TimeSpan = arakadi farkı alır gun farkı saat farkı gibi farkların alırken kullanılır

            TimeSpan sonuc;

            sonuc = buyuktarih - kucuktarih;
            label11.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * 50;
            txtucret.Text = ucret.ToString();
            txtucret.Enabled = true;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Musteriekle (Ad,Soyad,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,Giristarihi,cıkıstarihi) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);
            komut.Parameters.AddWithValue("@p1",txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbcinsiyet.Text);
            komut.Parameters.AddWithValue("@p4", maskmaktxttel.Text);
            komut.Parameters.AddWithValue("@p5", txtmail.Text);
            komut.Parameters.AddWithValue("@p6", msktxttc.Text);
            komut.Parameters.AddWithValue("@p7", txtodano.Text);
            komut.Parameters.AddWithValue("@p8", txtucret.Text);
            komut.Parameters.AddWithValue("@p9", dtpgiris.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@p10", dtpcıkıs.Value.ToString("yyyy-MM-dd"));
            komut.ExecuteNonQuery();//gönderilen parametreler uzzerinde degişiklik yapmamıza yarar parametre=gönderdigimiz veriler
            baglanti.Close();
            MessageBox.Show("Müşteri basarıyla kaydedilmiştir!!!");

            txtad.Text="";
            txtsoyad.Text="";
            cmbcinsiyet.Text="";
            maskmaktxttel.Text="";
            txtmail.Text="";
            msktxttc.Text="";
            txtodano.Text="";
            txtucret.Text = "";
            dtpgiris.Text = "";
            dtpcıkıs.Text = "";






        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {

            //oda 101
            txtucret.Enabled=false;

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                btnoda101.Text = oku1[0].ToString() + " " + oku1[1].ToString();

            }
            if (btnoda101.Text != "101")
            {
                btnoda101.BackColor = Color.Red;
                btnoda101.Enabled = false;
            }

            baglanti.Close();

            //oda 102

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                btnoda102.Text = oku2[0].ToString() + " " + oku2[1].ToString();

            }
            if (btnoda102.Text != "102")
            {
                btnoda102.BackColor = Color.Red;
                btnoda102.Enabled = false;
            }

            baglanti.Close();

            //oda 103

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                btnoda103.Text = oku3[0].ToString() + " " + oku3[1].ToString();

            }
            if (btnoda103.Text != "103")
            {
                btnoda103.BackColor = Color.Red;
                btnoda103.Enabled = false;
            }

            baglanti.Close();

            //oda 104

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                btnoda104.Text = oku4[0].ToString() + " " + oku4[1].ToString();

            }
            if (btnoda104.Text != "104")
            {
                btnoda104.BackColor = Color.Red;
                btnoda104.Enabled = false;
            }

            baglanti.Close();

            //oda 105

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                btnoda105.Text = oku5[0].ToString() + " " + oku5[1].ToString();

            }
            if (btnoda105.Text != "105")
            {
                btnoda105.BackColor = Color.Red;
                btnoda105.Enabled = false;
            }

            baglanti.Close();

            // oda 106

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                btnoda106.Text = oku6[0].ToString() + " " + oku6[1].ToString();

            }
            if (btnoda106.Text != "106")
            {
                btnoda106.BackColor = Color.Red;
                btnoda106.Enabled = false;
            }

            baglanti.Close();

            //oda 107 

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                btnoda107.Text = oku7[0].ToString() + " " + oku7[1].ToString();

            }
            if (btnoda107.Text != "107")
            {
                btnoda107.BackColor = Color.Red;
                btnoda107.Enabled = false;
            }

            baglanti.Close();


            //oda 108

            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                btnoda108.Text = oku8[0].ToString() + " " + oku8[1].ToString();

            }
            if (btnoda108.Text != "108")
            {
                btnoda108.BackColor = Color.Red;
                btnoda108.Enabled = false;
            }

            baglanti.Close();

            //oda 109

            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                btnoda109.Text = oku9[0].ToString() + " " + oku9[1].ToString();

            }
            if (btnoda109.Text != "109")
            {
                btnoda109.BackColor = Color.Red;
                btnoda109.Enabled = false;
            }

            baglanti.Close();

        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Hide();
        }
    }
}

//Data Source=DESKTOP-02O23ES;Initial Catalog=papatyapansiyon;Integrated Security=True