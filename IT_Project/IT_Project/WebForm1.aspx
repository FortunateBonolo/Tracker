<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="IT_Project.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            text-align: center;
        }
        .auto-style2 {
            width: 59%;
            height: 221px;
        }
        .auto-style3 {
            font-size: large;
            height: 117px;
            width: 141px;
            text-align: right;
        }
        .auto-style4 {
            height: 117px;
            text-align: left;
        }
        .auto-style6 {
            width: 141px;
            text-align: right;
        }
        .auto-style7 {
            font-size: large;
            height: 57px;
            width: 141px;
            text-align: right;
        }
        .auto-style8 {
            height: 57px;
            text-align: left;
        }
        .auto-style9 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Login Form</strong></div>
        <table class="auto-style2" align="center">
            <tr>
                <td class="auto-style3">Username</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TxtUsername" runat="server" Width="246px" Height="30px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtUsername" ErrorMessage="This if Field is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TxtUsername" ErrorMessage="Please enter valid username" ForeColor="#FF3300" Visible="False"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Password</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TxtPassword" runat="server" Width="246px" Height="30px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtPassword" ErrorMessage="This if Field is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Button ID="BtnLogin" runat="server" Height="46px" Text="Login" Width="249px" OnClick="BtnLogin_Click" />
                </td>
            </tr>
        </table>
      
    </form>
</body>
</html>
