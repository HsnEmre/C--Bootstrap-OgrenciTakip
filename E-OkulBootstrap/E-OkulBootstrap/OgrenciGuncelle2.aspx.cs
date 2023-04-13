using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_OkulBootstrap
{
    public partial class OgrenciGuncelle2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtbx1.Text = Request.QueryString["NUMARA"];
            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
            txtbx2.Text = "Ad Soyad: " + dt.OgrenciPaneliGetir(txtbx1.Text)[0].OGRAD + dt.OgrenciPaneliGetir(txtbx1.Text)[0].OGRSOYAD;
            TextBox4.Text = "Mail Adresi: " + dt.OgrenciPaneliGetir(txtbx1.Text)[0].OGRMAIL;
            TextBox5.Text = "Fotograf: " + dt.OgrenciPaneliGetir(txtbx1.Text)[0].OGRFOTOGRAF;
            TextBox6.Text = "Telefon: " + dt.OgrenciPaneliGetir(txtbx1.Text)[0].OGRTELEFON;
            TextBox7.Text = "Şifre: " + dt.OgrenciPaneliGetir(txtbx1.Text)[0].OGRSİFRE;

         

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
            dt.OgrenciSifreGuncelle(TextBox7.Text, Convert.ToInt32(txtbx1.Text));
            Response.Redirect("OgrenciDefault.aspx");
        }
    }
}