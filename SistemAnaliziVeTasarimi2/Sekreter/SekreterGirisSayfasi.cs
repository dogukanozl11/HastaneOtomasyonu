using SistemAnaliziVeTasarimi2.ADMİN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemAnaliziVeTasarimi2.Sekreter
{
    public partial class SekreterGirisSayfasi : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public SekreterGirisSayfasi()
        {
            InitializeComponent();
        }

        private void btnGERİ_Click(object sender, EventArgs e)
        {
            Anasayfa ansyf = new Anasayfa();
            ansyf.Show();
            this.Hide();
        }

        private void btnSekreterKayıtOl_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.Show();
            this.Hide();
        }

        private void btnSekreterSifremiUnuttun_Click(object sender, EventArgs e)
        {
           SekreterSifremiUnuttumSayfasi ssus = new SekreterSifremiUnuttumSayfasi();
            ssus.Show();
            this.Hide();
        }

        private void btnSekreterGirisYap_Click(object sender, EventArgs e)
        {
            string sql = "select * from tbl_sekreter where tcNo=@prm1 and sifre=@prm2";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            da.SelectCommand.Parameters.AddWithValue("@prm1", txtTC.Text);
            da.SelectCommand.Parameters.AddWithValue("@prm2", txtsifre.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (txtTC.Text=="" || txtsifre.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Boş Bırakılamaz");
            }
            else if (dt.Rows.Count > 0)
            {
                SekreterProfilSayfasi sps = new SekreterProfilSayfasi();
                sps.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
           
        }
    }
}
