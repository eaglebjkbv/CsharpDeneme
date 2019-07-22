using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CXSLite;

public partial class _Default : System.Web.UI.Page
{
    private CXSLiteCtrl cxsLiteCtrl1;
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.AppendHeader("Refresh", "5");
        cxsLiteCtrl1 = new CXSLiteCtrl();
        cxsLiteCtrl1.ProjectName = AppDomain.CurrentDomain.BaseDirectory+"1.cdm";
        String cxLiteBaglanti = cxsLiteCtrl1.ProjectName;
        // Response.Write(cxLiteBaglanti);
        //cxsLiteCtrl1.Connect(cxLiteBaglanti);

        String[] deviceList = cxsLiteCtrl1.Devices;
        foreach (var device in deviceList)
        {
            lisBox1.Items.Add(device);
        }

        String[] pointler;
        String aktifPLC = lisBox1.Items[0].ToString();
        cxsLiteCtrl1.ListPoints(aktifPLC, out pointler);
        int guncelleme = 1;
        object value = null;
        bool quality = false;
        foreach (var point in pointler)
        {
            listbox2.Items.Add(point);
            cxsLiteCtrl1.GetData(aktifPLC, point, guncelleme);
            cxsLiteCtrl1.Read(aktifPLC, point, out value, out quality);
            Response.Write("<br> Point :" + point);
            Response.Write("<br> Değer :"+value.ToString());
        }




        //String xml = "<foo>Hello, world!</foo>";

        //Response.Clear();
        //Response.ContentType = "text/xml; charset=utf-8";
        //Response.Write(xml);
        //Response.End();
    }
}