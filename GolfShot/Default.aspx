<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GolfShot._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>
            &nbsp;</h1>
        <h1>GolfShot</h1>
        <p class="lead">Welcome to GolfShot! Where you can share your experience with your friends!.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>View Images!</h2>
            <p>
                To view the images, you have to log in! Press "Log In" at the top right corner. If you do not have an account, be sure to click on "Register".
                After you log in, you wil be redirected to the viewing page. You can also choose to upload images from there.
            </p>
        </div>
        <div class="col-md-4">
            <h2>Upload Images!</h2>
            <p>
                To upload images, be sure to log in, and then click on the button to upload an image!
            </p>
        </div>
        <div class="col-md-4">
            <h2>Contact Us!</h2>
            <p>
                <a class="btn btn-default" href = "mailto: hanostrydom8@gmail.com">Send Email</a>
            </p>
        </div>
    </div>

    

</asp:Content>
