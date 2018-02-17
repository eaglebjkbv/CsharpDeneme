using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProgramming1
{
    class Calisan
    {
        public Calisan()
        {
            Profil = new Profil();
            Adres = new Adres();
        }
       

        public Adres Adres { get; set; }
        public Profil Profil { get; set; }
        public int Cno { get; set; }
       

    }
}
