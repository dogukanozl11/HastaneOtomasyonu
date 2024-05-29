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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemAnaliziVeTasarimi2.Doktor
{
    public partial class DoktorYatanHasta : Form
    {
        public static int id;
        public static int yatan;
        public static SqlDataAdapter da;
        public static DataTable dt;
        public static SqlDataReader dr;
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public DoktorYatanHasta()
        {
            InitializeComponent();
        }
        //void klinkgetir()
        //{
        //    SqlCommand c = new SqlCommand("select * from tbl_klinikler where klinik_id < 14 or klinik_id > 18", baglanti);
        //    qq.combo(c, "klinik_id", "klinik_adi", comboBox5);

        //}

        private void DoktorYatanHasta_Load(object sender, EventArgs e)
        {
            try
            {
                bag.Open();
                string sql = "select tbl_hasta.hasta_id,tbl_hasta.TcNo,tbl_hasta.isim,tbl_hasta.soyisim,tbl_hasta.Cinsiyet,tbl_hasta.kan,tbl_hasta.Yaş,tbl_yatan.yatan_doktor_id,tbl_yatan.yatan_klinik_id from tbl_hasta INNER JOIN tbl_yatan on tbl_hasta.Hasta_id=tbl_yatan.yatan_hasta_id where tbl_yatan.yatan_doktor_id=@id";
                SqlCommand görüntüle = new SqlCommand(sql, bag);
                görüntüle.Parameters.AddWithValue("@id", DoktorProfilSayfasi.doktorID);

                da = new SqlDataAdapter(görüntüle);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bag.Close();
            }
            catch (Exception )
            {


            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int hstID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            double hstTC = Convert.ToDouble(dataGridView1.CurrentRow.Cells[1].Value);
            string hstad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string hstSoyad = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string hstcinsiyet = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string hstKan = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string hstDT = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            string hstKlinikID = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            maskedTextBoxHastasID.Text = hstID.ToString();
            maskedTextBoxTC.Text = hstTC.ToString();
            textBoxHASTAadi.Text = hstad.ToString();
            textBoxHASTAsoyadi.Text = hstSoyad.ToString();
            textBoxCinsiyet.Text = hstcinsiyet.ToString();
            textBoxKanGrubu.Text = hstKan.ToString();
            maskedTextBoxDogumTarihi.Text = hstDT.ToString();
            maskedTextBoxKlinikID.Text = hstKlinikID.ToString();
            id = Convert.ToInt32(maskedTextBoxHastasID.Text);
        }
    }
}
