using SistemAnaliziVeTasarimi2.Doktor;
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

namespace SistemAnaliziVeTasarimi2.Hasta
{
    public partial class HastaGirisSayfasi : Form
    {
        public HastaGirisSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        private void btnGERİ_Click_1(object sender, EventArgs e)
        {
            Anasayfa ansyf = new Anasayfa();
            ansyf.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string sql = "select * from tbl_hasta where TcNo=@prm1 and sifre=@prm2";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            da.SelectCommand.Parameters.AddWithValue("@prm1", txtTC.Text);
            da.SelectCommand.Parameters.AddWithValue("@prm2", txtSifre.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (txtTC.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Boş Bırakılamaz");
            }
            else if (dt.Rows.Count > 0)
            {
                HastaProfilSayfasi hps = new HastaProfilSayfasi();
                hps.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void BtnKayıtOl_Click(object sender, EventArgs e)
        {
            HastaKayıtOlSayfasi hkos = new HastaKayıtOlSayfasi();
            hkos.Show();
            this.Hide();    
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            HastaSifremiUnuttumSayfasi hsus = new HastaSifremiUnuttumSayfasi();
            hsus.Show();
            this.Hide();
        }
    }
}
