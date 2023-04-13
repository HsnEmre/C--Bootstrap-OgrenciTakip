using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_OkulBootstrap
{

    public partial class WebForm4 : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)//sayfayı yeniden yüklemenin önüne geçicem
            {
                #region Şartlı Taşıma
                try
                {
                    id = Convert.ToInt32(Request.QueryString["OGRID"].ToString());


                    txtOgrID.Text = id.ToString();



                    DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
                    //newleyip kurucu çağırıyoruz datasetin metotlarına ulaşmak için

                    txtOgrAd.Text = dt.OgrenciSec(id)[0].OGRAD;
                    txtOgrSoyad.Text = dt.OgrenciSec(id)[0].OGRSOYAD;
                    txtOgrMail.Text = dt.OgrenciSec(id)[0].OGRMAIL;
                    txtOgrTel.Text = dt.OgrenciSec(id)[0].OGRTELEFON;
                    txtOgrSifre.Text = dt.OgrenciSec(id)[0].OGRSİFRE;
                    txtOgrFoto.Text = dt.OgrenciSec(id)[0].OGRFOTOGRAF;



                }
                catch (Exception)
                {
                    txtOgrFoto.Text = "link girin";
                }
                #endregion
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
            //dt.OgrenciGuncelle(txtOgrAd.Text, txtOgrSoyad.Text, txtOgrTel.Text, txtOgrMail.Text, txtOgrSifre.Text, txtOgrFoto.Text, Convert.ToInt32(txtOgrID.Text));
            //DataSet1
            //Response.Redirect("Anasayfa.aspx");

            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt=new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
            dt.OgrenciGuncelle(txtOgrAd.Text, txtOgrSoyad.Text, txtOgrTel.Text, txtOgrMail.Text, txtOgrSifre.Text, txtOgrFoto.Text, Convert.ToInt32(txtOgrID.Text));
            Response.Redirect("Anasayfa.aspx");
        }
    }
}