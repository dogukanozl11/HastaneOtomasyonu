using SistemAnaliziVeTasarimi2.ADMİN;
using SistemAnaliziVeTasarimi2.Sekreter;
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

namespace SistemAnaliziVeTasarimi2
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            string sql = "select * from tbl_admin where id=@prm1 and sifre=@prm2";
            SqlDataAdapter da = new SqlDataAdapter(sql,bag);
            da.SelectCommand.Parameters.AddWithValue("@prm1", txtid.Text);
            da.SelectCommand.Parameters.AddWithValue("@prm2", txtsifre.Text);
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                AdminYöneticiPaneli ayp = new AdminYöneticiPaneli();
                ayp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void btnSekreterKayitGeri_Click(object sender, EventArgs e)
        {
            Anasayfa ansyf = new Anasayfa();
            ansyf.Show();
            this.Hide();
        }
    }
}
