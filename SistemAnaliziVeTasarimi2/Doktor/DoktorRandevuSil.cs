using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemAnaliziVeTasarimi2.Doktor
{
    public partial class DoktorRandevuSil : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public static SqlDataAdapter da;
        public static DataTable dt;
        public static SqlDataReader dr;
        public DoktorRandevuSil()
        {
            InitializeComponent();
        }

        private void DoktorRandevuSil_Load(object sender, EventArgs e)
        {
            label1.Text = Anasayfa.dtc;

            try
            {

                bag.Open();
                SqlCommand görüntüle = new SqlCommand("Select tbl_randevular.randevuid,tbl_klinikler.klinik_adi,tbl_randevular.randevutarih,tbl_randevular.randevusaat,tbl_hasta.hasta_id,tbl_hasta.TcNo,tbl_hasta.isim,tbl_hasta.soyisim from tbl_randevular INNER JOIN tbl_hasta on tbl_randevular.randevuhastaid=tbl_hasta.TcNo INNER JOIN tbl_klinikler ON tbl_randevular.randevu_klinik_id=tbl_klinikler.klinik_id INNER JOIN tbl_doktor ON tbl_randevular.randevu_doktor_id=tbl_doktor.doktor_id where tbl_doktor.TcNo=@TC", bag);
                görüntüle.Parameters.AddWithValue("@TC", label1.Text);
                da = new SqlDataAdapter(görüntüle);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bag.Close();
                dataGridView1.Columns[0].HeaderCell.Value = "Randevu ID";
                dataGridView1.Columns[1].HeaderCell.Value = "Klinik Adı";
                dataGridView1.Columns[2].HeaderCell.Value = "Randevu Tarihi";
                dataGridView1.Columns[3].HeaderCell.Value = "Randevu Saat";
                dataGridView1.Columns[4].HeaderCell.Value = "Hasta ID";
                dataGridView1.Columns[5].HeaderCell.Value = "TC No";
                dataGridView1.Columns[6].HeaderCell.Value = "İsim";
                dataGridView1.Columns[7].HeaderCell.Value = "Soysim";
            }
            catch
            {
                MessageBox.Show("Hata!! Lütfen daha sonra tekrar deneyiniz.");
            }
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            try
            {
                
                bag.Open();
                //SqlCommand sil = new SqlCommand("update tbl_randevular set iptal=@ip where randevuid=@id", bag);
                SqlCommand sil = new SqlCommand("delete from tbl_randevular where randevuid=@id", bag);

                sil.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                //sil.Parameters.AddWithValue("@ip", label2.Text);
                sil.ExecuteNonQuery();
                bag.Close();


                MessageBox.Show("Seçilen Randevu Başarıyla Silindi. ");
            }
            catch
            {
                MessageBox.Show("Hata!! Lüten daha sonra tekrar deneyin.");
            }
        }
    }
}
