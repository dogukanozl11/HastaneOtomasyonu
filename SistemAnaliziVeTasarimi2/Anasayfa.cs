using SistemAnaliziVeTasarimi2.ADMİN;
using SistemAnaliziVeTasarimi2.Doktor;
using SistemAnaliziVeTasarimi2.Hasta;
using SistemAnaliziVeTasarimi2.Laboratuvar;
using SistemAnaliziVeTasarimi2.Sekreter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemAnaliziVeTasarimi2
{
    public partial class Anasayfa : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");

        public static string dtc, dsifre;
        public static string htc, hsifre;
        public Anasayfa()
        {
            InitializeComponent();
        }
        #region Yan MENU
        void gizle()
        {
            DoktorGroupBox.Visible = false;
            HastaKabulGroupBox.Visible = false;
            hastaGroupBox.Visible = false;
            AdmingroupBox.Visible = false;
            LaboratuvargroupBox.Visible = false;
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            gizle();
            AdmingroupBox.Visible = true;
            GirisPaneli.Visible = true;
        }

        private void BtnHastaGiris_Click(object sender, EventArgs e)
        {
            gizle();
            hastaGroupBox.Visible = true;
            GirisPaneli.Visible = true;
        }

        private void BtnDoktorGiris_Click(object sender, EventArgs e)
        {
            gizle();
            DoktorGroupBox.Visible = true;
            GirisPaneli.Visible = true;

        }
        private void BtnSekreterGiris_Click(object sender, EventArgs e)
        {
            gizle();
            HastaKabulGroupBox.Visible = true;
            GirisPaneli.Visible = true;
        }
        private void btnLab_Click(object sender, EventArgs e)
        {
            gizle();
            LaboratuvargroupBox.Visible = true;
            GirisPaneli.Visible = true;
        }
        #endregion

        #region Giris Yap Button
        private void btnDoktorGirisYap_Click(object sender, EventArgs e)
        {


            string sql = "select * from tbl_doktor where TcNo=@prm1 and sifre=@prm2";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            da.SelectCommand.Parameters.AddWithValue("@prm1", txtTC.Text);
            da.SelectCommand.Parameters.AddWithValue("@prm2", helper.MD5sifre(txtSifre.Text));
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (txtTC.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Boş Bırakılamaz");
            }
            else if (dt.Rows.Count > 0)
            {
                DoktorProfilSayfasi dps = new DoktorProfilSayfasi();
                dtc = txtTC.Text;
                dsifre = txtSifre.Text;
                dps.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void hastagirisbtn_Click(object sender, EventArgs e)
        {

            string sql = "select * from tbl_hasta where TcNo=@prm1 and sifre=@prm2";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            da.SelectCommand.Parameters.AddWithValue("@prm1", txthastaTC.Text);
            da.SelectCommand.Parameters.AddWithValue("@prm2", helper.MD5sifre(txtHastaSifre.Text));
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (txthastaTC.Text == "" || txtHastaSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Boş Bırakılamaz");
            }
            else if (dt.Rows.Count > 0)
            {
                HastaProfilSayfasi hps = new HastaProfilSayfasi();
                hps.tcno = txtTC.Text;
                htc = txthastaTC.Text;
                hps.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            string sql = "select * from tbl_admin where id=@prm1 and sifre=@prm2";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            da.SelectCommand.Parameters.AddWithValue("@prm1", txtAdminID.Text);
            da.SelectCommand.Parameters.AddWithValue("@prm2", txtAdminSifre.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                AdminYöneticiPaneli ayp = new AdminYöneticiPaneli();
                ayp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }
        private void BtnHastaKabulGiris_Click(object sender, EventArgs e)
        {
            string sql = "select * from tbl_sekreter where tcNo=@prm1 and sifre=@prm2";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            da.SelectCommand.Parameters.AddWithValue("@prm1", txthastakabultc.Text);
            da.SelectCommand.Parameters.AddWithValue("@prm2", helper.MD5sifre(txtHastakabulSifre.Text));
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (txthastakabultc.Text == "" || txtHastakabulSifre.Text == "")
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
        private void btnLabPGiris_Click(object sender, EventArgs e)
        {
            string sql = "Select * from tbl_labpersonel where labp_TcNo=@prm1 and labp_sifre=@prm2";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            da.SelectCommand.Parameters.AddWithValue("@prm1", txtLabPTC.Text);
            da.SelectCommand.Parameters.AddWithValue("@prm2", helper.MD5sifre(txtLabPSifre.Text));
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (txtLabPTC.Text == "" || txtLabPSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Boş Bırakılamaz");
            }
            else if (dt.Rows.Count > 0)
            {
                LaboratuvarSayfasi lab = new LaboratuvarSayfasi();
                lab.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }
        #endregion

        #region Sİfremi Unutum
        private void btnDoktorSifremiUnuttum_Click(object sender, EventArgs e)
        {
            DoktorSifremiUnuttumSayfasi dsus = new DoktorSifremiUnuttumSayfasi();
            dsus.Show();
        }

        private void btnHastaSifremiUnuttum_Click(object sender, EventArgs e)
        {
            HastaSifremiUnuttumSayfasi hsus = new HastaSifremiUnuttumSayfasi();
            hsus.Show();
        }

        private void btnHastaKabulSifremiUnuttum_Click(object sender, EventArgs e)
        {
            SekreterSifremiUnuttumSayfasi ssus = new SekreterSifremiUnuttumSayfasi();
            ssus.Show();
        }

        private void btnLabSifremiUnuttum_Click(object sender, EventArgs e)
        {
            LaboratuvarSifremiUnuttumSayfasi lsus = new LaboratuvarSifremiUnuttumSayfasi();
            lsus.Show();
        }
        #endregion

        private void btnHastaKayıtol_Click(object sender, EventArgs e)
        {
            HastaKayıtOlSayfasi hkos = new HastaKayıtOlSayfasi();
            hkos.Show();
        }

        private void GirisPaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            txtAdminSifre.PasswordChar = '*';
            txtSifre.PasswordChar = '*';
            txtHastakabulSifre.PasswordChar = '*';
            txtLabPSifre.PasswordChar = '*';
            txtHastaSifre.PasswordChar = '*';
            //DoktorGroupBox.BackColor = Color.AliceBlue;
            //AdmingroupBox.BackColor = Color.AliceBlue;
            //hastaGroupBox.BackColor = Color.AliceBlue;
            //HastaKabulGroupBox.BackColor = Color.AliceBlue;
            //LaboratuvargroupBox.BackColor = Color.AliceBlue;
            txthastaTC.MaxLength = 11;

        }

        private void btniletisim_Click(object sender, EventArgs e)
        {
            iletisim iltsm = new iletisim();
            iltsm.Show();
        }







    }
}
