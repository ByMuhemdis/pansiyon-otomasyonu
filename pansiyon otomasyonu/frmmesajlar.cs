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
    public partial class frmmesajlar : Form
    {
        public frmmesajlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-02O23ES;Initial Catalog=papatyapansiyon;Integrated Security=True");
        private void verilerigetir()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Mesajlar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
                //burada listview kullandıgımız için bilgileri cagırma işlemi biraz farklı gerçekleşiyor aşagıda listview ile billgiyi cekme kısmı mevcut
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["mesajid"].ToString();//burada istersek hucre sayısının degerini yada istedigimiz kolonun adını yazarak bilgileri cekebiliriz
                ekle.SubItems.Add(oku[1].ToString());
                ekle.SubItems.Add(oku[2].ToString());
               

                listView1.Items.Add(ekle);


            }
            baglanti.Close();

        }
        private void btnmesajkayıt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesajlar(Adsoyad,mesaj) values ('" + txtadsoyaad.Text + "','" + richmesaj.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigetir();

        }

        private void frmmesajlar_Load(object sender, EventArgs e)
        {
            verilerigetir();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtadsoyaad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richmesaj.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
