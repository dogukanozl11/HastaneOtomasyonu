using SistemAnaliziVeTasarimi2.Sekreter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemAnaliziVeTasarimi2.Doktor
{
    public partial class DoktorSifremiUnuttumSayfasi : Form
    {
        public DoktorSifremiUnuttumSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        private void btnGERİ_Click(object sender, EventArgs e)
        {
            DoktorGirisSayfasi dgs = new DoktorGirisSayfasi();
            dgs.Show();
            this.Hide();
        }
        Random rnd = new Random();
        string onayKodu;
        private void btnOnayKoduAl_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                onayKodu = rnd.Next(100000, 999999).ToString();
                MailMessage sms = new MailMessage();
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Credentials = new System.Net.NetworkCredential("sistem.hastanesi@hotmail.com", "12345678C#+");
                smtpClient.Port = 587;
                smtpClient.Host = "smtp.outlook.com";
                smtpClient.EnableSsl = true;
                sms.To.Add(txtEmail.Text);
                sms.From = new MailAddress("sistem.hastanesi@hotmail.com");
                sms.Subject = "Şifre Onay Kodu.";
                sms.Body = onayKodu;
                smtpClient.Send(sms);
                MessageBox.Show("Onay Kodu Gönderilmiştir.");
            }
            else
            {
                MessageBox.Show("E-MAİL Boş Bırakılamaz.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTC.Text == "" || txtYeniSifre.Text == "" || txtEmail.Text == "")
            {

                MessageBox.Show("Tc ve Şifre Boş Bırakılamaz!.....");
            }
            else if (txtOnayKodu.Text == onayKodu)
            {
                bag.Open();
                SqlCommand komut = new SqlCommand("update tbl_doktor set TcNo='" + txtTC.Text + "',sifre='" + txtYeniSifre.Text + "' where TcNo='" + txtTC.Text + "'", bag);
                komut.ExecuteNonQuery();
                MessageBox.Show("Şifre Güncellendi...");
                DoktorGirisSayfasi dgs = new DoktorGirisSayfasi();
                dgs.Show();
                this.Hide();

                bag.Close();
            }
            else
            {
                MessageBox.Show("Onay Kodunu Yanlış Girdiniz.");
            }
        }
    }
}
