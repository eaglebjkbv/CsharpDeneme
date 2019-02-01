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

namespace AdoNetBaglantiliSQL
{
    public partial class Form1 : Form
    {
        String baglantiCumlesi = "Data Source=HPBV\\BVSQLEXPRESS;Initial Catalog=PlcVeri;User ID=sa;Password=123456";
        SqlConnection baglanti = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            VeriListele();
        }
        public void VeriListele()
        {
            baglanti.ConnectionString = baglantiCumlesi;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Plc2", baglanti);
            baglanti.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tablo = new DataTable();
            tablo.Load(reader);
            dataGridView1.DataSource = tablo;
          
            
            baglanti.Close();
            baglanti.Dispose();
            

        }

        private void buttonYenile_Click(object sender, EventArgs e) => VeriListele();
    }
}
