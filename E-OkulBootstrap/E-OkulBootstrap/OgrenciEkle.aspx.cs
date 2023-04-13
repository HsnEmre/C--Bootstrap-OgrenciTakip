using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_OkulBootstrap
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            #region Ogrenci Eklme İslemi
            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt=new DataSet1TableAdapters.TBL_OGRENCITableAdapter();

            dt.OgrenciEkle(txtOgrAd.Text,txtOgrSoyad.Text,txtOgrTel.Text,txtOgrMail.Text,txtOgrSifre.Text,txtOgrFoto.Text);

            Response.Redirect("AnaSayfa.aspx");
            /*
             Response komutu yönlendirme verir bende ana sayfaya yönlendirdim
             */
            #endregion
        }
    }
}