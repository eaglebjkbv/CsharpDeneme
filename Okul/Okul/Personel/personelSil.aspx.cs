using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Okul.Personel
{
    public partial class personelSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.PersonelTableAdapter personel = new DataSet1TableAdapters.PersonelTableAdapter();
            int sil = Convert.ToInt16(Request.QueryString["sil"]);
            personel.SilPersonel(sil);
            Response.Redirect("index.aspx");
        }
    }
}