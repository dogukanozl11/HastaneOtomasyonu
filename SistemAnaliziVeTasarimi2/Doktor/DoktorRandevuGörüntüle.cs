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
            try
            {
                label1.Text = Anasayfa.dtc;
                if (bag.State == ConnectionState.Open)
                    bag.Close();
                bag.Open();
                SqlCommand c = new SqlCommand("select * from tbl_randevular where randevuhastaid=@id", bag);
                c.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[4].Value.ToString());
                SqlDataReader oku = c.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = oku[4].ToString();
                    // hastaid = textBox1.Text;
                }

                bag.Close();
                // hastaid = textBox1.Text;
                kontrolMuayene = 2;
                RandevuMuayene yeni = new RandevuMuayene();
                yeni.Show();
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }
        }
    }
}
