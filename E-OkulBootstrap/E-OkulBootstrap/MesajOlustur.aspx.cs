using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_OkulBootstrap
{
    public partial class MesajOlustur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtGonderen.Text = "0001";
        }

        protected void BtnGonder_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_MESAJLARTableAdapter dt=new DataSet1TableAdapters.TBL_MESAJLARTableAdapter();
            dt.MesajGonder(txtGonderen.Text, txtAlici.Text, txtBaslik.Text,txticerik.Value,DateTime.Now);
            Response.Redirect("GidenMesajlar.aspx");
        }
    }
}