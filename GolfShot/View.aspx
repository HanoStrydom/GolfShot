﻿<%@ Page Title="View Pictures" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="GolfShot.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <button><a href="/Upload">Upload Image</a></button>
    <h2><%: Title %>.</h2>
    <h3>Here you can View al the uploaded pictures!</h3>
        
</asp:Content>