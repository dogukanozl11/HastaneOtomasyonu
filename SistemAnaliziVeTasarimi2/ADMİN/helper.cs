using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemAnaliziVeTasarimi2.ADMİN
{
    internal class helper
    {
        public static SqlConnectionStringBuilder csb;
        public static SqlDataAdapter da;
        public static SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=sistemHastanesi;Integrated Security=True;Encrypt=False;");

        public static SqlCommand komut;
        public static DataTable dt;
        public static SqlDataReader dr;
        public static string MD5sifre(string sifre)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(sifre));

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        public static void combo(SqlCommand cmd, string id, string ad, ComboBox cb)
        {
            if (bag.State == ConnectionState.Open)
                bag.Close();
            bag.Open();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr[id] = 0;
            dr[ad] = "";
            dt.Rows.InsertAt(dr, 0);
            cb.DataSource = dt;
            cb.DisplayMember = ad;
            cb.ValueMember = id;
            bag.Close();
        }
        public static void veri_getir(SqlCommand cmd)
        {
            if (bag.State == ConnectionState.Open)
                bag.Close();
            bag.Open();
            komut = cmd;
            dr = komut.ExecuteReader();
            bag.Close();
        }
    }
}
