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
    public partial class HastaProfilSayfasi : Form
    {
        public static string idx;
        public static string idxx;
        public HastaProfilSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        
        public string tcno;
        private void HastaProfilSayfasi_Load(object sender, EventArgs e)
        {
            #region HastaLblVeriÇekme
            try
            {
                lblTc.Text = Anasayfa.htc;
                bag.Open();
                string sql = "select * from tbl_hasta where TcNo=@prm1";
                SqlCommand tc = new SqlCommand(sql, bag);
                tc.Parameters.AddWithValue("@prm1", lblTc.Text);
                SqlDataReader oku = tc.ExecuteReader();
                while (oku.Read())
                {
                    this.lblIDXX.Text = oku[0].ToString();
                    this.lblTc.Text = oku[3].ToString();
                    lblisim.Text = oku[1].ToString();
                    lblSoyisim.Text = oku[2].ToString();
                    lblEmail.Text = oku[8].ToString();
                }
                bag.Close();
                idx = lblTc.Text;
                idxx = lblIDXX.Text;

            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");
            }
            #endregion
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            HastaRandevuAl HRAL = new HastaRandevuAl();
            HRAL.Show();
        }

        private void btnRandevularım_Click(object sender, EventArgs e)
        {
            HastaRandevularım HR = new HastaRandevularım();
            HR.Show();
        }

        private void btnHastaBilgileri_Click(object sender, EventArgs e)
        {
            HastaBilgileri HB = new HastaBilgileri();
            HB.Show();
        }

       

        private void BtnRecetelerim_Click(object sender, EventArgs e)
        {
            HastaRecetelerimSayfasi HRS = new HastaRecetelerimSayfasi();
            HRS.Show();
            this.Hide();
        }

        private void btnGERİ_Click(object sender, EventArgs e)
        {
            DialogResult karar = new DialogResult();
            karar = MessageBox.Show("Çıkış istediğinize emin misiniz ? ", "Uyarı", MessageBoxButtons.YesNo);
            if (karar == DialogResult.Yes)
            {
                this.Hide();
                Anasayfa yeni = new Anasayfa();
                yeni.Show();
            }
            else if (karar == DialogResult.No)
            {
                MessageBox.Show("Oturum Kapatılmadı.");
            }
        }

        private void BtnRandevuSil_Click(object sender, EventArgs e)
        {

        }

        private void btnGeçmisSonuc_Click(object sender, EventArgs e)
        {

        }
    }
}
