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

namespace SistemAnaliziVeTasarimi2.Laboratuvar
{
    public partial class LaboratuvarKayıtOlSayfasi : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True");
        public LaboratuvarKayıtOlSayfasi()
        {
            InitializeComponent();
        }

        private void btnLabPKayıtYap_Click(object sender, EventArgs e)
        {
            string sql = "Insert into tbl_labpersonel(labp_isim,labp_soyisim,labp_TcNo,labp_yas,labp_cinsiyet,labp_telno,labp_eMail,labp_sifre) VALUES (@labPİsim,@labPSoysim,@labPTcNo,@labPYas,@labPCinsiyet,@labPTelefon,@labPeMail,@labPSifre)";
            SqlCommand komut = new SqlCommand(sql,bag);

            komut.Parameters.AddWithValue("@labPİsim", txtLabPİsim.Text);
            komut.Parameters.AddWithValue("@labPSoysim", txtLabPSoyisim.Text);
            komut.Parameters.AddWithValue("@labPTcNo", txtLabPTC.Text);
            komut.Parameters.AddWithValue("@labPYas", txtLabPYaş.Text);
            komut.Parameters.AddWithValue("@labPCinsiyet", CmbLabPCinsiyet.Text);
            komut.Parameters.AddWithValue("@labPTelefon", txtLabPTel.Text);
            komut.Parameters.AddWithValue("@labPeMail", txtLabPMail.Text);
            //komut.Parameters.AddWithValue("@labPSifre", txtLabPSifre.Text); Eski Şifreleme Yöntemi.
            string MDsifre = helper.MD5sifre(txtLabPSifre.Text);
            komut.Parameters.AddWithValue("@labPSifre", txtLabPSifre.Text);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Laboratuvar Personel Kayıt İşlemi Başarılı . Şifreniz : "+ txtLabPSifre.Text);
        }
    }
}
