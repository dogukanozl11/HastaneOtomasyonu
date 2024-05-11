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
    public partial class SekreterProfilSayfasi : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public static SqlDataReader dr;
        public SekreterProfilSayfasi()
        {
            InitializeComponent();
        }

        private void btnGERİ_Click(object sender, EventArgs e)
        {
            Anasayfa sgs = new Anasayfa();
            sgs.Show();
            this.Hide();
        }
        void temizle()
        {
            txtTC.Clear();
            txtAD.Clear();
            txtSoyad.Clear();
            txtCinsyet.Text = "";
            txtKan.Text = "";
            txtDogumTarihi.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            CmbDurum.Text = "";
            cmbAcilKlinik.Text = "";
            cmbDoktor.Text = "";
            txtHastaID.Clear();
            richTextBoxŞikayet.Clear();
            cmbMuayeneKlinik.Text = "";
            cmbMuayeneDoktor.Text = "";
            txtMuayeneHastaID.Clear();
            groupBoxAcil.Enabled = false;
            groupBoxPol.Enabled = false;
        }
        void klinkgetir()
        {
            SqlCommand c = new SqlCommand("select * from tbl_klinikler where klinik_id < 14 or klinik_id > 18", bag);
            qq.combo(c, "klinik_id", "klinik_adi", cmbMuayeneKlinik);
        }
        void doktorgetir()
        {
            SqlCommand acil = new SqlCommand("select * from tbl_doktor", bag);
            qq.combo(acil, "doktor_id", "isim", cmbDoktor);
        }
        void acilklinik()
        {
            SqlCommand acilKlinik = new SqlCommand("select * from tbl_klinikler where klinik_id > '15' ", bag);
            qq.combo(acilKlinik, "klinik_id", "klinik_adi", cmbAcilKlinik);
        }
        void id()
        {
            bag.Open();
            SqlCommand id = new SqlCommand("select hasta_id from hastalar",bag);
            SqlDataReader oku = id.ExecuteReader();
        }
        private void SekreterProfilSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void btnAcil_Click(object sender, EventArgs e)
        {
            if (true)
            {
                groupBoxAcil.Enabled = true;
                groupBoxPol.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lütfen Hasta Girişi Yapınız.");
            }

        }

        private void btnMuayene_Click(object sender, EventArgs e)
        {
            if (true)
            {
                groupBoxAcil.Enabled = false;
                groupBoxPol.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen Hasta Girişi Yapınız.");
            }
        }

        private void btnHastaSorgula_Click(object sender, EventArgs e)
        {
            if (txtTC.Text != "")
            {
                bag.Open();
                SqlCommand cmd = new SqlCommand("select * from tbl_hasta where TcNo=@tc ",bag);
                cmd.Parameters.AddWithValue("@tc",txtTC.Text);
                SqlDataReader oku = cmd.ExecuteReader();
                if (oku.Read())
                {
                    txtTC.Text = oku[3].ToString();
                    txtAD.Text = oku[1].ToString();
                    txtSoyad.Text = oku[2].ToString();
                    txtDogumTarihi.Text = oku[4].ToString();
                    txtCinsyet.Text = oku[5].ToString();
                    txtKan.Text = oku[6].ToString();
                    txtTel.Text = oku[7].ToString();
                    txtEmail.Text = oku[8].ToString();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Hasta Tc sini Giriniz. ");
            }
        }
    }
}
