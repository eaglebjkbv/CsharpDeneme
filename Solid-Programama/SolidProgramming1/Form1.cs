using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidProgramming1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calisan calisan = new Calisan();
           


            calisan.Cno = 1;

            calisan.Profil.Ad = "Bülent";
            calisan.Profil.Soyad = "Vardal";
            calisan.Profil.Yas = 12;
            calisan.Adres.Il = "İzmir";
            string[] bilgi= {calisan.Profil.Ad, calisan.Profil.Soyad};

            listView1.Items.Add(new ListViewItem(bilgi));
            listView1.Items.Add(calisan.Profil.Ad);
            listView1.Items.Add(calisan.Profil.Soyad);
            listView1.Items.Add(calisan.Profil.Yas.ToString());
            listView1.Items.Add(calisan.Adres.Il);




        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
