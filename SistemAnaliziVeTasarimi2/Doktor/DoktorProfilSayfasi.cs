﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemAnaliziVeTasarimi2.Doktor
{
    public partial class DoktorProfilSayfasi : Form
    {
        public DoktorProfilSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        private void btnGERİ_Click(object sender, EventArgs e)
        {
            //Anasayfa dgs = new Anasayfa();
            //dgs.Show();
            //this.Hide();
            DialogResult karar = new DialogResult();
            karar = MessageBox.Show("Çıkış istediğinize emin misiniz ? ", "Uyarı", MessageBoxButtons.YesNo);
            if (karar == DialogResult.Yes)
            {
                this.Hide();
                Anasayfa yeni = new Anasayfa();
                yeni.Show();
            }
            else if (karar == DialogResult.No)
            {
                MessageBox.Show("Oturum Kapatılmadı.");
            }
        }
        private void DoktorProfilSayfasi_Load(object sender, EventArgs e)
        {
            try
            {
                lblTc.Text = Anasayfa.dtc;
                bag.Open();
                string sql = "select * from tbl_doktor where TcNo=@prm1";
                SqlCommand tc = new SqlCommand(sql,bag);
                tc.Parameters.AddWithValue("@prm1", lblTc.Text);
                SqlDataReader oku = tc.ExecuteReader();
                while (oku.Read())
                {
                    this.lblTc.Text = oku[3].ToString();
                    lblisim.Text = oku[1].ToString();
                    lblSoyisim.Text = oku[2].ToString();
                    lblKlinik.Text = oku[9].ToString(); 
                }

            }
            catch 
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");
            }

        }
        #region YanButtonlar
        private void btnKullanici_Click(object sender, EventArgs e)
        {
            DoktorBilgileri DBS = new DoktorBilgileri();
            DBS.Show();
        }

        private void btnRandevularım_Click(object sender, EventArgs e)
        {
            DoktorRandevuGörüntüle DRG = new DoktorRandevuGörüntüle();
            DRG.Show();
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            DoktorRandevuSil DRS = new DoktorRandevuSil();
            DRS.Show();
        }

        private void btnBekleyenHasta_Click(object sender, EventArgs e)
        {
            DoktorBekleyenHasta DBH = new DoktorBekleyenHasta();
            DBH.Show();
        }

        private void btnTahlilSonuçları_Click(object sender, EventArgs e)
        {
            DoktorTahlilSonuçları DTS = new DoktorTahlilSonuçları();
            DTS.Show();
        }

        private void btnAcil_Click(object sender, EventArgs e)
        {
            DoktorAcil DA = new DoktorAcil();
            DA.Show();
        }

        private void btnYatanHasta_Click(object sender, EventArgs e)
        {
            DoktorYatanHasta DYH = new DoktorYatanHasta();
            DYH.Show();
        }

        #endregion
    }
}
