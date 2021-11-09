<%@ Page Title="Upload Images" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="GolfShot.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <button><a href="/View">View Images</a></button>
    <h2><%: Title %>.</h2>
    <h3>Please upload your images here :</h3>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="142px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Image: "></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" Width="211px" />
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload Image" />
    </p>
    
</asp:Content>
