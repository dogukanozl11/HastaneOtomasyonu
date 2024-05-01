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
    public partial class DoktorBilgileri : Form
    {
        public DoktorBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        private void DoktorBilgileri_Load(object sender, EventArgs e)
        {
            try
            {
                bag.Open();
                txtTC.Text = Anasayfa.dtc;
                string sql = "select * from tbl_doktor where TcNo = @prm1";
                SqlCommand komut = new SqlCommand(sql, bag);
                komut.Parameters.AddWithValue("@prm1", txtTC.Text);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    txtTC.Text = oku[2].ToString();
                    txtİsim.Text = oku[1].ToString();
                    maskedTextBoxYas.Text = oku[3].ToString();
                    CmbDoktorCinsiyet.Text = oku[4].ToString();
                    txtTel.Text = oku[5].ToString();
                    txtEmail.Text = oku[6].ToString();
                    CmbDoktorBrans.Text = oku[8].ToString();
                    txtEskiSifre.Text = oku[7].ToString();
                }
                bag.Close();
            }
            catch
            {
                MessageBox.Show("Hata!! Lütfen Daha Sonra Tekar Deneyiniz!! ");
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                bag.Open();
                string sql = "update tbl_doktor set TelNo=@prm1,eMail=@prm2,sifre=@prm3,doktor_klinik_id=@prm4 where TcNo=@TC";
                SqlCommand guncelle = new SqlCommand(sql, bag);
                guncelle.Parameters.AddWithValue("@TC", txtTC.Text);
                guncelle.Parameters.AddWithValue("@prm1", txtTel.Text);
                guncelle.Parameters.AddWithValue("@prm2", txtEmail.Text);
                if (txtYeniSifre.Text != "")
                {
                    guncelle.Parameters.AddWithValue("@prm3", txtYeniSifre.Text);
                }
                else
                {
                    guncelle.Parameters.AddWithValue("@prm3", txtEskiSifre.Text);
                }
                guncelle.Parameters.AddWithValue("@prm4", CmbDoktorBrans.SelectedIndex);
                guncelle.ExecuteNonQuery();
                bag.Close();
                MessageBox.Show("Kullanıcı Bilgileri Güncellendi,Lütfen Tekrar Giriş Yapınız.");

            }
            catch
            {
                MessageBox.Show("Hata!! Lütfen daha sonra tekrar deneyiniz");
            }
        }
    }
}
