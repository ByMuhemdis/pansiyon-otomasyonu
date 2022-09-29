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
    public partial class frmgelirgider : Form
    {
        public frmgelirgider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-02O23ES;Initial Catalog=papatyapansiyon;Integrated Security=True");
        private void btnhesapla_Click(object sender, EventArgs e)
        {


            //personel maaslarını hesaplatma kısmı dpersonel sayısıyını girince otomatık toplam tutar belirleniyor

            int personel;
           
            personel = Convert.ToInt16(txtpersonel.Text);
            lblpersmaas.Text = (personel * 5500).ToString();

            //toplam sonucun hesaplanım kasaya yansıması

            int sonuc;
            sonuc = Convert.ToInt32(lblkasatutar.Text) - (Convert.ToInt32(lblpersmaas.Text) + Convert.ToInt32(lblurunler.Text) + Convert.ToInt32(lblfatura.Text));
            lbltoplam.Text=sonuc.ToString();
        }

        private void frmgelirgider_Load(object sender, EventArgs e)
        {

            //burada müşterilerden alınan ucretlerin toplamını yaoptık
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(ucret) as toplam from Musteriekle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblkasatutar.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            //gıda için harcanan para 

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select sum(gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                gıda.Text = oku1["toplam1"].ToString();
            }
            baglanti.Close();

            //içeçeklerin toplam tutarının hesaplanması
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(icecek) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                icecek.Text = oku2["toplam2"].ToString();
            }
            baglanti.Close();


            //atıstırmalıkların toplam tutarının hesaplanması

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(cerezler) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                atıstırma.Text = oku3["toplam3"].ToString();
            }
            baglanti.Close();
            int a, b, c;

            a = Convert.ToInt32(gıda.Text);
            b = Convert.ToInt32(icecek.Text);
            c = Convert.ToInt32(atıstırma.Text);

            lblurunler.Text = (a + b + c).ToString();

            //---------------------

            ///Faturaların toplamının hesaplanmaso
            ///  Elektirik, Su, Internet,Dogalgaz

            ///Elektrik faturası
            ///

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Elektirik) as toplam4 from Faturalar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                elektirik.Text = oku4["toplam4"].ToString();
            }
            baglanti.Close();

            //Su faturası

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Su) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                su.Text = oku5["toplam5"].ToString();
            }
            baglanti.Close();

            //İnternet faturası

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(Su) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                internet.Text = oku6["toplam6"].ToString();
            }
            baglanti.Close();

            //Dogalgaz Faturası

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select sum(Su) as toplam7 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                dogalgaz.Text = oku7["toplam7"].ToString();
            }
            baglanti.Close();

            int  s,k, i,d;

          
            s = Convert.ToInt32(su.Text);
            k = Convert.ToInt32(elektirik.Text);
            i = Convert.ToInt32(internet.Text);
            d = Convert.ToInt32(dogalgaz.Text);

            lblfatura.Text = (k + s + i + d).ToString();


        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {

            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Hide();
        }
    }
}
