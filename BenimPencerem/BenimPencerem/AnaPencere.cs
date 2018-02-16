using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenimPencerem
{
    class AnaPencere:Form

    {
        private Button btnDeneme;
        private Label lblDene;
        private RadioButton mRdb1;
        private RadioButton mRdb2;
        private RadioButton mRdb3;
        private RadioButton mRdb4;
        private RadioButton mRdb5;
        private RadioButton mRdb6;
        private GroupBox mGrp1;
        private GroupBox mGrp2;


        public AnaPencere(int genislik=800,int yukseklik=600 )
        {
            Height = yukseklik;
            Width = genislik;
            // Referans Oluşturma 
            btnDeneme = new Button();
            lblDene = new Label();
            mRdb1 = new RadioButton();
            mRdb2 = new RadioButton();
            mRdb3 = new RadioButton();
            mRdb4 = new RadioButton();
            mRdb5 = new RadioButton();
            mRdb6 = new RadioButton();
            mGrp1 = new GroupBox();
            mGrp2 = new GroupBox();

            // Özellik Değiştirme
            btnDeneme.Text = "Merhaba";
            mRdb1.Text = "Deneme 1";
            mRdb2.Text = "Deneme 2";
            mRdb3.Text = "Deneme 3";
            mRdb4.Text = "Deneme 4";
            mRdb5.Text = "Deneme 5";
            mRdb6.Text = "Deneme 6";
            mGrp1.Text = "Seçimiz";

            // Nense Pozisyonu
            btnDeneme.SetBounds(100, 100, 100, 50);
            lblDene.SetBounds(200, 100,0,0);
            lblDene.AutoSize = true;
            mRdb1.SetBounds(10, 20, 100, 30);
            mRdb2.SetBounds(10, 50, 100, 30);
            mRdb3.SetBounds(10, 80, 100, 30);
            mRdb4.SetBounds(10, 20, 100, 30);
            mRdb5.SetBounds(10, 50, 100, 30);
            mRdb6.SetBounds(10, 80, 100, 30);
            mGrp1.SetBounds(250, 100, 150, 150);
            mGrp2.SetBounds(450, 100, 150, 150);



            // Forma Nesneyi Ekleme
            Controls.Add(lblDene);
            Controls.Add(btnDeneme);
            Controls.Add(mGrp1);
            Controls.Add(mGrp2);
            mGrp1.Controls.Add(mRdb1);
            mGrp1.Controls.Add(mRdb2);
            mGrp1.Controls.Add(mRdb3);
            mGrp2.Controls.Add(mRdb4);
            mGrp2.Controls.Add(mRdb5);
            mGrp2.Controls.Add(mRdb6);



            // Nesneye Olay Ekleme
            MouseMove += AnaPencere_MouseMove;
            Load += AnaPencere_Load;
            btnDeneme.Click += BtnDeneme_Click;

            // Hepsi Aynı Click olayını çağırıyor ....
            mRdb1.Click += MRdb1_Click;
            mRdb2.Click += MRdb1_Click;
            mRdb3.Click += MRdb1_Click;
            mRdb4.Click += MRdb1_Click;
            mRdb5.Click += MRdb1_Click;
            mRdb6.Click += MRdb1_Click;


        }

        private void MRdb1_Click(object sender, EventArgs e)
        {
            String mesaj;
            // Click hangi nesneden geliyor ???? sender ile ayırt ediliyor....
            if (sender == mRdb1)
            {
                mesaj = "1. Seçildi";
            }
            else if (sender == mRdb2)
            {
                mesaj = "2. Seçildi";
            }
            else if (sender == mRdb3)
            {
                mesaj = "3. Seçildi";
            }
            else mesaj = "Diğer Seçildi";
            MessageBox.Show(mesaj);
        }

        private void BtnDeneme_Click(object sender, EventArgs e)
        {
            lblDene.Text = "Merhaba";
        }

        private void AnaPencere_Load(object sender, EventArgs e)
        {
           
        }

        private void AnaPencere_MouseMove(object sender, MouseEventArgs e)
        {
            Text = e.X + "," + e.Y;
        }
    }
}
