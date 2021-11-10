using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GolfShot
{
    public partial class _Default : Page
    {
        internal string query;
        internal SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            bool loggedIn = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;

            if(loggedIn == true)
            {
                Button1.Visible = true;
            }
        }

        internal void connection()
        {
            throw new NotImplementedException();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View");
        }
    }
}