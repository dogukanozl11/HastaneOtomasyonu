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
    public partial class HastaRandevuSilSayfasi : Form
    {
        public static SqlDataAdapter da;
        public static SqlCommand komut;
        public static DataTable dt;
        public static SqlDataReader dr;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public HastaRandevuSilSayfasi()
        {
            InitializeComponent();
        }

        private void HastaRandevuSilSayfasi_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                randevularım.Text = HastaProfilSayfasi.idxx;

                SqlCommand görüntüle = new SqlCommand("Select tbl_randevular.randevuid,tbl_klinikler.klinik_adi,tbl_randevular.randevutarih,tbl_randevular.randevusaat,tbl_hasta.TcNo,tbl_hasta.isim,tbl_hasta.soyisim " +
                    "from tbl_randevular INNER JOIN tbl_hasta on tbl_randevular.randevuhastaid=tbl_hasta.TcNo " +
                    "INNER JOIN tbl_klinikler ON tbl_randevular.randevu_klinik_id=tbl_klinikler.klinik_id where tbl_hasta.hasta_id=@id", baglanti);
                görüntüle.Parameters.AddWithValue("@id", randevularım.Text);
                da = new SqlDataAdapter(görüntüle);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("HATA!! Lütfen daha sonra tekrar deneyiniz!!");

            }
        }

        private void btnRandevuiptal_Click(object sender, EventArgs e)
        {
            try
            {
                HastaRandevuSilSayfasi ss = new HastaRandevuSilSayfasi();
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Seçilen Randevuyu Silmek İStiyor musunuz ?", "Randevu Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand sil = new SqlCommand("delete from tbl_randevular where randevuid=@id", baglanti);
                    sil.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    sil.ExecuteNonQuery();
                    baglanti.Close();
                    ss.Show();
                    this.Hide();
                }
                
            }
            catch
            {
                MessageBox.Show("Hata!! Lütfen Daha Sonra Tekrar Deneyin.");
            }

        }
    }
}
