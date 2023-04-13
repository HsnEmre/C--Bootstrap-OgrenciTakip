using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_OkulBootstrap
{
    public partial class OgrenciNotu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.OGRNOTLARTableAdapter dt = new DataSet1TableAdapters.OGRNOTLARTableAdapter();
            Repeater1.DataSource = dt.OgrenciNotuGetir("12");
        }
    }
}