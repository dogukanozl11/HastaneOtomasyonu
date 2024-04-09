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

namespace SistemAnaliziVeTasarimi2.Hasta
{
    public partial class HastaProfilSayfasi : Form
    {
        public HastaProfilSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        private void btnGERİ_Click(object sender, EventArgs e)
        {
            HastaGirisSayfasi hgs = new HastaGirisSayfasi();
            hgs.Show();
            this.Hide();
        }
        public string tcno;
        private void HastaProfilSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            HastaRandevuAl HRAL = new HastaRandevuAl();
            HRAL.Show();
        }
    }
}
