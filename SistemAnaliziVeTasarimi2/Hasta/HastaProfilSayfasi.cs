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
        public HastaProfilSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        private void btnGERİ_Click(object sender, EventArgs e)
        {
            HastaGirisSayfasi hgs = new HastaGirisSayfasi();
            hgs.Show();
            this.Hide();
        }
        public string tcno;
        private void HastaProfilSayfasi_Load(object sender, EventArgs e)
        {
            LblTC.Text = tcno;

            bag.Open();
            string sql = "select isim,soyisim from tbl_hasta where TcNo=@prm1";
            SqlCommand komut = new SqlCommand(sql,bag);
            komut.Parameters.AddWithValue("@prm1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
                LblTC.Text = tcno;
            }
            bag.Close();
        }
    }
}
