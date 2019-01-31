using System;
using System.Collections.Generic;
using System.Text;
using System.Dat

namespace Okul2DAL
{
    class VeriTabani
    {
        private SqlConnection Baglanti()
        {
            return new SqlConnection("Data Source=HPBV\\BVSQLEXPRESS;Initial Catalog=Okul;Integrated Security=True");
        }


        public string TabloPersonel => "Personel";
        public int PersonelID { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public double PersonelMaasi { get; set; }

        public VeritTabani()
        {

        }

        public VeritTabani(string TabloAdi)
        {

        }

        public VeritTabani(int personelId, string personelAdi, string personelSoyadi, double personelMaas)
        {
            PersonelID = personelId;
            PersonelAdi = personelAdi;
            PersonelSoyadi = personelSoyadi;
            PersonelMaasi = personelMaas;
        }

        public bool PersonelEkle()
        {
            SqlConnection Bag = Baglanti();
            Bag.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Personel(PersonelAdi,PersonelSoyadi,PersonelMaas) VALUES(@personelAdi,@personelSoyadi,@personelMaas);");

            cmd.Parameters.AddWithValue("@personelAdi", PersonelAdi);
            cmd.Parameters.AddWithValue("@personelSoyadi", PersonelSoyadi);
            cmd.Parameters.AddWithValue("@personelMaas", PersonelMaasi);
            bool sonuc = cmd.ExecuteNonQuery() > 0 ? true : false;
            return sonuc;
        }
    }
}
