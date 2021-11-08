<%@ Page Title="Upload Images" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="GolfShot.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <button><a href="/View">View Images</a></button>
    <h2><%: Title %>.</h2>
    <h3>Please upload your images here:</h3>
    <button type="button">Upload!</button>
</asp:Content>
