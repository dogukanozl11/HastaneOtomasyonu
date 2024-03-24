using SistemAnaliziVeTasarimi2.Sekreter;
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

namespace SistemAnaliziVeTasarimi2.Doktor
{
    public partial class DoktorGirisSayfasi : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public DoktorGirisSayfasi()
        {
            InitializeComponent();
        }

        private void BtnGERİ_Click(object sender, EventArgs e)
        {
            Anasayfa ansyf = new Anasayfa();
            ansyf.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string sql = "select * from tbl_doktor where TcNo=@prm1 and sifre=@prm2";
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
                DoktorProfilSayfasi dps = new DoktorProfilSayfasi();
                dps.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void BtnKayıtOl_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.Show();
            this.Hide();
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {

        }
    }
}
