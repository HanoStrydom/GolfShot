using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace GolfShot
{
    public partial class User : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=cmpg323-project2.database.windows.net;Initial Catalog=Project2;User ID=Hano;Password=3695748Hl;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie test = Request.Cookies["UserLogIn"];
            String name = "";
            if (test != null)
            {
                name = test["mail"];
            }

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ImageToDB WHERE UserMail = '" + name.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('Error!')</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/MetaData");
        }
    }
}