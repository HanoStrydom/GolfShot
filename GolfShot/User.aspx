<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="GolfShot.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
        td{
            border: 1px solid black;
            padding: 5px;
        }

        table{
            border-spacing: 15px;
        }
            
        .auto-style1 {
            width: 169px;
            height: 40px;
        }
        .auto-style2 {
            width: 264px;
            height: 40px;
        }
        .auto-style3 {
            width: 1435px;
            height: 40px;
        }
        .auto-style4 {
            width: 141px;
            height: 40px;
        }
        .auto-style5 {
            width: 100%;
        }
        </style>
</head>
<body style="background-color:#D7E0F3;">
    <form id="form1" runat="server">
        <div>

            <table style="width:100%;">
                <tr>
                    <td class="modal-sm" style="width: 301px" align ="center"> 
                        <asp:Button ID="Button1" runat="server" Height="26px" OnClick="Button1_Click" Text="Home" Width="120px" />
                    </td>
                    <td class="modal-sm" style="width: 301px" align ="center"> 
                        <asp:Button ID="Button2" runat="server" Height="26px" OnClick="Button2_Click" Text="View All" Width="120px" />
                    </td>
                    <td class="modal-sm" style="width: 301px" align ="center"> 
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Image Info" Width="120px" />
                    </td>
                </tr>
                </table>

        <table class="auto-style5">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Image name to Delete: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" Width="246px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Delete" Width="137px" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
        </table>

            <asp:DataList ID="DataList1" runat="server" align="center">
                <ItemTemplate>
                    <table>
                        <tr>
                            <td> <h3> Image </h3> </td>
                            <td> <h3> Image Name </h3> </td>
                        </tr>
                        <tr> 
                            <td> <img src="<%#Eval("ImagePath") %>" height ="200", width = "200" /></td>
                            <td align ="center"> <h3> <%# Eval("ImageName") %> </h3> </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
