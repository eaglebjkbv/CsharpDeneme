using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUDSQLServer
{
    public partial class Form1 : Form
    {
        
        String baglantiCumlesi;
        SqlConnection baglanti;

        public Form1()
        {
            InitializeComponent();
        }
     
        public void listele()
        {
           if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("Select * FROM bilgi", baglanti);
            SqlDataAdapter oku = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            oku.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            baglantiCumlesi = "Data Source=HPBV\\BVSQLEXPRESS;Initial Catalog=ogrenci;Integrated Security=True";
            baglanti = new SqlConnection(baglantiCumlesi);
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNum.Text != "")
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand komut = new SqlCommand("INSERT INTO bilgi values(@num,@ad,@soyad)", baglanti);
                komut.Parameters.AddWithValue("num", Convert.ToInt16(txtNum.Text));
                komut.Parameters.AddWithValue("ad", txtAd.Text);
                komut.Parameters.AddWithValue("soyad", txtSoyad.Text);
                komut.ExecuteNonQuery();
                listele();
                txtNum.Clear();
                txtAd.Clear();
                txtSoyad.Clear();

            }
        }
    }
}
