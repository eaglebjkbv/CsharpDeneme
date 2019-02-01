using System;
using System.Windows.Forms;
using System.Data.SqlClient;

// Derlemek için : csc Pencerem.cs
namespace BenimPencerem{

class Anapencere:Form
{
    private Button btnDeneme;
    private Button btnVeriEkle;
    private TextBox txtPersonelId;
    private TextBox txtPersonelAdi;
    private TextBox txtPersonelSoyadi;
    private TextBox txtPersonelMaas;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;



    public Anapencere(int genislik=800,int yuklseklik=600){
        Height=yuklseklik;
        Width=genislik;
// Komponent referansı oluşturma
        btnDeneme=new Button();
        btnVeriEkle=new Button();
        txtPersonelId=new TextBox();
        txtPersonelAdi=new TextBox();
        txtPersonelSoyadi=new TextBox();
        txtPersonelMaas=new TextBox();
        label1=new Label();
        label2=new Label();
        label3=new Label();
        label4=new Label();



// Komponent Label   
        btnDeneme.Text="Çıkış";
        btnVeriEkle.Text="Kaydet";
        label1.Text="Persone Id";
        label2.Text="Persone Adı";
        label3.Text="Persone Soyadı";
        label4.Text="Persone Maaşı";
        

// Komponenti for üzerine yerleştirme
        btnDeneme.SetBounds(650, 500, 100, 50);
        btnVeriEkle.SetBounds(110, 120, 100, 30);
        label1.SetBounds(10,10,90,20);
        label2.SetBounds(10,40,90,20);
        label3.SetBounds(10,70,90,20);
        label4.SetBounds(10,100,90,20);
        txtPersonelId.SetBounds(110,10,100,20);
        txtPersonelAdi.SetBounds(110,40,100,20);
        txtPersonelSoyadi.SetBounds(110,70,100,20);
        txtPersonelMaas.SetBounds(110,100,100,20);

        

// Komponenti forma ekleme 
        Controls.Add(btnDeneme);     
        Controls.Add(btnVeriEkle);
        Controls.Add(label1);
        Controls.Add(label2);
        Controls.Add(label3);
        Controls.Add(label4);
        Controls.Add(txtPersonelId);
        Controls.Add(txtPersonelAdi);
        Controls.Add(txtPersonelSoyadi);
        Controls.Add(txtPersonelMaas);

// Komponenet olayları
        btnVeriEkle.Click+=btnVeriEkle_Tiklandi;
        btnDeneme.Click+=Button_Tiklandi;
        this.Load+=Pencere_Yukleniyor;
        



    }
    private void btnVeriEkle_Tiklandi(object sender ,EventArgs e){
        SqlConnection conn=new SqlConnection("Data Source=HPBV\\BVSQLEXPRESS;Initial Catalog=Okul;Integrated Security=True") ;
        conn.Open();
        SqlCommand cmd= new SqlCommand("INSERT INTO Personel(Personel_Adi,Personel_Soyadi,Personel_Maas) values(@pad,@psad,@pmaas)",conn);
        cmd.Parameters.AddWithValue("@pad",txtPersonelAdi.Text);
        cmd.Parameters.AddWithValue("@psad",txtPersonelSoyadi.Text);
        cmd.Parameters.AddWithValue("@pmaas",txtPersonelMaas.Text);
       



        try{
            if(cmd.ExecuteNonQuery()>0){
                System.Windows.Forms.MessageBox.Show("Veri Başarı ile Kayıt Edildi");
            };

        }catch(Exception ex){
            System.Windows.Forms.MessageBox.Show(ex.Message);
        }
        conn.Close();
    }
    private void Pencere_Yukleniyor(object sender,EventArgs e){
        
       

    }
    private void Button_Tiklandi(object sender,EventArgs e){
        this.Close();
    }
    

}
static class Pencerem
{
    [STAThread]
    static void Main(){
        Application.EnableVisualStyles(); //Windowsunuzun stiline uygun Pencere olması için...
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Anapencere());
    

    }
}

}