<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="IT_Project.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <style>



.panel-body {  
  
  background: #e5e5e5; /* Old browsers */
  background: -moz-radial-gradient(center, ellipse cover,  #e5e5e5 0%, #ffffff 100%); /* FF3.6+ */
  background: -webkit-gradient(radial, center center, 0px, center center, 100%, color-stop(0%,#e5e5e5), color-stop(100%,#ffffff)); /* Chrome,Safari4+ */
  background: -webkit-radial-gradient(center, ellipse cover,  #e5e5e5 0%,#ffffff 100%); /* Chrome10+,Safari5.1+ */

  background: radial-gradient(ellipse at center,  #e5e5e5 0%,#ffffff 100%); /* W3C */

  font: 600 15px "Open Sans",Arial,sans-serif;
}
.heading{
       font-size: 50px;
      font-weight: 300;
      align-content:center;
/*      align-items:center;
*/
    }
    </style>
</head>
<body>
     <div class='panel-heading'>
   <h5 class='heading'>Intermediary Tracker</h5>
 </div>
    <form id="form1" runat="server">
       
   <div class='container'>

    <div class='panel panel-primary dialog-panel'>
        <asp:TextBox ID="Intermediary" runat="server" Font-Size="Medium"></asp:TextBox>
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />

<%--                <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnSearch_Click" />--%>
      
           <%--  <asp:DropDownList runat="server" ID="dropdown">
                    <asp:ListItem>IntermediaryHouse</asp:ListItem>
                    <asp:ListItem>ConsaltantInitials</asp:ListItem>
                    <asp:ListItem>Activity</asp:ListItem>
                    <asp:ListItem>Region</asp:ListItem>
                    <asp:ListItem>IntermediaryConsultant</asp:ListItem>
                    <asp:ListItem>Company</asp:ListItem>
                    <asp:ListItem>InteractionDate</asp:ListItem>
                    <asp:ListItem>Comment</asp:ListItem>
                </asp:DropDownList>--%>

         

            <br /><br />
        <asp:GridView runat="server" ID="gridview" OnSelectedIndexChanged="gridview_SelectedIndexChanged">
           
        </asp:GridView>


   </div>
  </div>

        
    </form>
</body>
</html>

