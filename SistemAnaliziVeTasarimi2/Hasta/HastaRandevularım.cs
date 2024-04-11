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
    public partial class HastaRandevularım : Form
    {
        public static SqlDataAdapter da;
        public static DataTable dt;
        public static SqlDataReader dr;
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public HastaRandevularım()
        {
            InitializeComponent();
        }

        private void HastaRandevularım_Load(object sender, EventArgs e)
        {
            try
            {
                if (bag.State == ConnectionState.Open)
                    bag.Close();
                bag.Open();
                Randevularım.Text = HastaProfilSayfasi.idx;
                SqlCommand görüntüle = new SqlCommand("Select tbl_randevular.randevuid,tbl_klinikler.klinik_adi,tbl_randevular.randevutarih,tbl_randevular.randevusaat,tbl_hasta.TcNo,tbl_hasta.isim,tbl_hasta.soyisim from tbl_randevular INNER JOIN tbl_hasta on tbl_randevular.randevuhastaid=tbl_hasta.TcNo INNER JOIN tbl_klinikler ON tbl_randevular.randevu_klinik_id=tbl_klinikler.klinik_id where tbl_hasta.TcNo=@id", bag);
                görüntüle.Parameters.AddWithValue("@id", Randevularım.Text);
                da = new SqlDataAdapter(görüntüle);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bag.Close();
            }
            catch
            {
                MessageBox.Show("HATA!! Lütfen daha sonra tekrar deneyiniz!!");

            }

        }
    }
}
