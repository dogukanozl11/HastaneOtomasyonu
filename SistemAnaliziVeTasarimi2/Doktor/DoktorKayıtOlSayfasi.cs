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

namespace SistemAnaliziVeTasarimi2.Doktor
{
    public partial class DoktorKayıtOlSayfasi : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True");
        public DoktorKayıtOlSayfasi()
        {
            InitializeComponent();
        }

        private void btnDoktorKayıtYap_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO tbl_doktor(isim,tcNo,yaş,cinsiyet,telno,eMail,sifre,doktor_klinik_id) VALUES (@doktorİsim,@doktorTCNo,@doktorYas,@doktorCinsiyet,@doktorTelefon,@doktorMail,@doktorSifre,@doktorBrans)";
            SqlCommand komut = new SqlCommand(sql, bag);

            komut.Parameters.AddWithValue("@doktorİsim", txtDoktorİsim.Text); 
            komut.Parameters.AddWithValue("@doktorTCNo", txtDoktorTC.Text);
            komut.Parameters.AddWithValue("@doktorYas", maskedTextBoxYas.Text);
            komut.Parameters.AddWithValue("@doktorCinsiyet", CmbDoktorCinsiyet.Text);
            komut.Parameters.AddWithValue("@doktorTelefon", txtDoktorTel.Text);
            komut.Parameters.AddWithValue("@doktorMail", txtDoktorMail.Text);
            //komut.Parameters.AddWithValue("@doktorSifre", txtDoktorSifre.Text); //Eski Şifreleme Yöntemi.
            komut.Parameters.AddWithValue("@doktorBrans", CmbDoktorBrans.SelectedIndex);
            //komut.Parameters.AddWithValue("@doktorBrans", SqlDbType.Int).Value =  Convert.ToInt32(CmbDoktorBrans.SelectedValue);
            string MDsifre = helper.MD5sifre(txtDoktorSifre.Text);
            komut.Parameters.AddWithValue("@doktorSifre", txtDoktorSifre.Text);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Doktor Kayıt İşlemi Başrılı . ŞİFRENİZ : " + txtDoktorSifre.Text);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            //7815696ecbf1c96e6894b779456d330e
        }
    }
}
