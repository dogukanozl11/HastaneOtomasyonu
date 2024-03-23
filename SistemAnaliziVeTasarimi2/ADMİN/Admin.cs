using SistemAnaliziVeTasarimi2.ADMİN;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
           
        }
        public void GirisYap()
        {
            AdminYöneticiPaneli ayp = new AdminYöneticiPaneli();
            ayp.Show();
            this.Hide();
        }

        private void btnSekreterKayitGeri_Click(object sender, EventArgs e)
        {
            Anasayfa ansyf = new Anasayfa();
            ansyf.Show();
            this.Hide();
        }
    }
}
