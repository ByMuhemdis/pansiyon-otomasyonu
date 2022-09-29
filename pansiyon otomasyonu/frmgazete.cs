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
    public partial class frmgazete : Form
    {
        public frmgazete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            webView1.Url="https://www.hurriyet.com.tr/";

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            webView1.Url = "https://www.milliyet.com.tr/";
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            webView1.Url = "https://onedio.com/";
        }

        private void btnfanatik_Click(object sender, EventArgs e)
        {
         
            webView1.Url = "https://www.fanatik.com.tr/";
        }

        private void btnhabeturk_Click(object sender, EventArgs e)
        {
           
            webView1.Url = "https://www.haberturk.com/";
        }

        private void btnshiftdelete_Click(object sender, EventArgs e)
        {
      
           
            webView1.Url = "https://shiftdelete.net/";
        }

        private void btnwebtekno_Click(object sender, EventArgs e)
        {
            webView1.Url = "https://www.webtekno.com/";
        }
    }
}
