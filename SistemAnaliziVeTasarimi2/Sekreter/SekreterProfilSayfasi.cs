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
    public partial class SekreterProfilSayfasi : Form
    {
        public SekreterProfilSayfasi()
        {
            InitializeComponent();
        }

        private void btnGERİ_Click(object sender, EventArgs e)
        {
            Anasayfa sgs = new Anasayfa();
            sgs.Show();
            this.Hide();
        }

        private void SekreterProfilSayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}
