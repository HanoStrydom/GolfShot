<%@ Page Title="View Pictures" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="GolfShot.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <button><a href="/Upload">Upload Image</a></button>
    <h2><%: Title %>.</h2>
    <h3>Here you can View al the uploaded pictures,
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </h3>
    <p>
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table> 
                    <tr> 
                        <td> <img src="<%#Eval("ImagePath") %>" height ="200", width = "200" /></td>
                        <td> <%# Eval("Uploader") %> </td>
                        <td><button> <a href="<%#Eval("ImagePath") %>">Download Now</a> </button></td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </p>

</asp:Content>
