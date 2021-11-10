<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="GolfShot.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
        table,th,td{
            border: 1px solid black;
            padding: 5px;
        }

        table{
            border-spacing: 15px;
        }
        </style>
</head>
<body>
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

            <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table> 
                    <tr> 
                        <td> <img src="<%#Eval("ImagePath") %>" height ="200", width = "200" /></td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>

           

            

        </div>
    </form>
</body>
</html>
