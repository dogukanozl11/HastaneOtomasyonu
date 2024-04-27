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
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();

                if (printDialog1.ShowDialog() == DialogResult.OK)
                    this.printDocument1.Print();
            }
            catch
            {
                MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");

            }

        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            try
            {


                float a = 0;
                float ypoz = 0;
                int say = 0;
                float sol = ev.MarginBounds.Left;
                float tepe = ev.MarginBounds.Top;
                string satir = null;
                Font printFont = this.listBox1.Font;
                SolidBrush firca = new SolidBrush(Color.Black);
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

                firca.Dispose();
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
                q.Parameters.AddWithValue("@id", textBox2.Text);
                q.Parameters.AddWithValue("@idd", label4.Text);
                da = new SqlDataAdapter(q);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                button3.Enabled = true;
                baglanti.Close();
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
                this.Hide();
                HastaProfilSayfasi yeni = new HastaProfilSayfasi();
                yeni.Show();
            }
            else if (karar == DialogResult.No)
            {
                MessageBox.Show("Oturum Kapatılmadı.");
            }
        }
    }
}
