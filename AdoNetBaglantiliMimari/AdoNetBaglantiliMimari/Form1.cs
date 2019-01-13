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

namespace AdoNetBaglantiliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=BVMAC\\SQLEXPRESS;Database=NORTHWND;Integrated Security=true;");
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Categories", conn);
            
            conn.Open();
            SqlDataReader okuyucu=cmd.ExecuteReader();
            

            if (okuyucu.HasRows)
            {
                while (okuyucu.Read())
                {
                    KategoriSinif ks = new KategoriSinif();
                    ks.CategoryID = okuyucu[0].ToString();
                    ks.CategoryName = okuyucu[1].ToString();
                    ks.Description = okuyucu[2].ToString();
                    listBox1.Items.Add(ks);
                }
            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı");
            }
            conn.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            KategoriSinif ks= (KategoriSinif) listBox1.SelectedItem;
            label1.Text = ks.Description;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Categories", conn);

            conn.Open();
            SqlDataReader okuyucu = cmd.ExecuteReader();


            if (okuyucu.HasRows)
            {
                while (okuyucu.Read())
                {
                    ListViewItem item = new ListViewItem(okuyucu[0].ToString());
                    item.SubItems.Add(okuyucu[1].ToString());
                    item.SubItems.Add(okuyucu[2].ToString());
                    listView1.Items.Add(item);

                    
                }
            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı");
            }
            conn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            label1.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Bağlantısız Mimari ....
            SqlDataAdapter dadp = new SqlDataAdapter("Select * from Employees", conn);
            DataTable dt = new DataTable();
            dadp.Fill(dt);
            listBox2.DataSource = dt;
            listBox2.DisplayMember = dt.Columns[1].ToString();
            listBox2.ValueMember = dt.Columns[0].ToString();



            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            label4.Text = listBox2.GetItemText(listBox2.SelectedItem);
            label4.Text += listBox2.SelectedValue;
           

        }
    }
}
