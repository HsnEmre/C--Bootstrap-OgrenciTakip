using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_OkulBootstrap
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ilk önce ilgili sayfadan öğrenci ıd sini bu syafaya taşımam gerekiyor

            int id = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
            //request.querystring ilgili formdan buraya taşı

            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt=new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
            dt.OgrenciSil(id);
            Response.Redirect("AnaSayfa.aspx");

        }
    }
}