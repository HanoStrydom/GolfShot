<%@ Page Title="View Pictures" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="GolfShot.About" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2 align="center"><strong> <%# Eval("GolfCourse") %>. </strong><table style="width:100%;">
        <tr>
            <td class="modal-sm" style="width: 301px" align ="center"> <button style="width: 234px"><a href="/Upload">Upload Image</a></button></td>
            <td class="modal-sm" style="width: 301px" align ="center"> <button style="width: 234px"><a href="/User">MyImages</a></button></td>
            <td class="modal-sm" style="width: 301px" align ="center"> <button style="width: 260px"><a href="/MetaData">ImageInformation</a></button></td>
        </tr>
        </table>
    </h2>
    <h3 align ="center">Here you can View al the uploaded pictures,
        <strong><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></strong>
    </h3>
    <p align ="center">
        <table style="width:100%;">
            <tr>
                <td colspan="3" style="height: 31px">
                    <asp:Label ID="Label2" runat="server" Text="Enter Criteria to search: "></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="height: 31px" class="text-center" colspan="3">
                    <asp:Button ID="btnAll" runat="server" OnClick="btnAll_Click" Text="Show All" Visible="False" Width="200px" />
                </td>
            </tr>
            <tr>
                <td style="height: 31px; width: 548px;" class="text-right">
                    <asp:Label ID="Label3" runat="server" Text="Search By Name:"></asp:Label>
                </td>
                <td style="height: 31px; width: 309px;">
                    <asp:TextBox ID="txtName" runat="server" Width="243px"></asp:TextBox>
                </td>
                <td style="height: 31px" class="text-left">
                    <asp:Button ID="btnName" runat="server" OnClick="btnName_Click" Text="Search" Width="200px" />
                </td>
            </tr>
            <tr>
                <td class="text-right" style="width: 548px">
                    <asp:Label ID="Label4" runat="server" Text="Search By Location: "></asp:Label>
                </td>
                <td style="width: 309px">
                    <asp:TextBox ID="txtLocation" runat="server" Width="243px"></asp:TextBox>
                </td>
                <td class="text-left">
                    <asp:Button ID="btnLocation" runat="server" OnClick="btnLocation_Click" Text="Search" Width="200px" />
                </td>
            </tr>
            <tr>
                <td class="text-right" style="width: 548px">Search By Course: </td>
                <td style="width: 309px">
                    <asp:TextBox ID="txtCourse" runat="server" Width="243px"></asp:TextBox>
                </td>
                <td class="text-left">
                    <asp:Button ID="btnCourse" runat="server" OnClick="btnCourse_Click" Text="Search" Width="200px" />
                </td>
            </tr>
        </table>
    </p>
    <p>
        <asp:DataList ID="DataList1" runat="server"  align ="center">
            <ItemTemplate>
                <table style="width:100%"> 
                    <tr>
                           <td>
                               <h1> Image</h1>
                           </td>
                           <td>
                               <h1> Uploader</h1>
                           </td>
                           <td>
                               <h1> Golf Course</h1>
                           </td>
                           <td>
                               <h1> Comment</h1>
                           </td>
                           <td>
                               <h1> Date Uploaded</h1>
                           </td>
                           <td>
                               <h1> Download</h1>
                           </td>
                    </tr>
                    <tr> 
                        <td align ="center"> <img src="<%#Eval("ImagePath") %>" height ="300", width = "350" /></td>
                        <td align ="center"> <h3> <%# Eval("Uploader") %> </h3> </td>
                        <td align ="center"> <h3> <%# Eval("GolfCourse") %> </h3> </td>
                        <td align ="center"> <h3> <%# Eval("Comment") %> </h3> </td>
                        <td align ="center"> <h3> <%# Eval("DateUploaded") %> </h3></td>
                        <td align ="center"><button> <a href="<%#Eval("ImagePath") %>">Download Now</a> </button></td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </p>

</asp:Content>
