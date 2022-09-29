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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-02O23ES;Initial Catalog=papatyapansiyon;Integrated Security=True");

        //erişğim belirleyici belirleyelim 
        // erişim belileyici nedir ;== bir durumun yazılan kod parcacıgının faqrklı yerlerdede kullanılmasını istiyorsak bunun için eriişim belirleyici kullanmalıyız

        private void verilerigetir()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut =new SqlCommand("select * from Musteriekle",baglanti);
            SqlDataReader oku =komut.ExecuteReader();

          
                while (oku.Read())
                {
                    //burada listview kullandıgımız için bilgileri cagırma işlemi biraz farklı gerçekleşiyor aşagıda listview ile billgiyi cekme kısmı mevcut
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku[0].ToString();
                    ekle.SubItems.Add(oku["Ad"].ToString());//burada istersek hucre sayısının degerini yada istedigimiz kolonun adını yazarak bilgileri cekebiliriz
                    ekle.SubItems.Add(oku[2].ToString());
                    ekle.SubItems.Add(oku[3].ToString());
                    ekle.SubItems.Add(oku[4].ToString());
                    ekle.SubItems.Add(oku[5].ToString());
                    ekle.SubItems.Add(oku[6].ToString());
                    ekle.SubItems.Add(oku[7].ToString());
                    ekle.SubItems.Add(oku[8].ToString());
                    ekle.SubItems.Add(oku[9].ToString());
                    ekle.SubItems.Add(oku[10].ToString());

                    listView1.Items.Add(ekle);


                }
                baglanti.Close();
              
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigetir();
         
           
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id= int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cmbcinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            maskmaktxttel.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtmail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            msktxttc.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtodano.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtucret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpgiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpcıkıs.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtodano.Text=="101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda101 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigetir();
                MessageBox.Show("Müşterinin sadece oda kaydı silinmiştir");
            }
            if (txtodano.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda102 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigetir();
                MessageBox.Show("Müşterinin sadece oda kaydı silinmiştir");
            }
            if (txtodano.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda103 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigetir();
                MessageBox.Show("Müşterinin sadece oda kaydı silinmiştir");
            }
            if (txtodano.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda104 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigetir();
                MessageBox.Show("Müşterinin sadece oda kaydı silinmiştir");
            }
            if (txtodano.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda105 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigetir();
                MessageBox.Show("Müşterinin sadece oda kaydı silinmiştir");
            }
            if (txtodano.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda106 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigetir();
                MessageBox.Show("Müşterinin sadece oda kaydı silinmiştir");
            }
            if (txtodano.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda107 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigetir();
                MessageBox.Show("Müşterinin sadece oda kaydı silinmiştir");
            }
            if (txtodano.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda108 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigetir();
                MessageBox.Show("Müşterinin sadece oda kaydı silinmiştir");
            }
            if (txtodano.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda109 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigetir();
                MessageBox.Show("Müşterinin sadece oda kaydı silinmiştir");
            }



        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtsoyad.Clear();
            cmbcinsiyet.Text="";
            maskmaktxttel.Clear();
            txtmail.Clear();
            msktxttc.Clear();
            txtodano.Clear();
            txtucret.Clear();
            dtpgiris.Text="";
            dtpcıkıs.Text="";
         
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
           // birinci güncelleme yolu

            baglanti.Open();
            //SqlCommand güncelle = new SqlCommand("update  Musteriekle  set Ad=@a1,Soyad=@a2,Cinsiyet=@a3,Telefon=@a4,Mail=@a5,TC=@a6,OdaNo=@a7,Ucret=@a8,Giristarihi=@a9, cıkıstarihi=@a10 where musteriID=( " + id + ")", baglanti);
            ////güncelle.Parameters.AddWithValue("@a11", id);
            //güncelle.Parameters.AddWithValue("@a1", txtad.Text);
            //güncelle.Parameters.AddWithValue("@a2", txtsoyad.Text);
            //güncelle.Parameters.AddWithValue("@a3", cmbcinsiyet.Text);
            //güncelle.Parameters.AddWithValue("@a4", maskmaktxttel.Text);
            //güncelle.Parameters.AddWithValue("@a5", txtmail.Text);
            //güncelle.Parameters.AddWithValue("@a6", msktxttc.Text);
            //güncelle.Parameters.AddWithValue("@a7", txtodano.Text);
            //güncelle.Parameters.AddWithValue("@a8", txtucret.Text);
            //güncelle.Parameters.AddWithValue("@a9", dtpgiris.Value.ToString("yyyy-MM-dd"));
            //güncelle.Parameters.AddWithValue("@a10", dtpcıkıs.Value.ToString("yyyy-MM-dd"));
            //güncelle.ExecuteNonQuery();
            //baglanti.Close();
            //MessageBox.Show("güncelleme tamamlandı ");
            //verilerigetir();

            //ikinci güncelleme yolu 

            SqlCommand komut = new SqlCommand("update Musteriekle set Ad ='" + txtad.Text + "', Soyad='" + txtsoyad.Text + "', Cinsiyet='" + cmbcinsiyet.Text + "', Telefon='" + maskmaktxttel.Text+ "'," +
                "Mail='" + txtmail.Text+ "',TC='" + msktxttc.Text+ "',OdaNo='"+ txtodano.Text+ "',Ucret='"+ txtucret.Text+ "',Giristarihi='" + dtpgiris.Value.ToString("yyyy-MM-dd")+ "',cıkıstarihi='"+ dtpcıkıs.Value.ToString("yyyy-MM-dd")+"'  " +
                "  where musteriID=( " + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("güncelleme tamamlandı ");
            verilerigetir();

        }

        private void btnara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Musteriekle where   Ad like '%" + textBox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
                //burada listview kullandıgımız için bilgileri cagırma işlemi biraz farklı gerçekleşiyor aşagıda listview ile billgiyi cekme kısmı mevcut
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku[0].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());//burada istersek hucre sayısının degerini yada istedigimiz kolonun adını yazarak bilgileri cekebiliriz
                ekle.SubItems.Add(oku[2].ToString());
                ekle.SubItems.Add(oku[3].ToString());
                ekle.SubItems.Add(oku[4].ToString());
                ekle.SubItems.Add(oku[5].ToString());
                ekle.SubItems.Add(oku[6].ToString());
                ekle.SubItems.Add(oku[7].ToString());
                ekle.SubItems.Add(oku[8].ToString());
                ekle.SubItems.Add(oku[9].ToString());
                ekle.SubItems.Add(oku[10].ToString());

                listView1.Items.Add(ekle);


            }
            baglanti.Close();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }

        private void btnverisil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Musteriekle where musteriID=(" + id+") ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigetir();
            MessageBox.Show("Müşteri veri tanabından silinmiştir");
            
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Hide();
        }
    }
}
