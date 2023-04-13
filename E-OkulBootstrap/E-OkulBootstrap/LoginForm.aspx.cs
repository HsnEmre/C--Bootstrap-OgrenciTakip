using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace E_OkulBootstrap
{

    public partial class LoginForm : System.Web.UI.Page
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-972PD8E\SQLEXPRESS;Initial Catalog=UdemySiteDb;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtDers_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBL_Ogrencı where OGRENCINUMARA=@p1 and ogrSifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtNumara.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                Session.Add("numara", txtNumara.Text);
                Response.Redirect("OgrenciDefault.aspx");
            }
            else
            {
                txtNumara.Text = "Hatalı Şifre veya Numara";
                txtSifre.Text = "Hatalı Şifre veya Numara";
            }


        }
    }
}