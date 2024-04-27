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

namespace SistemAnaliziVeTasarimi2.Laboratuvar
{
    public partial class LaboratuvarSayfasi : Form
    {
        public static string tahlilid;
        public static SqlDataAdapter da;
        public static DataTable dt;
        public static SqlDataReader dr;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public LaboratuvarSayfasi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void Laboratuvar_Load(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                baglanti.Open();
                SqlCommand görüntüle = new SqlCommand("select tbl_lab.lab_id,tbl_lab.lab_tahlil_id,tbl_lab.lab_test_id,tbl_tahliller.tahlil_doktor_id,tbl_tahliller.tahlil_hasta_id,tbl_tahliller.tahlil_klinik_id from tbl_lab INNER JOIN tbl_tahliller on tbl_tahliller.tahlil_id=tbl_lab.lab_tahlil_id where kontrol=1 or kontrol is null", baglanti);

                da = new SqlDataAdapter(görüntüle);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("hata!! lütfen daha sonra tekrar deneyin");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                //baglanti.Open();
                //SqlCommand c = new SqlCommand("select * from lab where lab_tahlil_id=@id", baglanti);
                //c.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                //SqlDataReader oku = c.ExecuteReader();
                //while (oku.Read())
                //{
                //    textBox1.Text = oku[1].ToString();

                //}

                //baglanti.Close();
                baglanti.Open();
                SqlCommand a = new SqlCommand("update tbl_lab set kontrol=2 where lab_tahlil_id=@idd", baglanti);
                a.Parameters.AddWithValue("@idd", textBox1.Text);
                a.ExecuteNonQuery();
                baglanti.Close();
                LabSonuç yeni = new LabSonuç();
                yeni.Show();
            }
            catch
            {
                MessageBox.Show("hata!! lütfen daha sonra tekrar deneyin");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int deger = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            textBox1.Text = deger.ToString();
            tahlilid = textBox1.Text;
        }

        private void bntCıkıs_Click(object sender, EventArgs e)
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
