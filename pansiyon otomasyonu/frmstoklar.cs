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
    public partial class frmstoklar : Form
    {
        public frmstoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-02O23ES;Initial Catalog=papatyapansiyon;Integrated Security=True");

        public void veriler()
        {

            //baglanti.Open();
            //SqlCommand komut = new SqlCommand("select * from Stoklar", baglanti);
            //SqlDataReader oku = komut.ExecuteReader();
            //while (oku.Read())
            //{

            //}
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar ", baglanti);
            SqlDataAdapter bul = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            bul.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        public void veriler2()
        {

            //baglanti.Open();
            //SqlCommand komut = new SqlCommand("select * from Stoklar", baglanti);
            //SqlDataReader oku = komut.ExecuteReader();
            //while (oku.Read())
            //{

            //}

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Faturalar ", baglanti);
            SqlDataAdapter bul1 = new SqlDataAdapter(komut1);
            DataSet ds1 = new DataSet();
            bul1.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];
            baglanti.Close();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into Stoklar (gida, icecek, cerezler) values (@k1,@k2,@k3)", baglanti);
            ekle.Parameters.AddWithValue("@k1", txtgıdatutar.Text);
            ekle.Parameters.AddWithValue("@k2", txticecektutar.Text);
            ekle.Parameters.AddWithValue("@k3", txtatıstırmatutar.Text);
           
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("veriler başarıya eklendi. ");
            txtgıdatutar.Text = null;
            txticecektutar.Text = null;
            txtatıstırmatutar.Text = null;
            veriler();
           
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Hide();
        }

        private void frmstoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //fatura giriş ekle kısmı

            if (txtelktrik.Text == null && txtsu.Text == null && txtinternet.Text == null && txtdogalgaz.Text == null)
            {
                MessageBox.Show("veri kısmı boşken ekleme yapılmaz. ");
            }
            else
            {
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into Faturalar (Elektirik, Su, Internet,Dogalgaz) values (@k1,@k2,@k3,@k4)", baglanti);
                ekle.Parameters.AddWithValue("@k1", txtelktrik.Text);
                ekle.Parameters.AddWithValue("@k2", txtsu.Text);
                ekle.Parameters.AddWithValue("@k3", txtinternet.Text);
                ekle.Parameters.AddWithValue("@k4", txtdogalgaz.Text);

                ekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("veriler başarıya eklendi. ");
            }
           
            txtelktrik.Text = null;
            txtsu.Text = null;
            txtinternet.Text = null;
            txtdogalgaz.Text = null;
            veriler2();
        }
    }
}
