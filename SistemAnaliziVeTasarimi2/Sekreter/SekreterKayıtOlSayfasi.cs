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
    public partial class SekreterKayıtOlSayfasi : Form
    {
        public SekreterKayıtOlSayfasi()
        {
            InitializeComponent();
        }

        private void btnSekreterKayitGeri_Click(object sender, EventArgs e)
        {
            SekreterGirisSayfasi sgs = new SekreterGirisSayfasi();
            sgs.Show();
            this.Hide();
        }
    }
}
