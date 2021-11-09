<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="GolfShot.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 417px;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            width: 417px;
            text-align: center;
        }
        .auto-style4 {
            width: 417px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

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
