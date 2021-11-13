using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;

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

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=cmpg323-project2.database.windows.net;Initial Catalog=Project2;User ID=Hano;Password=3695748Hl;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            try
            {
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(@"DefaultEndpointsProtocol=https;AccountName=cmpgprojectstorage;AccountKey=zQwV9s90FkVpnk+OGSqNif7T0iR9ZFWmIWsUOsk+E/Ck/HYw4GhKAxBUK2WglM+jyTUBzjvQmSjXx32I8rtxBw==;BlobEndpoint=https://cmpgprojectstorage.blob.core.windows.net/;QueueEndpoint=https://cmpgprojectstorage.queue.core.windows.net/;TableEndpoint=https://cmpgprojectstorage.table.core.windows.net/;FileEndpoint=https://cmpgprojectstorage.file.core.windows.net/;");
                CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
                CloudBlobContainer container = blobClient.GetContainerReference("fotos");

                String imageName = TextBox1.Text;

                if(imageName != "")
                {
                    //SQL to remove Metadata
                    string delete_query = "DELETE FROM ImageToDB WHERE ImageName ='" + TextBox1.Text + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(delete_query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //Delete from the container
                    CloudBlockBlob blockBlob = container.GetBlockBlobReference(imageName);
                    bool isDeleted = blockBlob.DeleteIfExists();

                    if (isDeleted == true)
                    {
                        Server.TransferRequest(Request.Url.AbsolutePath, false);
                        Label2.Text = imageName + " was succesfully deleted!";
                        TextBox1.Text = "";
                    }
                    else
                    {
                        Label2.Text = imageName + " was not succesfully deleted!";
                    }
                }
                else
                {
                    Label2.Text = "Please provide a photo name!";
                }
                

            }
            catch(Exception ex)
            {
                Label2.Text = "I got error: " + ex;
            }
        }
    }
}