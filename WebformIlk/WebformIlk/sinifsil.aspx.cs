using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebformIlk
{
    public partial class sinifsil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.sinifTableAdapter sin = new DataSet1TableAdapters.sinifTableAdapter();
            int id = Convert.ToInt16(Request.QueryString["id"]);
            sin.SinifSil(id);
            Response.Redirect("index.aspx");
        }
    }
}