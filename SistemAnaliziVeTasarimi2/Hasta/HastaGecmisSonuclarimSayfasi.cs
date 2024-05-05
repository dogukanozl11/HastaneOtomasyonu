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
    public partial class HastaGecmisSonuclarimSayfasi : Form
    {
        public static SqlDataAdapter da;
        public static DataTable dt;
        public static SqlDataReader dr;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public HastaGecmisSonuclarimSayfasi()
        {
            InitializeComponent();
        }

        private void HastaGecmisSonuclarimSayfasi_Load(object sender, EventArgs e)
        {
            try
            {
                lblID.Text = HastaProfilSayfasi.idxx;
                baglanti.Open();
                SqlCommand listele = new SqlCommand("select tbl_lab.lab_id,tbl_lab.lab_tahlil_id,tbl_lab.lab_test_id,tbl_testler.test_adi,lab_aciklama,tbl_tahliller.tahlil_doktor_id,tbl_tahliller.tahlil_hasta_id,tbl_tahliller.tahlil_klinik_id,tbl_lab.lab_tarih " +
                    "from tbl_lab INNER JOIN tbl_tahliller on tbl_tahliller.tahlil_id=lab_tahlil_id " +
                    "INNER JOIN tbl_testler on tbl_testler.test_id=tbl_lab.lab_test_id where tbl_tahliller.tahlil_hasta_id=@id",baglanti);
                listele.Parameters.AddWithValue("@id", lblID.Text);
                da = new SqlDataAdapter(listele);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");
            }
        }
    }
}
