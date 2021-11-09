<%@ Page Title="Upload Images" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="GolfShot.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <button><a href="/View">View Images</a></button>
    <h2><%: Title %>.</h2>
    <h3>Please upload your images here :</h3>
    <p>
        <table style="width:100%;">
            <tr>
                <td style="height: 20px; width: 129px">
        <asp:Label ID="Label1" runat="server" Text="Uploader: "></asp:Label>
                </td>
                <td style="height: 20px">
        <asp:TextBox ID="txtUploader" runat="server" Width="141px" style="margin-left: 0px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 129px">
                    <asp:Label ID="Label3" runat="server" Text="Image Name: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtImageName" runat="server" Width="141px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 129px; margin-left: 80px">
                    <asp:Label ID="Label4" runat="server" Text="Location Taken: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLocationTaken" runat="server" Width="141px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 129px; margin-left: 80px">
                    <asp:Label ID="Label5" runat="server" Text="Date Taken: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTaken" runat="server" Width="141px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 129px; margin-left: 80px">
        <asp:Label ID="Label2" runat="server" Text="Image: "></asp:Label>
                </td>
                <td>
        <asp:FileUpload ID="FileUpload1" runat="server" Width="211px" />
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 129px; margin-left: 80px">&nbsp;</td>
                <td class="text-center">
                    <asp:Label ID="Label6" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 129px; margin-left: 80px">&nbsp;</td>
                <td class="text-center">
                    <asp:Image ID="Image1" runat="server" Height="144px" Visible="False" Width="257px" />
                </td>
            </tr>
        </table>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload Image" />
    </p>
    
</asp:Content>
