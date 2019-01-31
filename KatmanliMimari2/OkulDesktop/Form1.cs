using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OkulDAL;

namespace OkulDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeriTabani vt=new VeriTabani(1,txtAdi.Text,txtSoyadi.Text,Convert.ToDouble(txtMaas.Text));
            bool sonuc=vt.PersonelEkle();
            if(sonuc)
                MessageBox.Show("Kayıt Başarılı ");
            else
            {
                MessageBox.Show("Kayıt Başarısız !!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtID.Focus();
        }
    }
}
