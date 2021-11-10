<%@ Page Title="View Pictures" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="GolfShot.About" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2 align="center"><strong> <%: Title %>. </strong><table style="width:100%;">
        <tr>
            <td class="modal-sm" style="width: 301px" align ="center"> <button style="width: 234px"><a href="/Upload">Upload Image</a></button></td>
            <td class="modal-sm" style="width: 301px" align ="center"> <button style="width: 234px"><a href="/User">MyImages</a></button></td>
            <td class="modal-sm" style="width: 301px" align ="center"> <button style="width: 234px"><a href="/MetaData">ImageInformation</a></button></td>
        </tr>
        </table>
    </h2>
    <h3 align ="center">Here you can View al the uploaded pictures,
        <strong><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></strong>
    </h3>
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
                               <h1> Date Uploaded</h1>
                           </td>
                           <td>
                               <h1> Download</h1>
                           </td>
                    </tr>
                    <tr> 
                        <td align ="center"> <img src="<%#Eval("ImagePath") %>" height ="200", width = "200" /></td>
                        <td align ="center"> <h3> <%# Eval("Uploader") %> </h3> </td>                  
                        <td align ="center"> <h3> <%# Eval("DateUploaded") %> </h3></td>
                        <td align ="center"><button> <a href="<%#Eval("ImagePath") %>">Download Now</a> </button></td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </p>

</asp:Content>
