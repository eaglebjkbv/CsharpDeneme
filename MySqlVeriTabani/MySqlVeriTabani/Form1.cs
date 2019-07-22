using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace MySqlVeriTabani
{
    public partial class Form1 : Form
    {
        public MySqlConnection mysqlBaglanti=new MySqlConnection("Server = localhost; Database=restProje;Uid=bv;Pwd='kartal1903';AllowUserVariables=True;UseCompression=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglan();



        }

        private ConnectionState baglan()
        {
            try
            {
                mysqlBaglanti.Open();
                if (mysqlBaglanti.State != ConnectionState.Closed)
                {
                    MessageBox.Show("Bağlandı");
                }
                else
                {
                    MessageBox.Show("Maalesef bağlanamadı");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Bağlantı olamadı : " + err.Message);
            }

            return mysqlBaglanti.State;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (mysqlBaglanti.State== ConnectionState.Open)
            {
                MySqlCommand ekle=new MySqlCommand("insert into plcdeger (tarih,saat,deger) values(@tarih,@saat,@deger)",mysqlBaglanti);
                ekle.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("d"));
                ekle.Parameters.AddWithValue("@saat", DateTime.Now.ToString("t"));
                ekle.Parameters.AddWithValue("@deger", textBox1.Text);

                int sonuc = ekle.ExecuteNonQuery();
                
            }

        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            mysqlBaglanti.Close();
        }
    }
}
