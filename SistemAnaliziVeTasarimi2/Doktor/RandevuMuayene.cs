using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace SistemAnaliziVeTasarimi2.Doktor
{
    public partial class RandevuMuayene : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public RandevuMuayene()
        {
            InitializeComponent();
        }
        void yatak()
        {
            if (baglanti.State == ConnectionState.Open)
                baglanti.Close();
            baglanti.Open();
            SqlCommand a = new SqlCommand("select * from tbl_klinikler where klinik_id=@id", baglanti);
            a.Parameters.AddWithValue("@id", maskedTextBox5.Text);
            SqlDataReader oku = a.ExecuteReader();
            while (oku.Read())
            {
                label20.Text = oku[2].ToString();
                label21.Text = oku[3].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("update tbl_klinikler set yatan_hasta=@h where klinik_id=@id", baglanti);
            ekle.Parameters.AddWithValue("@id", maskedTextBox5.Text);
            ekle.Parameters.AddWithValue("@h", Convert.ToInt32(label21.Text) + 1);
            ekle.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand yatak = new SqlCommand("update tbl_klinikler set yatak_kapasite=@kapasite where klinik_id=@id ", baglanti);
            yatak.Parameters.AddWithValue("@id", maskedTextBox5.Text);
            yatak.Parameters.AddWithValue("@kapasite", Convert.ToInt32(label20.Text) - 1);
            yatak.ExecuteNonQuery();
            baglanti.Close();
            if (Convert.ToInt32(label20.Text) <= 0)
            {
                MessageBox.Show("Klinikte boş yatak yoktur");
            }
        }
        void doktorBilgiler()
        {
            maskedTextBox2.Text = DoktorProfilSayfasi.doktorID;
            DoktorProfilSayfasi.doktorID = maskedTextBox2.Text;
            try
            {


                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                baglanti.Open();
                SqlCommand doktor = new SqlCommand("select * from tbl_doktor where doktor_id=@did ", baglanti);
                doktor.Parameters.AddWithValue("@did", maskedTextBox2.Text);
                SqlDataReader oku = doktor.ExecuteReader();
                while (oku.Read())
                {
                    maskedTextBox2.Text = oku[0].ToString();
                    maskedTextBox5.Text = oku[8].ToString();
                    maskedTextBox5.Text = DoktorProfilSayfasi.klinikid.ToString();
                }
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Hata!! Lütfen daha sonra tekrar deneyniz.");
            }
        }
        void hastaBilgiler()
        {


            try
            {
                if (maskedTextBox4.Text != "")
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                    baglanti.Open();
                    SqlCommand hasta = new SqlCommand("select * from tbl_hasta where hasta_id=@hid", baglanti);
                    hasta.Parameters.AddWithValue("@hid", maskedTextBox4.Text);
                    SqlDataReader oku = hasta.ExecuteReader();
                    while (oku.Read())
                    {
                        maskedTextBox1.Text = oku[3].ToString();
                        textBox1.Text = oku[1].ToString();
                        textBox2.Text = oku[2].ToString();
                        textBox6.Text = oku[5].ToString();
                        textBox7.Text = oku[6].ToString();
                        maskedTextBox3.Text = oku[4].ToString();
                       
                        
                    }
                    baglanti.Close();
                }


            }
            catch
            {
                MessageBox.Show("Hata!! Lütfen daha sonra tekrar deneyniz.");
            }
        }
        void testler()
        {
            try
            {


                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                baglanti.Open();
                SqlCommand testler = new SqlCommand("select * from tbl_testler ", baglanti);
                qq.combo(testler, "test_id", "test_adi", comboBox1);
            }
            catch
            {
                MessageBox.Show("Hata!! Lütfen daha sonra tekrar deneyniz.");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                maskedTextBox4.Text = DoktorRandevuGörüntüle.hastaid;
                doktorBilgiler();
                hastaBilgiler();
                testler();
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                baglanti.Open();
                SqlCommand lab = new SqlCommand("insert into tbl_lab (lab_tahlil_id,lab_test_id)values(@tid,@tidd)", baglanti);
                lab.Parameters.AddWithValue("@tid", maskedTextBox7.Text);
                lab.Parameters.AddWithValue("@tidd", comboBox1.SelectedValue);
                lab.ExecuteNonQuery();
                baglanti.Close();
                listBox1.Items.Add(comboBox1.Text);
                baglanti.Open();
                SqlCommand tedavi = new SqlCommand("insert into tbl_tedavi(tedavi_test_id,tedavi_hasta_id)values(@test,@id) ", baglanti);
                tedavi.Parameters.AddWithValue("@test", comboBox1.SelectedValue);
                tedavi.Parameters.AddWithValue("@id", maskedTextBox4.Text);
                tedavi.ExecuteNonQuery();
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Hata!! Lütfen daha sonra tekrar deneyniz.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                comboBox1.SelectedIndex = 0;
                if (maskedTextBox4.Text != "")
                {
                    baglanti.Open();
                    SqlCommand temizle = new SqlCommand("delete from tbl_randevular where randevuhastaid=@id ", baglanti);
                    temizle.Parameters.AddWithValue("@id", maskedTextBox4.Text);
                    temizle.ExecuteNonQuery();
                    baglanti.Close();
                }

            }
            catch
            {
                MessageBox.Show("Hata!! Lütfen daha sonra tekrar deneyniz.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                baglanti.Open();
                SqlCommand tahlil = new SqlCommand("insert into tbl_tahliller(tahlil_doktor_id,tahlil_hasta_id,tahlil_klinik_id)values(@did,@hid,@kid)", baglanti);

                if (maskedTextBox4.Text != "")
                {
                    tahlil.Parameters.AddWithValue("@did", maskedTextBox2.Text);
                    tahlil.Parameters.AddWithValue("@hid", maskedTextBox4.Text);
                    tahlil.Parameters.AddWithValue("@kid", maskedTextBox5.Text);

                }


                tahlil.ExecuteNonQuery();
                baglanti.Close();

                panel3.Enabled = true;
                panel4.Enabled = false;
                button5.Enabled = false;

                baglanti.Open();
                SqlCommand tahlil2 = new SqlCommand("select * from tbl_tahliller", baglanti);
                SqlDataReader oku = tahlil2.ExecuteReader();
                while (oku.Read())
                {
                    maskedTextBox7.Text = oku[0].ToString();
                }
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Hata!! Lütfen daha sonra tekrar deneyniz.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Enabled = false;
            panel4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox4.Text != "")
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                    baglanti.Open();
                    SqlCommand recete = new SqlCommand("insert into tbl_receteler(recete_doktor_id,recete_hasta_id,recete_aciklama,recete_icerik)values(@did,@hid,@aciklama,@recete)", baglanti);
                    recete.Parameters.AddWithValue("@did", maskedTextBox2.Text);
                    recete.Parameters.AddWithValue("@hid", maskedTextBox4.Text);
                    recete.Parameters.AddWithValue("@aciklama", textBox5.Text);
                    recete.Parameters.AddWithValue("@recete", textBox9.Text);
                    recete.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Reçete ve Tanı başarıyla kaydedilmiştir.");
                    baglanti.Open();
                    SqlCommand temizle = new SqlCommand("delete from  tbl_randevular where randevu_hasta_id=@id ", baglanti);
                    temizle.Parameters.AddWithValue("@id", maskedTextBox4.Text);
                    temizle.ExecuteNonQuery();
                    baglanti.Close();

                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                    baglanti.Open();
                    SqlCommand vezne = new SqlCommand("insert into vezne(hasta_id)values(@id) ", baglanti);
                    vezne.Parameters.AddWithValue("@id", maskedTextBox4.Text);
                    vezne.ExecuteNonQuery();
                    baglanti.Close();
                }



            }
            catch
            {
                MessageBox.Show("Hata!! lütfen daha sonra tekrar deneyiniz");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox4.Text != "")
                {
                    yatak();
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                    baglanti.Open();
                    SqlCommand ekle = new SqlCommand("insert into tbl_yatan(yatan_hasta_id,yatan_doktor_id,yatan_klinik_id)values(@hastaid,@doktorid,@klinikid)", baglanti);
                    ekle.Parameters.AddWithValue("@hastaid", maskedTextBox4.Text);
                    ekle.Parameters.AddWithValue("@doktorid", maskedTextBox2.Text);
                    ekle.Parameters.AddWithValue("@klinikid", maskedTextBox5.Text);
                    ekle.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand temizle = new SqlCommand("delete from  tbl_randevular where randevu_hasta_id=@id ", baglanti);
                    temizle.Parameters.AddWithValue("@id", maskedTextBox4.Text);
                    temizle.ExecuteNonQuery();
                    baglanti.Close(); ;

                    baglanti.Open();
                    SqlCommand guncelle = new SqlCommand("update tbl_hasta set kontrol = @kont where hasta_id=@id", baglanti);
                    guncelle.Parameters.AddWithValue("@id", maskedTextBox4.Text);
                    guncelle.Parameters.AddWithValue("@kont", label15.Text);
                    guncelle.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Hasta Başarıyla Hastaneye Yatırılmıştır. ");
                }
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }
        }
    }
}
