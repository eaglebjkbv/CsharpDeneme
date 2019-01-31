using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulDAL
{
   public class VeriTabani
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

        public VeriTabani()
        {

        }

        public VeriTabani(string TabloAdi)
        {

        }

        public VeriTabani(int personelId, string personelAdi, string personelSoyadi, double personelMaas)
        {
            PersonelID = personelId;
            PersonelAdi = personelAdi;
            PersonelSoyadi = personelSoyadi;
            PersonelMaasi = personelMaas;
        }

        public bool PersonelEkle()
        {
            bool sonuc;
            SqlConnection Bag;
            try
            {
            Bag = Baglanti();
            Bag.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Personel(Personel_Adi,Personel_Soyadi,Personel_Maas) VALUES(@personelAdi,@personelSoyadi,@personelMaas);",Bag);

            cmd.Parameters.AddWithValue("@personelAdi", PersonelAdi);
            cmd.Parameters.AddWithValue("@personelSoyadi", PersonelSoyadi);
            cmd.Parameters.AddWithValue("@personelMaas", PersonelMaasi);

                if (Bag.State == ConnectionState.Open)
                {
                    sonuc = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                else
                {
                    sonuc = false;
                }

            }
            catch (Exception e)
            {
                return false;
            }
           
                if (Bag.State == ConnectionState.Open)
                {
                    Bag.Close();
                    
                }
            return sonuc;
        }
    }
}
