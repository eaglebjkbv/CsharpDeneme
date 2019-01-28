using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Okul.Siniflar
{
    public partial class SiniflarIndex : System.Web.UI.Page
    {
        DataTable dt,dt1;

        protected void Page_Load(object sender, EventArgs e)
        {
            String cns = ConfigurationManager.ConnectionStrings["OkulConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(cns);
            SqlDataAdapter dadp = new SqlDataAdapter("Select * from Sinif", conn);
            dt = new DataTable();
            dadp.Fill(dt);
            // Bu kısım DataSet Kulanılabileceğini göstermek için kullnaılmıştır.....
            // Direkt Bu kısmın altına
            // Repeater1.DataSource = dt;
            // Yazılabilir.

            SqlDataAdapter dadp1 = new SqlDataAdapter("Select * from Personel", conn);
            dt1 = new DataTable();
            dadp1.Fill(dt1);

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.Tables.Add(dt1);

            Repeater1.DataSource = ds; // Datasource kısmına DataSet te yazılabilir DataTable Da yazılabilir.
          
            Repeater1.DataBind();

            
            

        }
    }
}