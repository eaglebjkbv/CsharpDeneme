using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataFirlatma
{
    class Personel
    {
        private int PersonelId;
        public int  personelId {
            get { return this.PersonelId; }
            set
            {
                if (value < 0)
                {
                    throw new BenimException(1,"Sayı Eksi olamaz");
                    //throw new ArgumentException("Sayı -1 den Küçük Olamaz.");
                }
                else
                {
                    this.PersonelId = value;
                }

            }
        }
        public string PersonelAdi { get; set; }
        public int PersonelMaas { get; set; }
    }
}
