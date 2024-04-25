using SistemAnaliziVeTasarimi2.Doktor;
using SistemAnaliziVeTasarimi2.Laboratuvar;
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

namespace SistemAnaliziVeTasarimi2.ADMİN
{
    public partial class AdminYöneticiPaneli : Form
    {
        public AdminYöneticiPaneli()
        {
            InitializeComponent();
        }

        private void btnSekreterKayit_Click(object sender, EventArgs e)
        {
            SekreterKayıtOlSayfasi skos = new SekreterKayıtOlSayfasi();
            skos.Show();
            
        }

        private void btnDoktorKayit_Click(object sender, EventArgs e)
        {
            DoktorKayıtOlSayfasi dkos = new DoktorKayıtOlSayfasi();
            dkos.Show();
            
        }

        private void btnLabPKayit_Click(object sender, EventArgs e)
        {
            LaboratuvarKayıtOlSayfasi lkos = new LaboratuvarKayıtOlSayfasi();
            lkos.Show();
        }
    }
}
