using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Okul.Personel
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataSet1TableAdapters.PersonelTableAdapter personel = new DataSet1TableAdapters.PersonelTableAdapter();
            if (IsPostBack)
            {
                personel.EklePersonel(txtAd.Text,txtSoyad.Text,float.Parse(txtMaas.Text));
            }
            
            repeater1.DataSource = personel.PersonelListesiGetir();
            repeater1.DataBind();
            lblPersay.Text = personel.SayiPersonel().ToString();
        }
    }
}