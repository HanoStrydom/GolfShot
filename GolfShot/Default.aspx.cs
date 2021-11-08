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

        }

        internal void connection()
        {
            throw new NotImplementedException();
        }
    }
}