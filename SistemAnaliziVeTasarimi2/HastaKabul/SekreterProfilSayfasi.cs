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
            txtAdres.Clear();
            CmbDurum.Text = "";
            cmbAcilKlinik.Text = "";
            cmbDoktor.Text = "";
            txtHastaID.Clear();
            richTextBoxŞikayet.Clear();
            cmbMuayeneKlinik.Text = "";
            cmbMuayeneDoktor.Text = "";
            txtMuayeneHastaID.Clear();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }
        void klinkgetir()
        {
            SqlCommand c = new SqlCommand("select * from tbl_klinikler where klinik_id < 14 or klinik_id > 18",bag);
            qq.combo(c,"klinik_id","klinik_adi",cmbMuayeneKlinik);
        }
        void doktorgetir()
        {
            SqlCommand acil = new SqlCommand("select * from tbl_doktor", bag);
            qq.combo(acil,"doktor_id","isim",cmbDoktor);
        }
        void acilklinik()
        {
            SqlCommand acilKlinik = new SqlCommand("select * from tbl_klinikler where klinik_id > '15' ",bag);
            qq.combo(acilKlinik,"klinik_id","klinik_adi",cmbAcilKlinik);
        }
        void id()
        {
            bag.Open();
        }
        private void SekreterProfilSayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}
