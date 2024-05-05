using SistemAnaliziVeTasarimi2.Doktor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemAnaliziVeTasarimi2.Hasta
{
    public partial class HastaRecetelerimSayfasi : Form
    {
        private StringReader myReader;    
        public static SqlDataAdapter da;
        public static DataTable dt;
        public static SqlDataReader dr;
        string ilacadi = " ";

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");
        public HastaRecetelerimSayfasi()
        {
            InitializeComponent();
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        }
        private void HastaRecetelerimSayfasi_Load(object sender, EventArgs e)
        {
            try
            {
                doktor();

                textBox2.Text = HastaProfilSayfasi.idxx;
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }

        }
        void doktor()
        {
            SqlCommand a = new SqlCommand("select * from tbl_doktor", baglanti);
            qq.combo(a, "doktor_id", "isim", comboBox1);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    label3.Text = row.Cells[4].Value.ToString();
                    richTextBox2.Text = row.Cells[3].Value.ToString();
                    label11.Text = row.Cells[1].Value.ToString();
                    //label11.Text = label4.Text;
                    baglanti.Open();
                    SqlCommand ilac = new SqlCommand("select * from tbl_ilaclar where ilac_id=@id ", baglanti);
                    ilac.Parameters.AddWithValue("@id", label3.Text);
                    SqlDataReader oku = ilac.ExecuteReader();
                    while (oku.Read())
                    {

                        richTextBox1.Text = oku[1].ToString();

                    }

                    baglanti.Close();

                }
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                printDialog1.Document = printDocument1;
                string a = "            Yazan Doktor : " + comboBox1.Text + "\n" + "İlaç Adı : "+"\n";

               
                foreach (object x in listBox1.Items)
                {
                    
                    a = a + x.ToString() + "\n";

                }
                myReader = new StringReader(a);
                //StringReader strred = new StringReader(b);
                if (printDialog1.ShowDialog() == DialogResult.OK)
                    this.printDocument1.Print();

            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }

        }
        

        //System.Drawing.Printing.PrintPageEventArgs ev;

        public void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            try
            {
                Font font = new Font("Arial", 14);
                SolidBrush firca = new SolidBrush(Color.Black);

                ev.Graphics.DrawString($"Tarih : {DateTime.Now.ToString("dd.MM.yyyy")}",font,firca,60,25);
                font = new Font("Arial", 20,FontStyle.Bold);

                ev.Graphics.DrawString("SİSTEM HASTANESİ OTOMASYONU",font,firca,160,70);
                font = new Font("Arial", 18);

                ev.Graphics.DrawString($"Doktor Bilgileri : {comboBox1.Text}",font,firca,20, 120);
                font = new Font("Arial", 18);

                ev.Graphics.DrawString("----- İlaç Listesi -----", font, firca, 300, 220);
                font = new Font("Arial", 14);

                //ev.Graphics.DrawString($"İlaç Adı :  {ilacadi}", font, firca, 30, 150);
                float ypozz = 300;
                ev.Graphics.DrawString(ilacadi, font, firca, 20, ypozz);
                
                //foreach (var item in listBox1.Items)
                //{
                //    ev.Graphics.DrawString(ilacadi, font, firca, 30, ypozz);
                //    ypozz += 50;
                    
                //}

                

                

                /*float a = 0;
                float ypoz = 0;
                int say = 0;
                float sol = ev.MarginBounds.Left;
                float tepe = ev.MarginBounds.Top;
                string satir = null;
                Font printFont = this.listBox1.Font;
                //SolidBrush firca = new SolidBrush(Color.Black);
                a = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
                while (say < a && ((satir = myReader.ReadLine()) != null))
                {
                    ypoz = tepe + (say * printFont.GetHeight(ev.Graphics));
                    ev.Graphics.DrawString(satir, printFont, firca, sol, ypoz, new StringFormat());
                    say++;
                }
                if (satir != null)
                    ev.HasMorePages = true;
                else
                    ev.HasMorePages = false;

                firca.Dispose();*/
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                label7.Text = comboBox1.Text;
                label4.Text = comboBox1.SelectedValue.ToString();
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                baglanti.Open();
                SqlCommand q = new SqlCommand("select * from tbl_receteler where recete_hasta_id=@id and recete_doktor_id=@idd ", baglanti);
                //SqlCommand q = new SqlCommand("select tbl_receteler.recete_aciklama,tbl_receteler.recete_icerik,tbl_ilaclar.ilac_adi,tbl_receteler.recete_id,tbl_doktor.doktor_id,tbl_doktor.isim,tbl_doktor.soyisim from tbl_receteler INNER JOIN tbl_ilaclar on tbl_receteler.recete_icerik=tbl_ilaclar.ilac_id INNER JOIN tbl_doktor on tbl_receteler.recete_doktor_id=tbl_doktor.doktor_id where recete_hasta_id=@id and recete_doktor_id=@idd ", baglanti);
                q.Parameters.AddWithValue("@id", textBox2.Text);
                q.Parameters.AddWithValue("@idd", label4.Text);
                da = new SqlDataAdapter(q);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                button3.Enabled = true;
                baglanti.Close();
                //dataGridView1.Columns[0].HeaderCell.Value = "Tanı";
                //dataGridView1.Columns[1].HeaderCell.Value = "İlaç İsmi";
                //dataGridView1.Columns[2].HeaderCell.Value = "Reçete ID ";
                //dataGridView1.Columns[3].HeaderCell.Value = "Doktor İsim ";
                //dataGridView1.Columns[4].HeaderCell.Value = "Hasta İsim ";
                //dataGridView1.Columns[5].HeaderCell.Value = "Hasta Soysim ";
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (label4.Text == label11.Text)
                {
                    if (listBox1.Items.Contains(richTextBox1.Text))
                        MessageBox.Show("Bu ilacı zaten eklediniz!");
                    else
                        listBox1.Items.Add(richTextBox1.Text);


                }

                else
                    MessageBox.Show("Farklı doktorların ilaçlarını aynı reçetede yazdıramazsınız");
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            DialogResult karar = new DialogResult();
            karar = MessageBox.Show("Çıkış istediğinize emin misiniz ? ", "Uyarı", MessageBoxButtons.YesNo);
            if (karar == DialogResult.Yes)
            {
                
                HastaProfilSayfasi yeni = new HastaProfilSayfasi();
                yeni.Show();
                this.Hide();
            }
            else if (karar == DialogResult.No)
            {
                MessageBox.Show("Oturum Kapatılmadı.");
            }
        }

        private void btnOnizleme_Click(object sender, EventArgs e )
        {
            Font font = new Font("Arial", 14);
            SolidBrush firca = new SolidBrush(Color.Black);
            printDialog1.Document = printDocument1;
            


            foreach (object x in listBox1.Items)
            {
                //ev.Graphics.DrawString($"İlaç Adı : {a} ", font, firca, 20, 120);
                //ilacadi = ilacadi + x.ToString() + "\n";
                ilacadi = ilacadi + $"İlaç Adı:{x.ToString()}\n";


            }
            myReader = new StringReader(ilacadi);
            //StringReader strred = new StringReader(b);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
