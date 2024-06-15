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
    public partial class DoktorBekleyenHasta : Form
    {
        public static int kontrolMuayene = 0;
        public static string hastaid;
        public static SqlDataAdapter da;
        public static DataTable dt;
        public static SqlDataReader dr;
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public DoktorBekleyenHasta()
        {
            InitializeComponent();
        }

        private void btnSeç_Click(object sender, EventArgs e)
        {
            try
            {
                bag.Open();
                SqlCommand c = new SqlCommand("select * from tbl_bekleyenHasta where bekleyen_id=@id ", bag);
                c.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                SqlDataReader oku = c.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = oku[1].ToString();
                    hastaid = textBox1.Text;
                }
                bag.Close();
                hastaid = textBox1.Text;
                textBox1.Text = hastaid;
                kontrolMuayene = 1;
                RandevuMuayene yeni = new RandevuMuayene();

                yeni.Show();
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
                int deger = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                textBox1.Text = deger.ToString();
                hastaid = textBox1.Text;
            }
            catch
            {
                MessageBox.Show("Hata! Lütfen daha sonra tekrar deneyiniz");
            }
        }

        private void DoktorBekleyenHasta_Load(object sender, EventArgs e)
        {
            try
            {
                label1.Text = Anasayfa.dtc;
                bag.Open();
                SqlCommand görüntüle = new SqlCommand("select tbl_bekleyenHasta.bekleyen_id,tbl_hasta.hasta_id,tbl_hasta.TcNo,tbl_hasta.isim,tbl_hasta.soyisim,tbl_klinikler.klinik_adi from tbl_bekleyenHasta INNER JOIN tbl_hasta on tbl_bekleyenHasta.bekleyen_hastaid=hasta_id INNER JOIN tbl_klinikler ON tbl_bekleyenHasta.bekleyen_klinikid=tbl_klinikler.klinik_id INNER JOIN tbl_doktor ON tbl_bekleyenHasta.bekleyen_doktorid=tbl_doktor.doktor_id where tbl_doktor.TcNo=@dTC", bag);

                görüntüle.Parameters.AddWithValue("@dTC", label1.Text);
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
    }
}
