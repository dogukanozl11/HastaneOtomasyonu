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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemAnaliziVeTasarimi2.Doktor
{
    public partial class DoktorRandevuGörüntüle : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public DoktorRandevuGörüntüle()
        {
            InitializeComponent();
        }
        public static int kontrolMuayene = 0;
        public static string hastaid;
        public static SqlDataAdapter da;
        public static DataTable dt;
        public static SqlDataReader dr;

        private void DoktorRandevuGörüntüle_Load(object sender, EventArgs e)
        {
            Bilgigetir();
        }
        public void Bilgigetir()
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int deger = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
                textBox1.Text = deger.ToString();
                hastaid = textBox1.Text;
            }
            catch
            {
                MessageBox.Show("Hata! lütfen daha sonra tekrar deneyiniz!");
            }
        }

        private void btnHastaSeç_Click(object sender, EventArgs e)
        { 
            //Eski Seç butonu

            //try
            //{
            //    label1.Text = Anasayfa.dtc;
 
            //    bag.Open();
            //    SqlCommand c = new SqlCommand("select * from tbl_randevular where randevuhastaid=@id", bag);
            //    c.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[5].Value.ToString());
            //    SqlDataReader oku = c.ExecuteReader();
            //    while (oku.Read())
            //    {
            //        textBox1.Text = oku[4].ToString();
            //        // hastaid = textBox1.Text;
            //    }

            //    bag.Close();
            //    // hastaid = textBox1.Text;
            //    kontrolMuayene = 2;
            //    RandevuMuayene yeni = new RandevuMuayene();
            //    yeni.Show();
            //    bag.Open();
            //    SqlCommand sil = new SqlCommand("delete from tbl_randevular where randevuhastaid=@id",bag);
            //    sil.Parameters.AddWithValue("@id", textBox1.Text);
            //    sil.ExecuteNonQuery();
            //    bag.Close();

            //}
            //catch
            //{
            //    MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            //}
            try
            {
                label1.Text = Anasayfa.dtc;

                // Randevu bilgilerini getir ve textBox1'e yaz
                bag.Open();
                SqlCommand c = new SqlCommand("SELECT * FROM tbl_randevular WHERE randevuhastaid=@id", bag);
                c.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[5].Value.ToString());
                SqlDataReader oku = c.ExecuteReader();
                if (oku.Read())
                {
                    textBox1.Text = oku["randevuhastaid"].ToString(); // Doğru sütunu kontrol et
                }
                oku.Close();
                bag.Close();

                // Randevu kaydını sil
                bag.Open();
                SqlCommand sil = new SqlCommand("DELETE FROM tbl_randevular WHERE randevuhastaid=@id", bag);
                sil.Parameters.AddWithValue("@id", textBox1.Text);
                int rowsAffected = sil.ExecuteNonQuery();
                bag.Close();

                if (rowsAffected > 0)
                {
                    

                    // Yeni formu aç
                    kontrolMuayene = 2;
                    RandevuMuayene yeni = new RandevuMuayene();
                    yeni.Show();
                }
                else
                {
                    MessageBox.Show("Randevu kaydı bulunamadı veya silinemedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz\n" + ex.Message);
            }
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            try
            {
                bag.Open();
                SqlCommand sil = new SqlCommand("delete from tbl_randevular where randevuid=@id", bag);
                sil.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                sil.ExecuteNonQuery();
                bag.Close();

                MessageBox.Show("Seçili Hasta Randevusu Başarıyla Silindi.");

                Bilgigetir();

            }
            catch
            {

                MessageBox.Show("Hata!! Lüten daha sonra tekrar deneyin.");
            }
            
        }
    }
}
