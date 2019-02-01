using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CxliteUygulama2
{
    public partial class Form1 : Form
    {
        String aktifPoint;
        String aktifPLC;
        int guncelleme = 1;
        String cxliteBaglanti;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Title = "PLC Bağlantı için Dosya Seçiniz.";
            openFileDialog1.Filter = "CX Sever Proje Dosyası (*.cdm)|*.cdm| Tüm dosyalar (*.*)|*.* ";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if(sonuc==DialogResult.OK && openFileDialog1.FileName != "")
            {
                cxsLiteCtrl1.ProjectName = openFileDialog1.FileName.ToString();
                cxliteBaglanti = cxsLiteCtrl1.ProjectName;
                listBoxPLC.DataSource = cxsLiteCtrl1.Devices;
                String[] isim = null;
                aktifPLC = listBoxPLC.Items[0].ToString();
                cxsLiteCtrl1.ListPoints(aktifPLC, out isim);
                listBoxPoint.DataSource = isim;
            }
        }

        private void listBoxPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktifPoint=listBoxPoint.Items[listBoxPoint.SelectedIndex].ToString();
            textBoxAktifPoint.Text = aktifPoint;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            object Value = null;
            bool Quality = false;
            if (cxsLiteCtrl1.Read(aktifPLC, aktifPoint, out Value, out Quality))
                textBoxDeger.Text = Value.ToString();
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            cxsLiteCtrl1.Disconnect();
        }

        private void buttonDegerGetir_Click(object sender, EventArgs e)
        {
            cxsLiteCtrl1.GetData(aktifPLC, aktifPoint, guncelleme);
            timer1.Enabled = true;
        }

        private void listBoxPLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] isim = null;
            aktifPLC = listBoxPLC.Items[listBoxPLC.SelectedIndex].ToString();
            cxsLiteCtrl1.ListPoints(aktifPLC, out isim);
            listBoxPoint.DataSource = isim;
        }

        private void buttonDegerDurdur_Click(object sender, EventArgs e)
        {
            cxsLiteCtrl1.StopData(aktifPLC, aktifPoint);
            textBoxDeger.Clear();
            timer1.Enabled = false;
        }
    }
}
