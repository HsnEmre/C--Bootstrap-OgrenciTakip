using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_OkulBootstrap
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        int nid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                nid = Convert.ToInt32(Request.QueryString["NOTID"].ToString());
                txtOgrId.Text=nid.ToString();
                DataSet1TableAdapters.OGRNOTLARTableAdapter dt = new DataSet1TableAdapters.OGRNOTLARTableAdapter();

                txtOgrId.Text = dt.NotGetir2(nid)[0].OGRENCIID.ToString();
                txtOgrAdSoyad.Text = dt.NotGetir2(nid)[0].ÖĞRENCİADSOYAD;
                txtDersAd.Text = dt.NotGetir2(nid)[0].DERSAD;
                txtSınav1.Text = dt.NotGetir2(nid)[0].SINAV1.ToString();
                txtSınav2.Text = dt.NotGetir2(nid)[0].SINAV2.ToString();
                txtSınav3.Text = dt.NotGetir2(nid)[0].SINAV3.ToString();
                txtOrtalama.Text = dt.NotGetir2(nid)[0].ORTALAMA.ToString();
                txtDurum.Text = dt.NotGetir2(nid)[0].DURUM.ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, sinav3;
            double ortalama;
            sinav1 = Convert.ToInt32(txtSınav1.Text);
            sinav2 = Convert.ToInt32(txtSınav2.Text);
            sinav3 = Convert.ToInt32(txtSınav3.Text);

            ortalama = (sinav1 + sinav2 + sinav3) / 3;
            txtOrtalama.Text = ortalama.ToString("0.00");

            if (ortalama >= 50)
            {
                txtDurum.Text = "True";

            }
            else
            {
                txtDurum.Text = "False";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            nid = Convert.ToInt32(Request.QueryString["NOTID"].ToString());
            DataSet1TableAdapters.OGRNOTLARTableAdapter dt=new DataSet1TableAdapters.OGRNOTLARTableAdapter();

            dt.NotGuncelle(byte.Parse(txtSınav1.Text), byte.Parse(txtSınav2.Text), byte.Parse(txtSınav3.Text), decimal.Parse(txtOrtalama.Text), bool.Parse(txtDurum.Text), nid);
            Response.Redirect("NotListesi.aspx");
        }
    }
}