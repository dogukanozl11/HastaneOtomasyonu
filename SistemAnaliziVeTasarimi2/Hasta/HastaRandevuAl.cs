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
using System.Reflection.Emit;



namespace SistemAnaliziVeTasarimi2.Hasta
{
    public partial class HastaRandevuAl : Form
    {
        bool randevualabilir = true;
        string saat = "";
        Button btn;
        public HastaRandevuAl()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        void klinik()
        {
            //klinik vt si düzenlenip yapılacak!!!!!!!!!!
            SqlCommand c = new SqlCommand("select * from tbl_klinikler where klinik_id < 16 or klinik_id > 18", bag);
            qq.combo(c, "klinik_id", "klinik_adi", cmbKlinik);
        }
        void randevu()
        {
            try
            {
                
                bag.Open();
                if (cmbKlinik.SelectedIndex != 0 && cmbDoktor.SelectedIndex != 0)
                {
                    foreach (Control item in panel2.Controls)
                        if (item is Button) item.BackColor = Color.Green; //Butonların Renginİ yeşil yaptım.
                    randevualabilir = true;
                    panel2.Enabled = true;
                    SqlCommand randevu = new SqlCommand("Select * from tbl_randevular where randevu_klinik_id=@kid and randevu_doktor_id=@did and randevutarih=@tarih ", bag);
                    randevu.Parameters.AddWithValue("@kid", cmbKlinik.SelectedValue.ToString());
                    randevu.Parameters.AddWithValue("@did", cmbDoktor.SelectedValue.ToString());
                    randevu.Parameters.AddWithValue("@tarih", dtpTarih.Value.ToShortDateString());
                    qq.veri_getir(randevu);
                    while (qq.dr.Read())
                    {
                        foreach (Control item in panel2.Controls)
                        {
                            if (item is Button && item.Text == qq.dr["randevusaat"].ToString())
                            {
                                item.BackColor = Color.Red;

                                if (txtHastaid.Text == qq.dr["hasta_id"].ToString())
                                {
                                    MessageBox.Show("Bu tarihte bir randevunuz var lütfen başka tarih seçiniz!");
                                    randevualabilir = false;

                                }
                            }
                        }
                    }

                }
                else
                    panel2.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Bu tarihte hazırda bekleyen bir randevunuz var!!");
                this.Close();
            }
        }
        void tc()
        {
            label6.Text = Anasayfa.htc;

            bag.Open();
            SqlCommand id = new SqlCommand("select * from tbl_hasta where TcNo=@TC", bag);
            id.Parameters.AddWithValue("@TC", SqlDbType.NVarChar).Value = label6.Text;
            SqlDataReader oku = id.ExecuteReader();
            while (oku.Read())
            {
                txtHastaid.Text = oku[3].ToString();
            }
            bag.Close();
        }
        private void HastaRandevuAl_Load(object sender, EventArgs e)
        {
            try
            {
                klinik();
                //textBox1.Text = Hasta_bilgiler.tc;
                tc();
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }
        }
        private void cmbKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbKlinik.SelectedIndex != 0)
                {
                    SqlCommand doktor = new SqlCommand("SELECT tbl_klinikler.klinik_id,tbl_doktor.doktor_id,tbl_doktor.isim FROM tbl_doktor INNER JOIN tbl_klinikler ON tbl_doktor.doktor_klinik_id=tbl_klinikler.klinik_id WHERE tbl_doktor.doktor_klinik_id=@kid", bag);
                    doktor.Parameters.AddWithValue("@kid", cmbKlinik.SelectedValue.ToString());
                    qq.combo(doktor, "doktor_id", "isim", cmbDoktor);
                }
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (bag.State == ConnectionState.Open)
                    bag.Close();
                bag.Open();
                if (cmbKlinik.SelectedIndex != 0 && cmbDoktor.SelectedIndex != 0 && btn.BackColor != Color.Red && randevualabilir == true)
                {
                    SqlCommand randevuekle = new SqlCommand("insert into tbl_randevular(randevuhastaid,randevutarih,randevusaat,randevu_klinik_id,randevu_doktor_id)values(@id,@tarih,@saat,@kid,@did)", bag);
                    randevuekle.Parameters.AddWithValue("@id", txtHastaid.Text.ToString());
                    randevuekle.Parameters.AddWithValue("@tarih", dtpTarih.Value.ToShortDateString());
                    randevuekle.Parameters.AddWithValue("@saat", saat);
                    randevuekle.Parameters.AddWithValue("@kid", cmbKlinik.SelectedValue.ToString());
                    randevuekle.Parameters.AddWithValue("@did", cmbDoktor.SelectedValue.ToString());
                    randevuekle.ExecuteNonQuery();
                    bag.Close();
                    MessageBox.Show(txtHastaid.Text + "TC'li kişiye " + dtpTarih.Value.ToShortDateString() + " Tarihinde  Saat" + saat + "'a randevu alınmıştır");
                    cmbKlinik.SelectedIndex = cmbDoktor.SelectedIndex = 0;
                    randevu();
                }
            }
            catch
            {
                MessageBox.Show("Hataaaaaaaaaaaaaaaaaa!! Lütfen Daha Sonra Tekar Deneyin.");
            }

        }
        
        #region RandevuBtn
        private void button2_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            saat = btn.Text;
        }


        #endregion

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                randevu();
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }
        }
    }
}
