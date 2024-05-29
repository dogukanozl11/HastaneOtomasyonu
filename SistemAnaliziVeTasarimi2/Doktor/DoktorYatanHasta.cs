using SistemAnaliziVeTasarimi2.ADMİN;
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
//Verileri Ekle butonuna basınca değil Bitti butonuna basınca toplu olarak veritabanına gönderme işlemi yapılacak.
//Seçenek Yatan hasta ID ye göre veri tabanında boş yerlere ekleme yapıcak her seferinde farklı kayıt oluşturmıyacak.
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
        void klinkgetir()
        {
            SqlCommand c = new SqlCommand("select * from tbl_klinikler where klinik_id < 14 or klinik_id > 18", bag);
            helper.combo(c, "klinik_id", "klinik_adi", comboBox5);

        }
        void a()
        {
            SqlCommand c = new SqlCommand("select * from tbl_ameliyat", bag);
            helper.combo(c, "ameliyat_id", "ameliyat_adi", comboBox1);

        }
        void b()
        {
            SqlCommand c = new SqlCommand("select * from tbl_serum", bag);
            helper.combo(c, "serum_id", "serum_adi", comboBox2);

        }
        void c()
        {
            SqlCommand c = new SqlCommand("select * from tbl_ilaclar", bag);
            helper.combo(c, "ilac_id", "ilac_adi", comboBox3);

        }

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
                klinkgetir();
                a();
                b();
                c();
            }
            catch
            {
                MessageBox.Show("Hata! Lütfen daha sonra tekrar deneyiniz");

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

        private void btnBitti_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            listBox1.Items.Clear();
            comboBox2.Text = "";
            listBox2.Items.Clear();
            comboBox3.Text = "";
            listBox3.Items.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxHastasID.Text != "" && comboBox1.SelectedIndex != 0)
            {
                try
                {
                    bag.Open();
                    string sql = "insert into tbl_tedavi(ameliyat_id,tedavi_hasta_id)values(@p1,@p2)";
                    SqlCommand cmd = new SqlCommand(sql, bag);
                    cmd.Parameters.AddWithValue("@p2", maskedTextBoxKlinikID.Text);
                    cmd.Parameters.AddWithValue("@p1", comboBox1.SelectedValue);
                    cmd.ExecuteNonQuery();
                    bag.Close();
                    listBox1.Items.Add(comboBox1.Text);
                }
                catch
                {
                    MessageBox.Show("Hata!! Lütfen daha sonra tekrar deneyniz.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxHastasID.Text != "" && comboBox2.SelectedIndex != 0)
            {
                try
                {
                    bag.Open();
                    string sql = "insert into tbl_tedavi(serum_id,tedavi_hasta_id)values(@p1,@p2)";
                    SqlCommand cmd = new SqlCommand(sql, bag);
                    cmd.Parameters.AddWithValue("@p2", maskedTextBoxKlinikID.Text);
                    cmd.Parameters.AddWithValue("@p1", comboBox2.SelectedValue);
                    cmd.ExecuteNonQuery();
                    bag.Close();
                    listBox2.Items.Add(comboBox2.Text);
                }
                catch
                {
                    MessageBox.Show("Hata!! Lütfen daha sonra tekrar deneyniz.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxHastasID.Text != "" && comboBox3.SelectedIndex != 0)
            {
                try
                {
                    bag.Open();
                    string sql = "insert into tbl_tedavi(tedavi_ilac_id,tedavi_hasta_id)values(@p1,@p2)";
                    SqlCommand cmd = new SqlCommand(sql, bag);
                    cmd.Parameters.AddWithValue("@p2", maskedTextBoxKlinikID.Text);
                    cmd.Parameters.AddWithValue("@p1", comboBox3.SelectedValue);
                    cmd.ExecuteNonQuery();
                    bag.Close();
                    listBox3.Items.Add(comboBox3.Text);
                }
                catch
                {
                    MessageBox.Show("Hata!! Lütfen daha sonra tekrar deneyniz.");
                }
            }
        }

        private void btnNakilGonder_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox5.SelectedIndex != 0 && maskedTextBoxHastasID.Text != "")
                {
                    bag.Open();
                    string sql = "update tbl_yatan set yatan_hasta_id=@id,yatan_doktor_id=@did,yatan_klinik_id=@kid ";
                    SqlCommand cmd = new SqlCommand(sql,bag);
                    cmd.Parameters.AddWithValue("id",maskedTextBoxHastasID.Text);
                    cmd.Parameters.AddWithValue("id",comboBox4.Text);
                    cmd.Parameters.AddWithValue("id",comboBox5.Text);
                    cmd.ExecuteNonQuery();
                    bag.Close();
                    MessageBox.Show("Hasta Başarıyla Nakil Edildi.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Eksik Alanları Doldurunuz");
                }
            }
            catch 
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");
            }
            
        }

        private void btnTaburcuEt_Click(object sender, EventArgs e)
        {

        }
    }
}
