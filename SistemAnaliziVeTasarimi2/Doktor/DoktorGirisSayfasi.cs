﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemAnaliziVeTasarimi2.Doktor
{
    public partial class DoktorGirisSayfasi : Form
    {
        public DoktorGirisSayfasi()
        {
            InitializeComponent();
        }

        private void BtnGERİ_Click(object sender, EventArgs e)
        {
            Anasayfa ansyf = new Anasayfa();
            ansyf.Show();
            this.Hide();
        }
    }
}