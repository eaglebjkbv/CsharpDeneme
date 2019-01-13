using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebformIlk
{
    public partial class SinifGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet1TableAdapters.sinifTableAdapter sin = new DataSet1TableAdapters.sinifTableAdapter();
                int id = Convert.ToInt16(Request.QueryString["id"]);

                String sinifAdi = sin.SinifGetir(id)[0].sinifAdi;
                String odaNo = sin.SinifGetir(id)[0].odaNo;
                txtSinifAd.Text = sinifAdi;
                txtSinifOda.Text = odaNo;
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["id"]);
            DataSet1TableAdapters.sinifTableAdapter sin = new DataSet1TableAdapters.sinifTableAdapter();
            sin.SinifGuncelle(txtSinifAd.Text, txtSinifOda.Text, id);
            Response.Redirect("index.aspx");

        }
    }
}