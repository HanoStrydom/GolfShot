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
    public partial class About : Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=cmpg323-project2.database.windows.net;Initial Catalog=Project2;User ID=Hano;Password=3695748Hl;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie test = Request.Cookies["UserLogIn"];
            String name = "";
            if(test != null)
            {
                name = test["mail"];
            }
            Label1.Text = name;

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ImageToDB";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();

                con.Close();
            }catch(Exception ex)
            {
                Response.Write("<script> alert('Error!')</script>");
            }
            
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAll_Click(object sender, EventArgs e)
        {
            HttpCookie test = Request.Cookies["UserLogIn"];
            String name = "";
            if (test != null)
            {
                name = test["mail"];
            }
            Label1.Text = name;

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ImageToDB";
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

        public void selectQuery()
        {
            //Just Name
            if(txtName.Text != "" && txtLocation.Text == "" && txtCourse.Text == "")
            {
                String name = txtName.Text;
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
                btnAll.Visible = true;
            }
            //Just Location
            if(txtName.Text == "" && txtLocation.Text != "" && txtCourse.Text == "")
            {
                String name = txtLocation.Text;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ImageToDB WHERE ImageLocation = '" + name.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();
                con.Close();
                btnAll.Visible = true;
            }
            //Just Course
            if(txtName.Text == "" && txtLocation.Text == "" && txtCourse.Text != "")
            {
                String name = txtCourse.Text;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ImageToDB WHERE GolfCourse = '" + name.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();
                con.Close();
                
            }
            //Name and Location
            if (txtName.Text != "" && txtLocation.Text != "" && txtCourse.Text == "")
            {
                String name = txtName.Text;
                String location = txtLocation.Text;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ImageToDB WHERE Uploader = '" + name.ToString() + "' AND ImageLocation ='" + location.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();
                con.Close();
                
            }
            //Name and Course
            if (txtName.Text != "" && txtLocation.Text == "" && txtCourse.Text != "")
            {
                String name = txtName.Text;
                String course = txtCourse.Text;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ImageToDB WHERE Uploader = '" + name.ToString() + "' AND GolfCourse ='" + course.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();
                con.Close();
                
            }
            //Location and Course
            if (txtName.Text == "" && txtLocation.Text != "" && txtCourse.Text != "")
            {
                String name = txtLocation.Text;
                String course = txtCourse.Text;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ImageToDB WHERE ImageLocation = '" + name.ToString() + "' AND GolfCourse ='" + course.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();
                con.Close();
                
            }
            //Name,Location and Course
            if (txtName.Text != "" && txtLocation.Text != "" && txtCourse.Text != "")
            {
                String name = txtName.Text;
                String course = txtCourse.Text;
                String location = txtLocation.Text;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ImageToDB WHERE Uploader = '" + name.ToString() + "' AND GolfCourse ='" + course.ToString() + "' AND ImageLocation ='" + location.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataList1.DataSource = dt;
                DataList1.DataBind();
                con.Close();
                
            }

            btnAll.Visible = true;
        }

        protected void btnName_Click(object sender, EventArgs e)
        {
            selectQuery();
        }




    }
}