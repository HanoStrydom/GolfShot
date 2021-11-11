using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Azure.Storage.Blobs;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;

namespace GolfShot
{
    public partial class Contact : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=cmpg323-project2.database.windows.net;Initial Catalog=Project2;User ID=Hano;Password=3695748Hl;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aspnet-GolfShot-20211108010649;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            
            try
            {
                DateTime date = new DateTime();
                date = DateTime.Now;

                String path = "https://cmpgprojectstorage.blob.core.windows.net/fotos/";

                //This is to insert the metadata
                if (FileUpload1.HasFile)
                {
                    path += FileUpload1.PostedFile.FileName;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT into ImageToDB(Uploader, ImageName, ImageLocation, DateTaken, DateUploaded, ImagePath) values('" + txtUploader.Text + "','" + txtImageName.Text + "','" + txtLocationTaken.Text + "' ,'" + txtTaken.Text + "' ,'" + date + "' ,'" + path + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Label6.Visible = true;
                    Label6.Text = "Image and Meta-data Added!";
                    Image1.Visible = true;
                    Image1.ImageUrl = "https://imgr.search.brave.com/75IbOPzAhOI2xjjH0BoZ3Cl7JlsIB7UFEDSY2DMlNoc/fit/600/302/ce/1/aHR0cDovL3MyLnF1/aWNrbWVtZS5jb20v/aW1nLzE0LzE0YzBm/MDU3YWJlYzZkYWJm/YzViZTQ4Y2JiZDBk/OTA0ZmVmODg5YTg3/ODFlZWU2Njc5ODQw/ODkyMDdkYWY5OTgu/anBn";
                    txtUploader.Text = "";
                }
                else
                {
                    Label6.Visible = true;
                    Label6.Text = "Please enter necessary information!";
                }

                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(@"DefaultEndpointsProtocol=https;AccountName=cmpgprojectstorage;AccountKey=zQwV9s90FkVpnk+OGSqNif7T0iR9ZFWmIWsUOsk+E/Ck/HYw4GhKAxBUK2WglM+jyTUBzjvQmSjXx32I8rtxBw==;BlobEndpoint=https://cmpgprojectstorage.blob.core.windows.net/;QueueEndpoint=https://cmpgprojectstorage.queue.core.windows.net/;TableEndpoint=https://cmpgprojectstorage.table.core.windows.net/;FileEndpoint=https://cmpgprojectstorage.file.core.windows.net/;");
                CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
                CloudBlobContainer container = blobClient.GetContainerReference("fotos");
                CloudBlockBlob blockBlob = container.GetBlockBlobReference(FileUpload1.FileName);

                //blockBlob.DeleteIfExists("Jeffreys.jpg");



                using (FileUpload1.PostedFile.InputStream)
                {
                    blockBlob.UploadFromStream(FileUpload1.PostedFile.InputStream);
                }

                //FileUpload1.PostedFile.SaveAs("TestingNames");

            }
            catch(Exception ex)
            {
                Response.Write("<script> alert('Please upload a valid photo!')</script>");
            }


            txtImageName.Text = "";
            txtLocationTaken.Text = "";
            txtTaken.Text = "";
            txtUploader.Text = "";
            
        }
    }
}