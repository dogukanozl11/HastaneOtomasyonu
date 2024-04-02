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

namespace SistemAnaliziVeTasarimi2.ADMİN
{
    public partial class iletisim : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public iletisim()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                if (bag.State == ConnectionState.Open)
                    bag.Close();
                bag.Open();
                SqlCommand iletisim = new SqlCommand("insert into iletisim (iletisim_ad,iletisim_soyad,iletisim_bilgileri,talep_sikayet,iletisim_kontrol)values(@ad,@soyad,@bilgiler,@sikayet,@kontrol)", bag);
                iletisim.Parameters.AddWithValue("@ad", textBox1.Text);
                iletisim.Parameters.AddWithValue("@soyad", textBox2.Text);
                iletisim.Parameters.AddWithValue("@bilgiler", textBox3.Text);
                iletisim.Parameters.AddWithValue("@sikayet", textBox4.Text);
                iletisim.Parameters.AddWithValue("@kontrol", label6.Text);
                iletisim.ExecuteNonQuery();
                bag.Close();
            }
            catch 
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");
            }
        }
    }
}
