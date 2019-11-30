using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
// http://www.cihanozhan.com/csharp-ile-xml-serialization/
namespace XmlSerialize
{
    [Serializable]
    [XmlType(TypeName = "User")] // Kullanıcı sınıfının User adında bir XML kök dizini olarak çıktı üretmesini sağlar. Bunu kullanmazsanız XML'in kök dizini Kullanici olacaktır.
    public class Kisi
    {
        
        [XmlElement(ElementName = "UserId", Type = typeof(int))] // XML çıktı içinde üretilecek element'in adını UserId olarak üretmesini sağlar.
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        [XmlAttribute]
        public string AttrAlan { get; set; }

        public Kisi(int id, string ad, string soyad)
        {
            this.id = id;
            this.Ad = ad;
            this.Soyad = soyad;
            this.AttrAlan = "AttributeXDD";
        }
        public Kisi()
        {

        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kullanici = new Kisi(10, "Ahmet", "Yaman");
            Serialize(kullanici);
        }

        static void Serialize(Kisi kullanici)
        {
            FileStream fs = new FileStream("Kullanici.xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(Kisi));
            xs.Serialize(fs, kullanici);
            fs.Close();
        }

       
    }
}
