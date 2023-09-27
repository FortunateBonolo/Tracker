<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="IT_Project.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 77px;
        }
        .auto-style4 {
            width: 147px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            WELCOME</div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">Username</td>
                <td>
                    <asp:Label ID="LblUsername" runat="server" Font-Size="Medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">Firstname</td>
                <td>
                    <asp:Label ID="Lblname" runat="server" Font-Size="Medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">Lastname</td>
                <td>
                    <asp:Label ID="LblLastname" runat="server" Font-Size="Medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">User Type</td>
                <td>
                    <asp:Label ID="LblUsertype" runat="server" Font-Size="Medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">Create Date</td>
                <td>
                    <asp:Label ID="LblCreatedate" runat="server" Font-Size="Medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">Activity</td>
                <td><asp:Label ID="LblActivity" runat="server" Font-Size="Medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">Create By</td>
                <td>
                    <asp:Label ID="LblCreatedBy" runat="server" Font-Size="Medium"></asp:Label>
                </td>
            </tr>


             <tr id="btnInter">
             <td class="auto-style3">
                 <asp:Button runat="server" Text="Add Intermediary" OnClick="Unnamed1_Click"></asp:Button>

             </td>
                        <td class="auto-style3" >
                            <asp:Button runat="server" Text="Intermediary" ID="btnInt" OnClick="btnInt_Click1"></asp:Button>

       </td>
   
 </tr>

        </table>
    </form>
</body>
</html>


