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
    public partial class HastaBilgileri : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public HastaBilgileri()
        {
            InitializeComponent();
        }

        private void HastaBilgileri_Load(object sender, EventArgs e)
        {
            try
            {
                bag.Open();
                txtTC.Text = Anasayfa.htc;
                string sql = "select * from tbl_hasta where TcNo = @prm1";
                SqlCommand komut = new SqlCommand(sql, bag);
                komut.Parameters.AddWithValue("@prm1", txtTC.Text);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    txtTC.Text = oku[3].ToString();
                    txtİsim.Text = oku[1].ToString();
                    txtSoyisim.Text = oku[2].ToString();
                    maskedTextBoxYas.Text = oku[4].ToString();
                    CmbDoktorCinsiyet.Text = oku[5].ToString();
                    txtTel.Text = oku[6].ToString();
                    txtEmail.Text = oku[7].ToString();
                    txtEskiSifre.Text = oku[8].ToString();
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

        }
    }
}
