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

namespace SistemAnaliziVeTasarimi2.Doktor
{
    public partial class DoktorAcil : Form
    {
        public static string hastaid;
        public static SqlDataAdapter da;
        public static DataTable dt;
        public static SqlDataReader dr;
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public DoktorAcil()
        {
            InitializeComponent();
        }

        private void DoktorAcil_Load(object sender, EventArgs e)
        {
            try
            {
                label1.Text = Anasayfa.dtc;
                bag.Open();
                string sql = "select tbl_acil.acil_id,tbl_acil.aciklama,tbl_acil.derece,tbl_hasta.hasta_id,tbl_hasta.TcNo,tbl_hasta.isim,tbl_hasta.soyisim from tbl_acil " +
                    "INNER JOIN tbl_hasta on tbl_acil.acil_hastaid=hasta_id " +
                    "INNER JOIN tbl_klinikler on tbl_acil.acil_klinikid=tbl_klinikler.klinik_id " +
                    "INNER JOIN tbl_doktor on tbl_acil.acil_doktorid=tbl_doktor.doktor_id where tbl_doktor.TcNo=@dTC";
                SqlCommand görüntüle = new SqlCommand(sql,bag);
                görüntüle.Parameters.AddWithValue("@dTC", label1.Text);
                da = new SqlDataAdapter(görüntüle);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bag.Close();
            }
            catch
            {
                MessageBox.Show("Hata!! Lütfen daha sonra tekrar deneyiniz. ");
            }
        }

        private void btnhastasec_Click(object sender, EventArgs e)
        {
            try
            {
                bag.Open();
                string sql = "select * from tbl_acil where acil_hastaid=@id";
                SqlCommand komut = new SqlCommand(sql,bag);
                komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[3].Value.ToString());
                SqlDataReader oku = komut.ExecuteReader();
                while(oku.Read())
                {
                    textBox1.Text = oku[5].ToString();
                    hastaid = textBox1.Text;
                }
                bag.Close();
                textBox1.Text = hastaid;
                RandevuMuayene muayeneekranı = new RandevuMuayene();
                muayeneekranı.Show();
            }
            catch 
            {
                MessageBox.Show("Bir hata ile karşılaştık!! Lütfen daha sonra tekrar deneyiniz.");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int deger = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
                textBox1.Text = deger.ToString();
                hastaid = textBox1.Text;
            }
            catch 
            {
                MessageBox.Show("Bir hata ile karşılaştık!! Lütfen daha sonra tekrar deneyiniz.");
            }
        }
    }
}
