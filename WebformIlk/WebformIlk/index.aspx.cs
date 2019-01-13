using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebformIlk
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            listele();
            
        }
        protected void listele()
        {
            DataSet1TableAdapters.sinifTableAdapter sin = new DataSet1TableAdapters.sinifTableAdapter();
            rep1.DataSource = sin.SinifListesiGetir();
            rep1.DataBind();
        }
        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSinifOda.Text != "" || txtSinifOda.Text!="")
            {
                DataSet1TableAdapters.sinifTableAdapter sin = new DataSet1TableAdapters.sinifTableAdapter();
                sin.SinifVeriEkle(txtSinifAd.Text, txtSinifOda.Text);
                txtSinifAd.Text = "";
                txtSinifOda.Text = "";
                listele();
            }

        }
    }
}