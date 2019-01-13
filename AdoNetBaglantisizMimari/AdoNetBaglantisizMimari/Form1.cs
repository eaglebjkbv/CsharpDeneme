using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetBaglantisizMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String baglanti = "Data Source=BVMAC\\SQLEXPRESS;Initial Catalog=nw;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void Form1_Load(object sender, EventArgs e)
        {

            veriAl2();
        }
        DataTable dt;
        private void veriAl()
        {
            SqlConnection conn = new SqlConnection(baglanti);
            SqlDataAdapter dadp = new SqlDataAdapter("Select * from Employees", conn);
            dt = new DataTable();
            dadp.Fill(dt);


            dataGridView1.DataSource = dt;


        }
        private void veriAl2()
        {
            dataGridView1.Rows.Clear();
            SqlConnection conn = new SqlConnection(baglanti);
            SqlDataAdapter dadp = new SqlDataAdapter("Select * from Employees", conn);
            DataTable dt1 = new DataTable();
            dadp.Fill(dt1);
            foreach (DataRow item in dt1.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "False";
                dataGridView1.Rows[n].Cells[1].Value = item["EmployeeID"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["FirstName"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["LastName"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Address"].ToString();
            }







        }

        private void button2_Click(object sender, EventArgs e)
        {
            String silinecekler = "";




            foreach (DataGridViewRow item in dataGridView1.Rows)
            {

                if (item.Cells[0].Value!=null)
                {
                    if (bool.Parse(item.Cells[0].Value.ToString()))
                    {

                        silinecekler += item.Cells[1].Value+",";

                    }

                }
                

            }
            silinecekler = silinecekler.TrimEnd(new char[] { ',' });
            textBox1.Text = silinecekler;
            SqlConnection conn = new SqlConnection(baglanti);
            String komut = "Delete from Employees Where EmployeeID IN(" + silinecekler + ")";
            SqlCommand cmd =new SqlCommand("Delete from Employees Where EmployeeID IN("+silinecekler+")",conn);
            conn.Open();
            label1.Text = komut;
            cmd.ExecuteNonQuery();
            veriAl2();
        }
    }
}
