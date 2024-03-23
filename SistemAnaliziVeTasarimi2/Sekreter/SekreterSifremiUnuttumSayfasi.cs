using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace SistemAnaliziVeTasarimi2.Sekreter
{
    public partial class SekreterSifremiUnuttumSayfasi : Form
    {
        public SekreterSifremiUnuttumSayfasi()
        {
            InitializeComponent();
        }

        private void btnGERİ_Click(object sender, EventArgs e)
        {
            SekreterGirisSayfasi sgs = new SekreterGirisSayfasi();
            sgs.Show();
            this.Hide();
        }
        Random rnd = new Random();
        string onayKodu;
        private void btnOnayKoduAl_Click(object sender, EventArgs e)
        {
            onayKodu=rnd.Next(100000,999999).ToString();
            MailMessage sms = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new System.Net.NetworkCredential("sistem.hastanesi@hotmail.com","12345678C#+");
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.outlook.com";
            smtpClient.EnableSsl = true;
            sms.To.Add(txtEmail.Text);
            sms.From = new MailAddress("sistem.hastanesi@hotmail.com");
            sms.Subject = "Şifre Onay Kodu.";
            sms.Body = onayKodu ;
            smtpClient.Send(sms);
            MessageBox.Show("Onay Kodu Gönderilmiştir.");
        }
    }
}
