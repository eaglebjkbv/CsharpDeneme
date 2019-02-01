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


namespace AdoBaglantisizSQL
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
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Plc2", baglanti);
            DataTable tablo = new DataTable();
            adaptor.Fill(tablo);
            dataGridView1.DataSource = tablo;


        }
    }
}
