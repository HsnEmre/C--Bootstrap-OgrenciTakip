﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_OkulBootstrap
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["DUYURUID"]);

            DataSet1TableAdapters.TBL_DUYURULARTableAdapter dt=new DataSet1TableAdapters.TBL_DUYURULARTableAdapter();

            dt.DuyuruSil(id);
            Response.Redirect("DuyuruListesi.aspx");


        }
    }
}