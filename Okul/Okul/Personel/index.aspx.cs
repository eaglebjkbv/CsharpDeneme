using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Okul.OkulTableAdapters;

namespace Okul.Personel
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OkulTableAdapters.DataTable1TableAdapter okul=new OkulTableAdapters.DataTable1TableAdapter();
            repeater1.DataSource = okul.PersonelListesiGetir();
            repeater1.DataBind();
        }
    }
}