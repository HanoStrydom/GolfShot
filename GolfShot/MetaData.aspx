<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MetaData.aspx.cs" Inherits="GolfShot.MetaData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 158px;
        }
        .auto-style6 {
            width: 204px;
            text-align: center;
        }
        .auto-style9 {
            width: 158px;
            height: 25px;
        }
        .auto-style10 {
            height: 25px;
            text-align: center;
        }
        .auto-style11 {
            text-align: center;
        }
        .auto-style13 {
            text-align: center;
            height: 25px;
            width: 204px;
        }
        .auto-style14 {
            width: 158px;
            text-align: center;
        }
        .auto-style15 {
            text-align: center;
            width: 500px;
        }
        .auto-style16 {
            width: 100%;
        }
    </style>
</head>
<body style="background-color:#D7E0F3;">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style16">
                <tr>
                    <td class="auto-style15">
                        <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" Width="200px" />
                    </td>
                    <td class="auto-style15">
                        <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" style="height: 26px" Text="View All" Width="200px" />
                    </td>
                    <td class="auto-style15">
                        <asp:Button ID="btnUser" runat="server" OnClick="btnUser_Click" Text="MyImages" Width="200px" />
                    </td>
                </tr>
            </table>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style11" colspan="4">
                    <asp:Label ID="Label3" runat="server" Text="Choose what you want to update:"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:RadioButton ID="rdLocation" runat="server" Text="Location" GroupName = "radio" />
                </td>
                <td class="auto-style6">
                    <asp:RadioButton ID="rdDateTaken" runat="server" Text="Date Taken" GroupName = "radio" />
                </td>
                <td class="auto-style6">
                    <asp:RadioButton ID="rdImageTaker" runat="server" Text="Uploader" GroupName = "radio" />
                </td>
                <td class="auto-style6">
                    <asp:RadioButton ID="rdComment" runat="server" Text="Comment" GroupName = "radio" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Image to be Updated"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtImage" runat="server" Width="200px"></asp:TextBox>
                    </td>
                <td class="auto-style6" rowspan="2">
                    <asp:Button ID="btnUpdate" runat="server" Height="38px" OnClick="btnUpdate_Click" Text="Update" Width="142px" />
                </td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label2" runat="server" Text="What should it be updated to?"></asp:Label>
                </td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtUpdate" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td class="auto-style10" colspan="2">
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server" Height="235px" Width="801px">
        </asp:GridView>
    </form>
</body>
</html>
