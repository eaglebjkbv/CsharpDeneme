using System;
using System.Threading;

namespace MyEvent2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArabaKiralama kiralama=new ArabaKiralama();
            kiralama.SureBitti += Kiralama_SureBitti;
            kiralama.ArabaKirala();
                        
        }

        private static void Kiralama_SureBitti(object o, BeninEventArgs e)
        {
            
            Console.WriteLine($"Kiralama Süreniz Doldu..{e.Plaka}..");
        }

    }
    public class BeninEventArgs:EventArgs{
        public string Plaka { get; set; }
    }
    public class ArabaKiralama{

        public delegate void KiralamaSuresiOlayiTutucusu(object o,BeninEventArgs e);

        public event KiralamaSuresiOlayiTutucusu SureBitti;
       
        public void ArabaKirala(){
            System.Console.WriteLine("Araba Kiralandı");
            Thread.Sleep(3000);
            KiralamaSuresiBitti();
        }
        protected virtual void KiralamaSuresiBitti(){
         if(SureBitti!=null){
            
            BeninEventArgs benimArgs=new BeninEventArgs();
            benimArgs.Plaka="35ĞHI09";
            SureBitti(this,benimArgs);

        }
        }

    }
}
