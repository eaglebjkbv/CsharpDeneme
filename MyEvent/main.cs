using System.Windows.Forms;
using System;
using System.Threading;

// Bu program .Net Framwork Kullanırak yazılmıştır.
// Dereleme Komutu  : csc main.cs 


namespace BenimEvent{
class AnaPencere:Form{

    ArabaKiralama kiralama=new ArabaKiralama();
    public AnaPencere(int w=300,int h=200){
        Height=h;
        Width=w;

        Button btnDeneme=new Button();
        btnDeneme.SetBounds(10,10,60,20);
        btnDeneme.Text="Kirala";
        btnDeneme.Click+=Buton_Tiklandi;
        Controls.Add(btnDeneme);
        this.Load+=Pencere_Yukleniyor;
        
        kiralama.SureBitti+=KiralamaSuresi_Bitti; // Kiralama süresi bittiğinde çağırılacak referans methodu tanımlama

    }
    public void Buton_Tiklandi(object o,EventArgs e){
         kiralama.Kirala();
    }

       
    
    public void Pencere_Yukleniyor(Object o, EventArgs e){
         
        
         
    
    }

    // Kiralama süresi bittiğinde çağırılacak method...
    public void KiralamaSuresi_Bitti(Object o,ArabaEventArgs e){
        System.Windows.Forms.MessageBox.Show(e.AracPlaka+" :Kiralama Süresi Sona Erdi....");
    }




}
// Event Hazırlık Bölümü
public class ArabaEventArgs:EventArgs{
    public string AracPlaka { get; set; }
}
public class ArabaKiralama
{
    // Evet Tutucu delagate tanımlama
    public delegate void SureBittiEventHandler(object o,ArabaEventArgs e);
    // Event Türünde delege referansı oluşturma
    public event SureBittiEventHandler SureBitti;
    public void Kirala(){
        Thread.Sleep(3000);
    // Eventi harekete geçir.
        OnSureBitti();
    }
    // Eventi oluştur.
    protected virtual void OnSureBitti(){
        if(SureBitti!=null){
            SureBitti(this,new ArabaEventArgs(){AracPlaka="35ĞĞĞ09"});
        }
    }

}
static class Pencerem
{
    [STAThread]
    static void Main(){
        Application.EnableVisualStyles(); //Windowsunuzun stiline uygun Pencere olması için...
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new AnaPencere());
    

    }

}


}