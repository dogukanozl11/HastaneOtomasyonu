using SistemAnaliziVeTasarimi2.Doktor;
using SistemAnaliziVeTasarimi2.Hasta;
using SistemAnaliziVeTasarimi2.Sekreter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemAnaliziVeTasarimi2
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void BtnHastaGiris_Click(object sender, EventArgs e)
        {
           HastaGirisSayfasi hst = new HastaGirisSayfasi();
            hst.Show();
            this.Hide();
        }

        private void BtnDoktorGiris_Click(object sender, EventArgs e)
        {
            DoktorGirisSayfasi dr = new DoktorGirisSayfasi();
            dr.Show();
            this.Hide();
        }

        private void BtnSekreterGiris_Click(object sender, EventArgs e)
        {
            SekreterGirisSayfasi skrt = new SekreterGirisSayfasi();
            skrt.Show();
            this.Hide();
        }
    }
}
