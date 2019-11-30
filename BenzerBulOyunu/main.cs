using System.Windows.Forms;
using System;
using System.Drawing;
namespace FindMatchGame
{
    class AnaPencere : Form
    {
        public AnaPencere()
        {
            this.Height = 400;
            this.Width = 300;
            this.Text = "Find Matched";
            this.Load += AnaPencere_Load;
        }
        PictureBox[] pb = new PictureBox[50];
        int kareBoyut = 60;
        int kareSayisi = 16;
        public void Basla()
        {
            int kareNo = 0;
            for (int i = 0; i < Math.Sqrt(kareSayisi); i++)
            {
                for (int j = 0; j < Math.Sqrt(kareSayisi); j++)
                {
                    if (basla == 0)
                    {
                        pb[kareNo] = new PictureBox();
                        pb[kareNo].Height = kareBoyut;
                        pb[kareNo].Width = kareBoyut;
                        pb[kareNo].Left = 20 + (kareBoyut + 1) * j;
                        pb[kareNo].Top = 40 + (kareBoyut + 1) * i;
                        pb[kareNo].SizeMode = PictureBoxSizeMode.StretchImage;
                        pb[kareNo].Name = kareNo.ToString();
                        this.Controls.Add(pb[kareNo]);
                        pb[kareNo].Click += pb_Clicked;
                    }
                    pb[kareNo].Image = Image.FromFile("res/bos.png");
                    kareNo++;
                }
            }
        }
        Label labelSure = new Label();
        public void AnaPencere_Load(Object sender, EventArgs e)
        {
            Button button = new Button();
            button.Height = 30;
            button.Width = 60;
            button.Left = 75;
            button.Top = 5;
            button.Text = "Yeniden";
            this.Controls.Add(button);
            button.Click += button_Tiklandi;
            labelSure.Height = 30;
            labelSure.Width = 60;
            labelSure.Left = 150;
            labelSure.Text = "Sure : 0";
            this.Controls.Add(labelSure);
            RastgeleSayiUret();
            Basla();
            Timer _mTimer = new Timer();
            _mTimer.Interval = 1000;
            _mTimer.Start();
            _mTimer.Tick += _mTimer_Tick;
        }
        int basla = 0;
        public void button_Tiklandi(Object sender, EventArgs e)
        {
            acikKalmaSuresi = 0;
            toplamSure = 0;
            bulunanSayisi = 0;
            acilanSayisi = 0;
            basla = 1;
            RastgeleSayiUret();
            Basla();
        }
        int acikKalmaSuresi = 0;
        int toplamSure = 0;
        int bulunanSayisi = 0;
        public void _mTimer_Tick(Object sender, EventArgs e)
        {
            if (bulunanSayisi < kareSayisi / 2)
            {
                toplamSure++;
                labelSure.Text = "Sure : " + toplamSure;
            }
            if (acilanSayisi == 2)
            {
                acikKalmaSuresi++;
                string isim1 = pbAcilan[0].Name;
                int issay1 = Convert.ToInt16(isim1);
                string isim2 = pbAcilan[1].Name;
                int issay2 = Convert.ToInt16(isim2);
                if (uretilenSayilar[issay1] != uretilenSayilar[issay2])
                {
                    if (acikKalmaSuresi == 3)
                    {
                        pbAcilan[0].Image = Image.FromFile("res/bos.png");
                        pbAcilan[1].Image = Image.FromFile("res/bos.png");
                        acikKalmaSuresi = 0;
                        acilanSayisi = 0;
                    }
                }
                else
                {
                    pbAcilan[0].Click -= pb_Clicked;
                    pbAcilan[1].Click -= pb_Clicked;
                    bulunanSayisi++;
                    acikKalmaSuresi = 0;
                    acilanSayisi = 0;
                }
                if (bulunanSayisi == kareSayisi / 2)
                {
                    System.Windows.Forms.MessageBox.Show(String.Format("Kazandınız. Toplam süre= {0}", toplamSure));
                }
            }
        }
        PictureBox[] pbAcilan = new PictureBox[2];
        int acilanSayisi = 0;
        int[] uretilenSayilar = new int[16];
        int[] sayiKumesi = new int[16];
        int[] yedekSayiKumesi = new int[16];

        public void RastgeleSayiUret()
        {
            Random rnd = new Random();
            int a = 16;
            for (int i = 0; i < 16; i++)
            {
                sayiKumesi[i] = i;
            }
            for (int i = 0; i < 16; i++)
            {
                int sayi = rnd.Next(0, a);
                if (sayiKumesi[sayi] > 7) uretilenSayilar[i] = sayiKumesi[sayi] % 8;
                else uretilenSayilar[i] = sayiKumesi[sayi];
                int b = 0;
                for (int j = 0; j < a; j++)
                {
                    if (j != sayi)
                    {
                        yedekSayiKumesi[b] = sayiKumesi[j];
                        b++;
                    }
                }
                sayiKumesi = yedekSayiKumesi;
                a--;
            }
        }
        public void pb_Clicked(Object sender, EventArgs e)
        {
            if (acilanSayisi + 1 < 3)
            {
                acilanSayisi++;
                pbAcilan[acilanSayisi - 1] = (PictureBox)sender;
                string isim = pbAcilan[acilanSayisi - 1].Name;
                int issay = Convert.ToInt16(isim);
                // pbAcilan[acilanSayisi-1].BackColor=Color.Green;
                pbAcilan[acilanSayisi - 1].Image = Image.FromFile(String.Format("res/{0}.png", uretilenSayilar[issay]));
            }
        }
    }

    public class main
    {
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaPencere());

        }
    }
}