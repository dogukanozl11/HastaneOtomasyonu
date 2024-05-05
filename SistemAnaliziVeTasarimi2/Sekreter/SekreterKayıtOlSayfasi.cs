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
    public partial class SekreterKayıtOlSayfasi : Form
    {
        public SekreterKayıtOlSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True");
        private void btnSekreterKayitGeri_Click(object sender, EventArgs e)
        {
            Anasayfa sgs = new Anasayfa();
            sgs.Show();
            this.Hide();
        }

        private void btnSekreterKayıtYap_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO tbl_sekreter(isim,soyisim,tcNo,yaş,cinsiyet,telno,eMail,sifre) VALUES (@Sekreterİsim,@SekreterSoyİsim,@SekreterTCNo,@SekreterYas,@SekreterCinsiyet,@SekreterTelefon,@SekreterMail,@SekreterSifre)";
            SqlCommand komut = new SqlCommand(sql,bag);

            komut.Parameters.AddWithValue("@Sekreterİsim",txtSekreterİsim.Text);
            komut.Parameters.AddWithValue("@SekreterSoyİsim",txtSekreterSoyisim.Text);
            komut.Parameters.AddWithValue("@SekreterTCNo",txtSekreterTC.Text);
            komut.Parameters.AddWithValue("@SekreterYas",txtSekreterYaş.Text);
            komut.Parameters.AddWithValue("@SekreterCinsiyet",CmbSekreterCinsiyet.Text);
            komut.Parameters.AddWithValue("@SekreterTelefon",txtSekreterTel.Text);
            komut.Parameters.AddWithValue("@SekreterMail",txtSekreterMail.Text);
            komut.Parameters.AddWithValue("@SekreterSifre",txtSekreterSifre.Text);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Sekreter Kayıt İşlemi Başrılı . ŞİFRENİZ : " + txtSekreterSifre.Text);

            
        }
    }
}
