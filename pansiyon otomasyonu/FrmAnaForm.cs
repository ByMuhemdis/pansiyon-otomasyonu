using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pansiyon_otomasyonu
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //admin giriş butonu
            FrmAdminGiris fr=new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Müsteri ekle(yeni müşteri) giden buton
            FrmYeniMusteri fr=new FrmYeniMusteri();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //odalara giden buton
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
            this.Hide();
        }

        private void btnmusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr=new FrmMusteriler();
            fr.Show();
            this.Hide();
           

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DİKKAT \n Bu uygulama papatya pansiyonu tarafından 2022 tarihinde oluşturulmuştur ");
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngelirgider_Click(object sender, EventArgs e)
        {
            frmgelirgider fr = new frmgelirgider();
            fr.Show();
            this.Hide();
        }

        private void btnstok_Click(object sender, EventArgs e)
        {
            frmstoklar fr = new frmstoklar();
            fr.Show();
            this.Hide();
        }

        private void btnradyo_Click(object sender, EventArgs e)
        {
            frmradio fr=new frmradio();
            fr.Show();
            
        }

        private void btngazete_Click(object sender, EventArgs e)
        {
            frmgazete df= new frmgazete();
            df.Show();
            
        }

        private void btnadminsifre_Click(object sender, EventArgs e)
        {
            frmsifreguncelle fr=new frmsifreguncelle();
            fr.Show();
        }

        private void btnmesaj_Click(object sender, EventArgs e)
        {
            frmmesajlar fr = new frmmesajlar();
            fr.Show();
        }
    }
}
