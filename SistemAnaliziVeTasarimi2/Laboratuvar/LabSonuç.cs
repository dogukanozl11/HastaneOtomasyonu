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

namespace SistemAnaliziVeTasarimi2.Laboratuvar
{
    public partial class LabSonuç : Form
    {
        public static SqlDataAdapter da;
        public static DataTable dt;
        public static SqlDataReader dr;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public LabSonuç()
        {
            InitializeComponent();
        }

        private void LabSonuç_Load(object sender, EventArgs e)
        {
            textBox1.Text = LaboratuvarSayfasi.tahlilid;
            LaboratuvarSayfasi.tahlilid = textBox1.Text;
            try
            {


                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                baglanti.Open();
                SqlCommand testler = new SqlCommand("select tbl_lab.lab_test_id,tbl_lab.lab_tahlil_id,tbl_testler.test_id,tbl_testler.test_adi from tbl_lab INNER JOIN tbl_tahliller on tbl_tahliller.tahlil_id=tbl_lab.lab_tahlil_id INNER JOIN tbl_testler on tbl_testler.test_id = tbl_lab.lab_test_id where lab_tahlil_id=@id ", baglanti);
                testler.Parameters.AddWithValue("@id", textBox1.Text.ToString());
                da = new SqlDataAdapter(testler);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Hata!! lütfen daha sonra tekar deneyiniz.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                baglanti.Open();
                SqlCommand test = new SqlCommand("select * from tbl_testler where test_id=@id", baglanti);
                test.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[2].Value.ToString());
                SqlDataReader oku = test.ExecuteReader();
                while (oku.Read())
                {
                    textBox3.Text = oku[1].ToString();
                    textBox4.Text = oku[0].ToString();

                }
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Hata!! lütfen daha sonra tekar deneyiniz.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && dateTimePicker1.Value != null)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                    baglanti.Open();
                    SqlCommand lab = new SqlCommand("update tbl_lab set lab_tahlil_id=@id,lab_test_id=@testid,lab_tarih=@tarih,lab_aciklama=@sonuc,kontrol=@kont where lab_test_id=@tid and kontrol=2", baglanti);
                    lab.Parameters.AddWithValue("@id", textBox1.Text);
                    lab.Parameters.AddWithValue("@testid", textBox4.Text);
                    lab.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.ToShortDateString());
                    lab.Parameters.AddWithValue("@sonuc", textBox2.Text);
                    lab.Parameters.AddWithValue("@tid", textBox4.Text);
                    lab.Parameters.AddWithValue("@kont", label7.Text);
                    lab.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Sonuçlar doktora gönderilmiştir.");
                }
                catch
                {
                    MessageBox.Show("Hata!! lütfen daha sonra tekar deneyiniz.");
                }
            }
            else
                MessageBox.Show("Alanlar Boş Bıraklılamaz!");

        }

        private void btncks_Click(object sender, EventArgs e)
        {
            DialogResult karar = new DialogResult();
            karar = MessageBox.Show("Çıkış istediğinize emin misiniz ? ", "Uyarı", MessageBoxButtons.YesNo);
            if (karar == DialogResult.Yes)
            {
                this.Hide();
                Anasayfa yeni = new Anasayfa();
                yeni.Show();
            }
            else if (karar == DialogResult.No)
            {
                MessageBox.Show("Oturum Kapatılmadı.");
            }
        }
    }
}
