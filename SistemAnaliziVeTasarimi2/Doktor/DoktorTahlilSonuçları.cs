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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SistemAnaliziVeTasarimi2.Doktor
{
    public partial class DoktorTahlilSonuçları : Form
    {
        public static string id;
        public static string hastaid;
        public static SqlDataAdapter da;
        public static DataTable dt;
        public static SqlDataReader dr;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public DoktorTahlilSonuçları()
        {
            InitializeComponent();
        }

        void yatak()
        {
            if (baglanti.State == ConnectionState.Open)
                baglanti.Close();
            baglanti.Open();
            SqlCommand a = new SqlCommand("select * from tbl_klinikler where klinik_id=@id", baglanti);
            a.Parameters.AddWithValue("@id", textBox3.Text);
            SqlDataReader oku = a.ExecuteReader();
            while (oku.Read())
            {
                label23.Text = oku[2].ToString();
                label24.Text = oku[3].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("update tbl_klinikler set yatan_hasta=@h where klinik_id=@id", baglanti);
            ekle.Parameters.AddWithValue("@id", textBox3.Text);
            ekle.Parameters.AddWithValue("@h", Convert.ToInt32(label24.Text) + 1);
            ekle.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand yatak = new SqlCommand("update tbl_klinikler set yatak_kapasite=@kapasite where klinik_id=@id ", baglanti);
            yatak.Parameters.AddWithValue("@id", textBox3.Text);
            yatak.Parameters.AddWithValue("@kapasite", Convert.ToInt32(label23.Text) - 1);
            yatak.ExecuteNonQuery();
            baglanti.Close();
            if (Convert.ToInt32(label23.Text) <= 0)
            {
                MessageBox.Show("Klinikte boş yatak yoktur");
            }
        }
        void yatanhasta()
        {
            if (baglanti.State == ConnectionState.Open)
                baglanti.Close();
            baglanti.Open();
            SqlCommand yatan = new SqlCommand("select yatan_hasta_id from tbl_yatan", baglanti);
            SqlDataReader oku = yatan.ExecuteReader();
            while (oku.Read())
            {
                listBox2.Items.Add(oku[0].ToString());
            }

        }
        void klinkgetir()
        {
            SqlCommand c = new SqlCommand("select * from tbl_klinikler where klinik_id < 14 or klinik_id > 18", baglanti);
            qq.combo(c, "klinik_id", "klinik_adi", comboBox3);
        }
        void ilac()
        {
            SqlCommand a = new SqlCommand("select * from tbl_ilaclar", baglanti);
            qq.combo(a, "ilac_id", "ilac_adi", comboBox4);
        }
        void klinikgetir2()
        {
            SqlCommand c = new SqlCommand("select * from tbl_klinikler where klinik_id < 14 or klinik_id > 18", baglanti);
            qq.combo(c, "klinik_id", "klinik_adi", comboBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                baglanti.Open();
                SqlCommand listele = new SqlCommand("SELECT tbl_lab.lab_id, tbl_lab.lab_tahlil_id, tbl_lab.lab_test_id, tbl_testler.test_adi, lab_aciklama, " +
               "tbl_tahliller.tahlil_doktor_id, tbl_tahliller.tahlil_hasta_id, tbl_hasta.isim, tbl_hasta.soyisim, " +
               "tbl_tahliller.tahlil_klinik_id, tbl_klinikler.klinik_adi, tbl_lab.lab_tarih " +
               "FROM tbl_lab " +
               "INNER JOIN tbl_tahliller ON tbl_tahliller.tahlil_id = tbl_lab.lab_tahlil_id " +
               "INNER JOIN tbl_testler ON tbl_testler.test_id = tbl_lab.lab_test_id " +
               "INNER JOIN tbl_hasta ON tbl_hasta.hasta_id = tbl_tahliller.tahlil_hasta_id " +
               "INNER JOIN tbl_klinikler ON tbl_klinikler.klinik_id = tbl_tahliller.tahlil_klinik_id " +
               "WHERE tbl_tahliller.tahlil_hasta_id = @id AND tbl_tahliller.tahlil_doktor_id = @idd AND tbl_lab.kontrol = 2", baglanti);
                listele.Parameters.AddWithValue("@idd", textBox4.Text);
                listele.Parameters.AddWithValue("@id", textBox1.Text);
                //  listele.Parameters.AddWithValue("@kont", label19.Text);
                da = new SqlDataAdapter(listele);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                if (listBox2.Items.Contains(textBox1.Text))
                {
                    panel5.Visible = true;
                    panel4.Visible = true;
                    //button1.Enabled = false;
                    //textBox1.Enabled = false;
                    button12.Visible = true;
                }
                baglanti.Close();

                // label10.Text = Doktor.dkidd;
            }
            catch
            {
                MessageBox.Show("hata!! lütfen daha sonra tekrar deneyin  ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                MessageBox.Show("Reçete ve Tanı başarıyla kaydedilmiştir.");
                textBox2.Text = "";
                comboBox4.SelectedIndex = 0;
                listBox1.Items.Clear();

                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                baglanti.Open();
                SqlCommand vezne = new SqlCommand("insert into tbl_vezne(hasta_id)values(@id) ", baglanti);
                vezne.Parameters.AddWithValue("@id", textBox1.Text);
                vezne.ExecuteNonQuery();
                baglanti.Close();

            }
            catch
            {
                MessageBox.Show("Hata!! lütfen daha sonra tekrar deneyiniz");
            }
        }

        private void DoktorTahlilSonuçları_Load(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = DoktorProfilSayfasi.klinikid;
                textBox4.Text = DoktorProfilSayfasi.doktorID;
                klinkgetir();
                klinikgetir2();
                ilac();
                yatanhasta();
                if (DoktorYatanHasta.yatan == 1)
                {
                    panel5.Visible = false;
                    panel4.Visible = false;
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    button12.Visible = true;
                    textBox1.Text = DoktorYatanHasta.id.ToString();
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                    baglanti.Open();
                    SqlCommand listele = new SqlCommand("select tbl_lab.lab_id,tbl_lab.lab_tahlil_id,lab_test_id,tbl_testler.test_adi,lab_aciklama,tbl_tahliller.tahlil_doktor_id,tbl_tahliller.tahlil_hasta_id,tbl_tahliller.tahlil_klinik_id,tbl_lab.lab_tarih from tbl_lab " +
                        "INNER JOIN tbl_tahliller on tbl_tahliller.tahlil_id=lab_tahlil_id " +
                        "INNER JOIN tbl_testler on tbl_testler.test_id=tbl_lab.lab_test_id " +
                        "where tbl_tahliller.tahlil_hasta_id=@id and tbl_tahliller.tahlil_doktor_id=@idd and tbl_lab.kontrol=2", baglanti);
                    listele.Parameters.AddWithValue("@idd", textBox4.Text);
                    listele.Parameters.AddWithValue("@id", textBox1.Text);
                    //listele.Parameters.AddWithValue("@kont", label19.Text);
                    da = new SqlDataAdapter(listele);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    baglanti.Close();
                }
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }



        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                baglanti.Open();
                SqlCommand lab = new SqlCommand("update tbl_lab set kontrol=@kont where lab_id=@id ", baglanti);
                lab.Parameters.AddWithValue("@id", label18.Text);
                lab.Parameters.AddWithValue("@kont", label19.Text);
                lab.ExecuteNonQuery();
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Hata!! lütfen daha sonra tekrar deneyiniz");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && DoktorProfilSayfasi.klinikid != "16" && DoktorProfilSayfasi.klinikid != "17" && DoktorProfilSayfasi.klinikid != "18")
                {
                    panel1.Enabled = true;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    if (DoktorProfilSayfasi.klinikid == "16" || DoktorProfilSayfasi.klinikid == "17" || DoktorProfilSayfasi.klinikid == "18")
                        MessageBox.Show("Acil doktorları paylaşım yapamaz. Nakil Sekmesini Kullanınız.");
                }
                else
                    MessageBox.Show("Bir Tahlil Seçiniz");
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try

            {
                if (comboBox3.SelectedIndex != 0)
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                    baglanti.Open();
                    SqlCommand komutdoktor = new SqlCommand("SELECT tbl_klinikler.klinik_id,tbl_doktor.doktor_id,tbl_doktor.isim FROM tbl_doktor INNER JOIN tbl_klinikler ON tbl_doktor.doktor_klinik_id=tbl_klinikler.klinik_id WHERE tbl_doktor.doktor_klinik_id=@kid", baglanti);
                    komutdoktor.Parameters.AddWithValue("@kid", comboBox3.SelectedValue.ToString());
                    qq.combo(komutdoktor, "doktor_id", "isim", comboBox5);

                    baglanti.Close();
                }
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }

        }


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                SqlCommand a = new SqlCommand("select * from tbl_tahliller where tahlil_doktor_id=@id", baglanti);
                a.Parameters.AddWithValue("@id", Convert.ToInt32(comboBox5.SelectedValue));
                SqlDataReader oku = a.ExecuteReader();
                while (oku.Read())
                {
                    label17.Text = oku[0].ToString();
                }

                baglanti.Close();

                baglanti.Open();
                SqlCommand nakil = new SqlCommand("insert into tbl_lab(lab_tahlil_id,lab_test_id,lab_tarih,lab_aciklama)values(@tahlilid,@testid,@tarih,@aciklama)", baglanti);
                nakil.Parameters.AddWithValue("@tahlilid", label17.Text);
                nakil.Parameters.AddWithValue("@testid", label7.Text);
                nakil.Parameters.AddWithValue("@aciklama", label9.Text);
                nakil.Parameters.AddWithValue("@tarih", label12.Text);
                nakil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Hasta Bilgileri Başarıyla Gönderilidi");

            }
            catch
            {
                MessageBox.Show("Hata! Lütfen daha sonra tekrar deneyiniz");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                int deger = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                int deger2 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                string deger3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string deger4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                int deger5 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
                int deger6 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value);
                string deger7 = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                int deger8 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                label6.Text = deger.ToString();
                label7.Text = deger2.ToString();
                label8.Text = deger3.ToString();
                label9.Text = deger4.ToString();
                label10.Text = deger5.ToString();
                label11.Text = deger6.ToString();
                label12.Text = deger7.ToString();
                label18.Text = deger8.ToString();
            }
            catch
            {
                MessageBox.Show("Hata! Lütfen daha sonra tekrar deneyiniz!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    panel2.Enabled = true;
                    panel1.Enabled = false;
                    panel3.Enabled = false;

                }

                else
                    MessageBox.Show("Bir Tahlil Seçiniz");
            }


            catch
            {
                MessageBox.Show("Hata! Lütfen daha sonra tekrar deneyiniz");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedIndex != 0)
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                    baglanti.Open();
                    SqlCommand komutdoktor = new SqlCommand("SELECT tbl_klinikler.klinik_id,tbl_doktor.doktor_id,tbl_doktor.isim FROM tbl_doktor INNER JOIN tbl_klinikler ON tbl_doktor.doktor_klinik_id=tbl_klinikler.klinik_id WHERE tbl_doktor.doktor_klinik_id=@kid", baglanti);
                    komutdoktor.Parameters.AddWithValue("@kid", comboBox2.SelectedValue.ToString());
                    qq.combo(komutdoktor, "doktor_id", "isim", comboBox1);

                    baglanti.Close();
                }
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }

        }


        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (DoktorProfilSayfasi.klinikid == "16" || DoktorProfilSayfasi.klinikid == "17" || DoktorProfilSayfasi.klinikid == "18")
                {


                    baglanti.Open();
                    SqlCommand nakil = new SqlCommand("update tbl_tahliller set tahlil_doktor_id=@id", baglanti);
                    nakil.Parameters.AddWithValue("@id", Convert.ToInt32(comboBox1.SelectedValue));
                    nakil.ExecuteNonQuery();
                    baglanti.Close();


                    baglanti.Open();
                    SqlCommand sil = new SqlCommand("delete from tbl_acil where acil_hasta_id=@id ", baglanti);
                    sil.Parameters.AddWithValue("@id", textBox1.Text);
                    MessageBox.Show("Hasta Başarıyla Sevk Edildi");
                    sil.ExecuteNonQuery();
                    baglanti.Close();
                }
                else
                {


                    baglanti.Open();
                    SqlCommand nakil = new SqlCommand("update tbl_tahliller set tahlil_doktor_id=@id", baglanti);
                    nakil.Parameters.AddWithValue("@id", Convert.ToInt32(comboBox1.SelectedValue));
                    nakil.ExecuteNonQuery();
                    baglanti.Close();


                    MessageBox.Show("Hasta Nakli Başarıyla Sağlandı");
                    baglanti.Close();


                }

            }
            catch
            {
                MessageBox.Show("Hata!! Lütfen daha sonra tekrar deneyiniz");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox5.SelectedIndex != 0 && comboBox3.SelectedIndex != 0)
                {
                    button5.Enabled = true;
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();

                    baglanti.Open();
                    SqlCommand nakil2 = new SqlCommand("insert into tbl_tahliller(tahlil_doktor_id,tahlil_hasta_id,tahlil_klinik_id)values(@doktorid,@hastaid,@klinikid)", baglanti);
                    nakil2.Parameters.AddWithValue("@hastaid", label10.Text);
                    nakil2.Parameters.AddWithValue("@klinikid", label11.Text);
                    nakil2.Parameters.AddWithValue("@doktorid", Convert.ToInt32(comboBox5.SelectedValue));
                    nakil2.ExecuteNonQuery();
                    baglanti.Close();



                }
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;
            panel1.Enabled = false;
            panel2.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (comboBox4.SelectedIndex != 0)
                {
                    try
                    {
                        if (baglanti.State == ConnectionState.Open)
                            baglanti.Close();
                        baglanti.Open();
                        SqlCommand recete = new SqlCommand("insert into tbl_receteler(recete_doktor_id,recete_hasta_id,recete_aciklama,recete_icerik)values(@did,@hid,@aciklama,@recete)", baglanti);
                        recete.Parameters.AddWithValue("@did", textBox4.Text);
                        recete.Parameters.AddWithValue("@hid", textBox1.Text);
                        recete.Parameters.AddWithValue("@aciklama", textBox2.Text);
                        recete.Parameters.AddWithValue("@recete", comboBox4.SelectedValue);
                        listBox1.Items.Add(comboBox4.Text);
                        button2.Enabled = true;
                        recete.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Hata!! lütfen daha sonra tekrar deneyiniz");
                    }
                }
                else
                {
                    MessageBox.Show("ilaç seçiniz");
                }
            }
            else
            {
                MessageBox.Show("Bir tanı koyunuz;");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                    baglanti.Open();
                    SqlCommand ekle = new SqlCommand("insert into tbl_yatan(yatan_hasta_id,yatan_doktor_id,yatan_klinik_id)values(@hastaid,@doktorid,@klinikid)", baglanti);
                    ekle.Parameters.AddWithValue("@hastaid", textBox1.Text);
                    ekle.Parameters.AddWithValue("@doktorid", textBox4.Text);
                    ekle.Parameters.AddWithValue("@klinikid", textBox3.Text);
                    ekle.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand guncelle = new SqlCommand("update tbl_hasta set kontrol = @kont where hasta_id=@id", baglanti);
                    guncelle.Parameters.AddWithValue("@id", textBox1.Text);
                    guncelle.Parameters.AddWithValue("@kont", label22.Text);
                    guncelle.ExecuteNonQuery();
                    baglanti.Close();


                    MessageBox.Show("Hasta Başarıyla Hastaneye Yatırılmıştır. ");
                    panel3.Enabled = false;
                    button4.Enabled = false;
                    button7.Enabled = false;
                    this.Close();
                }
                else
                    MessageBox.Show("Önce Hasta Seçiniz");
            }
            catch
            {
                MessageBox.Show("Hata! Lütfen daha sonra tekrar deneyiniz");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                baglanti.Open();
                SqlCommand lab = new SqlCommand("update tbl_lab set kontrol=@kont where lab_id=@id ", baglanti);
                lab.Parameters.AddWithValue("@id", label18.Text);
                lab.Parameters.AddWithValue("@kont", label19.Text);
                lab.ExecuteNonQuery();
                baglanti.Close();

            }
            catch
            {
                MessageBox.Show("Hata!! lütfen daha sonra tekrar deneyiniz");
            }
        }
    }
}
