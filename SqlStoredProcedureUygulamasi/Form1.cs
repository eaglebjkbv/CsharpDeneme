using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlStoredProcedureUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn=new SqlConnection(ConfigurationManager.ConnectionStrings["OkulConString"].ConnectionString);
            conn.Open();
            SqlCommand cmd=new SqlCommand("personelEkle",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pad", txtAdi.Text);
            cmd.Parameters.AddWithValue("@psad", txtSoyadi.Text);
            cmd.Parameters.AddWithValue("@pmaas", Convert.ToDouble(txtMaasi.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
}
        }
/*
SQL server daki Personel tablosunun yapısı ************************* 
CREATE TABLE [dbo].[Personel](
	[Personel_ID] [int] IDENTITY(1,1) NOT NULL,
	[Personel_Adi] [nchar](10) NULL,
	[Personel_Soyadi] [nchar](10) NULL,
	[Personel_Maas] [float] NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[Personel_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

*********************************************************************
SQL server da çalıştılacak Procedure ********************************

CREATE PROCEDURE personelEkle
@pad nchar(10),
@psad nchar(10),
@pmaas float
AS
INSERT INTO Personel(Personel_Adi,Personel_Soyadi,Personel_Maas) 
VALUES
(@pad,@psad,@pmaas);
*********************************************************************
 */
