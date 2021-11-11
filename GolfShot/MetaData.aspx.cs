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
        //public SqlConnection conn;
        public SqlConnection con;
        public SqlCommand comm;
        public DataSet ds;
        public SqlDataAdapter adap;
        //public string constr = @"Data Source=cmpg323-project2.database.windows.net;Initial Catalog=Project2;User ID=Hano;Password=3695748Hl;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                HttpCookie test = Request.Cookies["UserLogIn"];
                String name = "";
                if (test != null)
                {
                    name = test["mail"];
                }

                SqlConnection conn = new SqlConnection(@"Data Source=cmpg323-project2.database.windows.net;Initial Catalog=Project2;User ID=Hano;Password=3695748Hl;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string sql_state = "SELECT ImageName, Uploader, ImageLocation, DateTaken, Comment from ImageToDB WHERE UserMail = '" + name.ToString() + "'";
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
            catch(Exception ex)
            {
                Label4.Text = ex.ToString();
            }
            
        }

        public void reset()
        {
            rdComment.Checked = false;
            rdLocation.Checked = false;
            rdImageTaker.Checked = false;
            rdDateTaken.Checked = false;
            txtImage.Text = "";
            txtUpdate.Text = "";
            Server.TransferRequest(Request.Url.AbsolutePath, false);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=cmpg323-project2.database.windows.net;Initial Catalog=Project2;User ID=Hano;Password=3695748Hl;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            try
            {
                if(rdComment.Checked == false && rdDateTaken.Checked == false && rdImageTaker.Checked == false && rdLocation.Checked == false)
                {
                    Label4.Text = "Must Check a Radio Button!";
                }
                else
                {
                    if (txtImage.Text == "" || txtUpdate.Text == "")
                    {
                        Label4.Text = "Please enter all details!";
                    }
                    else
                    {
                        if (rdLocation.Checked)
                        {
                            rdComment.Checked = false;
                            rdDateTaken.Checked = false;
                            rdImageTaker.Checked = false;

                            string update_query = "UPDATE ImageToDB SET ImageLocation = '" + txtUpdate.Text + "' WHERE ImageName ='" + txtImage.Text + "'";
                            con.Open();
                            SqlCommand cmd = new SqlCommand(update_query, con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            reset();
                        }
                        else if (rdDateTaken.Checked)
                        {
                            rdComment.Checked = false;
                            rdLocation.Checked = false;
                            rdImageTaker.Checked = false;

                            string update_query = "UPDATE ImageToDB SET DateTaken = '" + txtUpdate.Text + "' WHERE ImageName ='" + txtImage.Text + "'";
                            con.Open();
                            SqlCommand cmd = new SqlCommand(update_query, con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            reset();
                        }
                        else if (rdImageTaker.Checked)
                        {
                            rdComment.Checked = false;
                            rdLocation.Checked = false;
                            rdDateTaken.Checked = false;

                            string update_query = "UPDATE ImageToDB SET Uploader = '" + txtUpdate.Text + "' WHERE ImageName ='" + txtImage.Text + "'";
                            con.Open();
                            SqlCommand cmd = new SqlCommand(update_query, con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            reset();
                        }
                        else if (rdComment.Checked)
                        {
                            rdImageTaker.Checked = false;
                            rdLocation.Checked = false;
                            rdDateTaken.Checked = false;

                            string update_query = "UPDATE ImageToDB SET Comment = '" + txtUpdate.Text + "' WHERE ImageName ='" + txtImage.Text + "'";
                            con.Open();
                            SqlCommand cmd = new SqlCommand(update_query, con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            reset();
                        }
                    }
                }
                


                
            }catch(Exception ex)
            {
                Label4.Text = "This is what went wrong: " + ex;
            }
            
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default");
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View");
        }

        protected void btnUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("/User");
        }
    }
}