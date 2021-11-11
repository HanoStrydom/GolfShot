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
    public partial class MetaData : System.Web.UI.Page
    {
        public SqlConnection conn;
        public SqlConnection con;
        public SqlCommand comm;
        public DataSet ds;
        public SqlDataAdapter adap;
        public string constr = @"Data Source=cmpg323-project2.database.windows.net;Initial Catalog=Project2;User ID=Hano;Password=3695748Hl;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie test = Request.Cookies["UserLogIn"];
            String name = "";
            if (test != null)
            {
                name = test["mail"];
            }

            conn = new SqlConnection(constr);
            conn.Open();
            conn.Close();
            conn = new SqlConnection(constr);
            string sql_state = "SELECT UserMail,Uploader, ImageName, ImageLocation, DateTaken from ImageToDB WHERE UserMail = '" + name.ToString() + "'";
            conn.Open();

            ds = new DataSet();
            adap = new SqlDataAdapter();
            comm = new SqlCommand(sql_state, conn);

            adap.SelectCommand = comm;
            adap.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=cmpg323-project2.database.windows.net;Initial Catalog=Project2;User ID=Hano;Password=3695748Hl;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            String name = TextBox1.Text;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ImageToDB WHERE Uploader = '" + name.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataList1.DataSource = dt;
            DataList1.DataBind();

            con.Close();
        }
    }
}