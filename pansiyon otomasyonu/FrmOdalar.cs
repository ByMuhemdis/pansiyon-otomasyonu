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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-02O23ES;Initial Catalog=papatyapansiyon;Integrated Security=True");
        private void FrmOdalar_Load(object sender, EventArgs e)
        {

            //oda 101

            
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from oda101", baglanti);
            SqlDataReader oku1 =komut1.ExecuteReader();

            while (oku1.Read())
            {
                btnoda101.Text = oku1[0].ToString() +" "+ oku1[1].ToString();

            }
            if (btnoda101.Text != "101")
            {
                btnoda101.BackColor = Color.Red;
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
            }

            baglanti.Close();

           

          
        }

        private void btnoda101_Click(object sender, EventArgs e)
        {

        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr =new FrmAnaForm();
            fr.Show();
            this.Hide();
        }
    }
}
