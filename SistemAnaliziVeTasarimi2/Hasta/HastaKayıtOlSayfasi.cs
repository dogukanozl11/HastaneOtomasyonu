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
using System.Security.Cryptography;

namespace SistemAnaliziVeTasarimi2.Hasta
{
    public partial class HastaKayıtOlSayfasi : Form
    {
        public HastaKayıtOlSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True");
        private void btnHastaKayıtYap_Click(object sender, EventArgs e)
        {

            string sql = "INSERT INTO tbl_hasta(isim,soyisim,tcNo,yaş,cinsiyet,kan,telno,eMail,sifre) VALUES (@hastaİsim,@hastaSoyİsim,@hastaTCNo,@hastaYas,@hastaCinsiyet,@kan,@hastaTelefon,@hastaMail,@hastaSifre)";
            SqlCommand komut = new SqlCommand(sql, bag);

            komut.Parameters.AddWithValue("@hastaİsim", txtHastaİsim.Text);
            komut.Parameters.AddWithValue("@hastaSoyİsim", txtHastaSoyisim.Text);
            komut.Parameters.AddWithValue("@hastaTCNo", txtHastaTC.Text);
            komut.Parameters.AddWithValue("@hastaYas", txtHastaYaş.Text);
            komut.Parameters.AddWithValue("@hastaCinsiyet", CmbHastaCinsiyet.Text);
            komut.Parameters.AddWithValue("@kan", comboBoxKanGrup.Text);
            komut.Parameters.AddWithValue("@hastaTelefon", txtHastaTel.Text);
            komut.Parameters.AddWithValue("@hastaMail", txtHastaMail.Text);
            //komut.Parameters.AddWithValue("@hastaSifre", txtHastaSifre.Text);
            string şifre = MD5sifre(txtHastaSifre.Text);
            komut.Parameters.AddWithValue("@hastaSifre", şifre);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Hasta Kayıt İşlemi Başrılı . ŞİFRENİZ : " + txtHastaSifre.Text);
        }
        public static string MD5sifre (string sifre)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(sifre));

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

    }
}
