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
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(@"DefaultEndpointsProtocol=https;AccountName=cmpgprojectstorage;AccountKey=zQwV9s90FkVpnk+OGSqNif7T0iR9ZFWmIWsUOsk+E/Ck/HYw4GhKAxBUK2WglM+jyTUBzjvQmSjXx32I8rtxBw==;BlobEndpoint=https://cmpgprojectstorage.blob.core.windows.net/;QueueEndpoint=https://cmpgprojectstorage.queue.core.windows.net/;TableEndpoint=https://cmpgprojectstorage.table.core.windows.net/;FileEndpoint=https://cmpgprojectstorage.file.core.windows.net/;");
                CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
                CloudBlobContainer container = blobClient.GetContainerReference("fotos");
                CloudBlockBlob blockBlob = container.GetBlockBlobReference(FileUpload1.FileName);

                using (FileUpload1.PostedFile.InputStream)
                {
                    blockBlob.UploadFromStream(FileUpload1.PostedFile.InputStream);
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script> alert('Please upload a valid photo!')</script>");
            }
        }
    }
}