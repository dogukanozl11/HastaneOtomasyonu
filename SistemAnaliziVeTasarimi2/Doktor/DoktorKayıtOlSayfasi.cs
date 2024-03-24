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
            string sql = "INSERT INTO tbl_doktor(isim,soyisim,tcNo,yaş,cinsiyet,telno,eMail,sifre,Branş) VALUES (@Sekreterİsim,@SekreterSoyİsim,@SekreterTCNo,@SekreterYas,@SekreterCinsiyet,@SekreterTelefon,@SekreterMail,@SekreterSifre,@DoktorBrans)";
            SqlCommand komut = new SqlCommand(sql, bag);

            komut.Parameters.AddWithValue("@Sekreterİsim", txtDoktorİsim.Text);
            komut.Parameters.AddWithValue("@SekreterSoyİsim", txtDoktorSoyisim.Text);
            komut.Parameters.AddWithValue("@SekreterTCNo", txtDoktorTC.Text);
            komut.Parameters.AddWithValue("@SekreterYas", txtDoktorYaş.Text);
            komut.Parameters.AddWithValue("@SekreterCinsiyet", CmbDoktorCinsiyet.Text);
            komut.Parameters.AddWithValue("@SekreterTelefon", txtDoktorTel.Text);
            komut.Parameters.AddWithValue("@SekreterMail", txtDoktorMail.Text);
            komut.Parameters.AddWithValue("@SekreterSifre", txtDoktorSifre.Text);
            komut.Parameters.AddWithValue("@DoktorBrans", CmbDoktorBrans.Text);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Sekreter Kayıt İşlemi Başrılı . ŞİFRENİZ : " + txtDoktorSifre.Text);
        }
    }
}
