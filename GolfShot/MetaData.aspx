﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MetaData.aspx.cs" Inherits="GolfShot.MetaData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" Height="241px" Width="563px">
        </asp:GridView>
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:DataList ID="DataList1" runat="server">
                        <ItemTemplate>
                    <table>
                    <tr>
                        <td> <h3> Image </h3> </td>
                    </tr>
                    <tr> 
                        <td> <img src="<%#Eval("ImagePath") %>" height ="200", width = "200" /></td>
                    </tr>
                </table>
            </ItemTemplate>
                    </asp:DataList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
