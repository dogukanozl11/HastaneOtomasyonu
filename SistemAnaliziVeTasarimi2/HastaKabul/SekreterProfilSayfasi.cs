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
            helper.combo(c, "klinik_id", "klinik_adi", cmbMuayeneKlinik);
        }
        void doktorgetir()
        {
            SqlCommand acil = new SqlCommand("select * from tbl_doktor", bag);
            helper.combo(acil, "doktor_id", "isim", cmbDoktor);
        }
        void acilklinik()
        {
            SqlCommand acilKlinik = new SqlCommand("select * from tbl_klinikler where klinik_id > '15' ", bag);
            helper.combo(acilKlinik, "klinik_id", "klinik_adi", cmbAcilKlinik);
        }
        void id()
        {
            bag.Open();
            SqlCommand id = new SqlCommand("select hasta_id from tbl_hasta", bag);
            SqlDataReader oku = id.ExecuteReader();
            while (oku.Read())
            {
                txtHastaID.Text = oku[0].ToString();
                txtMuayeneHastaID.Text = oku[0].ToString();
            }
            bag.Close();
        }
        void idsorgulama()
        {
            bag.Open();
            SqlCommand id = new SqlCommand("select hasta_id from tbl_hasta where TcNo=@tc", bag);
            id.Parameters.AddWithValue("@tc", txtTC.Text);
            SqlDataReader oku = id.ExecuteReader();
            while (oku.Read())
            {
                txtHastaID.Text = oku[0].ToString();
                txtMuayeneHastaID.Text = oku[0].ToString();
            }
            bag.Close();

        }
        private void SekreterProfilSayfasi_Load(object sender, EventArgs e)
        {
            try
            {
                groupBoxAcil.Visible = false;
                groupBoxPol.Visible = false;
                klinkgetir();

                acilklinik();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");
            }
        }

        private void btnAcil_Click(object sender, EventArgs e)
        {
            if (true)
            {
                groupBoxAcil.Enabled = true;
                groupBoxAcil.Visible = true;
                groupBoxPol.Enabled = false;
                groupBoxPol.Visible = false;
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
                groupBoxAcil.Visible = false;
                groupBoxPol.Enabled = true;
                groupBoxPol.Visible = true;
            }
            else
            {
                MessageBox.Show("Lütfen Hasta Girişi Yapınız.");
            }
        }

        private void btnHastaSorgula_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTC.Text != "")
                {
                    using (SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;"))
                    {
                        bag.Open();
                        SqlCommand cmd = new SqlCommand("select * from tbl_hasta where TcNo=@tc ", bag);
                        cmd.Parameters.AddWithValue("@tc", txtTC.Text);
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

                            MessageBox.Show("ilgili Tc ye Ait Kayıtlı Hasta Bulundu.");
                            idsorgulama();
                            

                        }
                        else
                        {
                            MessageBox.Show("Bu Tc No ya sahip Hasta Bulunamadı.");
                        }
                            
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen Hasta Tc sini Giriniz. ");
                }
                bag.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata !! Daha Sonra Tekrar Deneyiniz.");
            }

        }

        private void btnAcilKaydet_Click(object sender, EventArgs e)
        {
            //
            if (CmbDurum.Text != "" && cmbAcilKlinik.Text != "" && cmbDoktor.Text != "" && txtHastaID.Text != "" && richTextBoxŞikayet.Text != "")
            {
                try
                {
                    bag.Open();
                    SqlCommand acil = new SqlCommand("insert into tbl_acil(acil_doktorid,aciklama,derece,acil_klinikid,acil_hastaid) values (@p1,@p2,@p3,@p4,@p5)", bag);
                    acil.Parameters.AddWithValue("@p1", cmbDoktor.SelectedValue.ToString());
                    acil.Parameters.AddWithValue("@p2", richTextBoxŞikayet.Text);
                    acil.Parameters.AddWithValue("@p3", CmbDurum.Text);
                    acil.Parameters.AddWithValue("@p4", cmbAcilKlinik.SelectedValue.ToString());
                    acil.Parameters.AddWithValue("@p5", txtHastaID.Text);
                    acil.ExecuteNonQuery();
                    bag.Close();
                    MessageBox.Show("Acil Hasta Kaydı Başarıyla Tamamlandı");
                    temizle();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Hasta Girişi Yapınız.");
            }
        }

        private void btnMuayeneKayıt_Click(object sender, EventArgs e)
        {
            //
            try
            {
                bag.Open();
                SqlCommand muayenekayıt = new SqlCommand("insert into tbl_bekleyenHasta(bekleyen_klinikid,bekleyen_doktorid,bekleyen_hastaid)values(@p1,@p2,@p3)", bag);
                muayenekayıt.Parameters.AddWithValue("@p1",cmbMuayeneKlinik.SelectedValue.ToString());
                muayenekayıt.Parameters.AddWithValue("@p2",cmbMuayeneDoktor.SelectedValue.ToString());
                muayenekayıt.Parameters.AddWithValue("@p3",txtMuayeneHastaID.Text);
                muayenekayıt.ExecuteNonQuery();

                bag.Close();

                MessageBox.Show("Hasta Başarıyla Muayene Sırasına Alındı");
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata !! Lütfen Daha Sonra Tekrar Deneyiniz.",ex.Message);
            }
        }

        private void cmbMuayeneKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {/////////////////////////////////////////
            try
            {
                if (cmbMuayeneKlinik.SelectedIndex != 0)
                {
                    bag.Open();
                    SqlCommand komut = new SqlCommand("select tbl_klinikler.klinik_id,tbl_doktor.doktor_id,tbl_doktor.isim from tbl_doktor INNER JOIN tbl_klinikler on tbl_doktor.doktor_klinik_id=tbl_klinikler.klinik_id where tbl_doktor.doktor_klinik_id=@kid", bag);
                    komut.Parameters.AddWithValue("@kid", cmbMuayeneKlinik.SelectedValue.ToString());
                    helper.combo(komut, "doktor_id", "isim", cmbMuayeneDoktor);

                    bag.Close();
                }

            }
            catch
            {

                MessageBox.Show("Hata !! Lütfen Daha Sonra Tekrar Deneyiniz");
            }
        }

        private void cmbAcilKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAcilKlinik.SelectedIndex != 0)
                {
                    bag.Open();
                    SqlCommand komut = new SqlCommand("select tbl_klinikler.klinik_id,tbl_doktor.doktor_id,tbl_doktor.isim from tbl_doktor INNER JOIN tbl_klinikler ON tbl_doktor.doktor_klinik_id=tbl_klinikler.klinik_id where tbl_doktor.doktor_klinik_id=@kid and doktor_klinik_id > 15", bag);
                    komut.Parameters.AddWithValue("@kid", cmbAcilKlinik.SelectedValue.ToString());
                    helper.combo(komut, "doktor_id", "isim", cmbDoktor);

                    bag.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz",ex.Message);
            }
        }

        private void btnHastaKayıt_Click(object sender, EventArgs e)
        {
            if (txtTC.Text != "" && txtAD.Text != "" && txtSoyad.Text != "" && txtDogumTarihi.Text != "" && txtCinsyet.Text != "" && txtKan.Text != "" && txtTel.Text != "" && txtEmail.Text != "" && txtSifre.Text != "")
            {
                try
                {
                    bag.Open();
                    SqlCommand komut = new SqlCommand("insert into tbl_hasta(TcNo,isim,soyisim,Yaş,Cinsiyet,kan,TelNo,eMail,sifre)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bag);
                    komut.Parameters.AddWithValue("@p1", txtTC.Text);
                    komut.Parameters.AddWithValue("@p2", txtAD.Text);
                    komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@p4", txtDogumTarihi.Text);
                    komut.Parameters.AddWithValue("@p5", txtCinsyet.Text);
                    komut.Parameters.AddWithValue("@p6", txtKan.Text);
                    komut.Parameters.AddWithValue("@p7", txtTel.Text);
                    komut.Parameters.AddWithValue("@p8", txtEmail.Text);
                    komut.Parameters.AddWithValue("@p9", txtSifre.Text);
                    komut.ExecuteNonQuery();

                    bag.Close();

                    MessageBox.Show("Hasta Kaydı Başarılı.");

                    id();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata! Lütfen Daha Donra Tekrar Deneyin.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Hasta Girişi Yapınız!!");
            }
        }
    }
}
