using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataFirlatma
{
    public class BenimException:Exception
    {
        public BenimException(int siddet,string mesaj):base(mesaj)
        {

        }
    }
}
