using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Okul.DataSet1TableAdapters;

namespace Okul.Personel
{
    public partial class personelGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                DataSet1TableAdapters.PersonelTableAdapter personel = new PersonelTableAdapter();
                int guncelle = Convert.ToInt16(Request.QueryString["guncelle"]);
                DataTable dt = personel.PersonelGetir(guncelle);
                foreach (DataRow satir in dt.Rows)
                {
                    txtAd.Text=satir["Personel_Adi"].ToString();
                    txtSoyad.Text = satir["Personel_Soyadi"].ToString();
                    txtMaas.Text = satir["Personel_Maas"].ToString();
                }
            }
           
                
           
        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            DataSet1TableAdapters.PersonelTableAdapter personel = new PersonelTableAdapter();
            personel.GuncellePersonel(txtAd.Text, txtSoyad.Text, float.Parse(txtMaas.Text),Convert.ToInt16(Request.QueryString["guncelle"]));
            Response.Redirect("index.aspx");
            throw new NotImplementedException();
        }
    }
}