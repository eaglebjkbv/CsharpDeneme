using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetBaglantiliMimari
{
    class KategoriSinif
    {
        public String CategoryID { get; set; }
        public String CategoryName { get; set; }
        public String Description { get; set; }
        public override string ToString()
        {
            return CategoryName.ToString();
        }
    }
}
