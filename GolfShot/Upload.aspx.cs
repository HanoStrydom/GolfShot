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
    public partial class Contact : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=cmpg323-project2.database.windows.net;Initial Catalog=Project2;User ID=Hano;Password=3695748Hl;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aspnet-GolfShot-20211108010649;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (FileUpload1.HasFile)
            {
                string strname = FileUpload1.FileName.ToString();
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Fotos/") + strname);
                con.Open();
                //SqlCommand cmd = new SqlCommand("INSERT into ImageToDB values('" + TextBox1.Text + "','" + strname + "')", con);
                SqlCommand cmd = new SqlCommand("INSERT into upload1 values('" + TextBox1.Text + "','" + strname + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Label1.Visible = true;
                Label1.Text = "Image Uploaded successfully";
                TextBox1.Text = "";
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Plz upload the image!!!!";
            }
        }
    }
}