using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemAnaliziVeTasarimi2.Sekreter
{
    public partial class SekreterGirisSayfasi : Form
    {
        public SekreterGirisSayfasi()
        {
            InitializeComponent();
        }

        private void btnGERİ_Click(object sender, EventArgs e)
        {
            Anasayfa ansyf = new Anasayfa();
            ansyf.Show();
            this.Hide();
        }

        private void btnSekreterKayıtOl_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.Show();
            this.Hide();
        }

        private void btnSekreterSifremiUnuttun_Click(object sender, EventArgs e)
        {
           SekreterSifremiUnuttumSayfasi ssus = new SekreterSifremiUnuttumSayfasi();
            ssus.Show();
            this.Hide();
        }

        private void btnSekreterGirisYap_Click(object sender, EventArgs e)
        {
            SekreterProfilSayfasi sps = new SekreterProfilSayfasi();
            sps.Show();
            this.Hide();
        }
    }
}
