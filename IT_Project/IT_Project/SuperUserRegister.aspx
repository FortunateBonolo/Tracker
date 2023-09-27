<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SuperUserRegister.aspx.cs" Inherits="IT_Project.SuperUserRegister" %>

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
     .auto-style5 {
         width: 253px;
     }
    h1 {
  position: relative;
  padding: 0;
  margin: 0;
  font-family: "Raleway", sans-serif;
  font-weight: 300;
  font-size: 40px;
  color: #080808;
  -webkit-transition: all 0.4s ease 0s;
  -o-transition: all 0.4s ease 0s;
  transition: all 0.4s ease 0s;
}

h1 span {
  display: block;
  font-size: 0.5em;
  line-height: 1.3;
}
h1 em {
  font-style: normal;
  font-weight: 600;
}
     .one h1 {
  text-align: center;
  text-transform: uppercase;
  padding-bottom: 5px;
}
 </style>
</head>
<body>
    <form id="form2" runat="server">
        
        <div class="one">
          <h1>Add a new consultant</h1>
        </div>
        <div class="auto-style1">
            
            
        </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">Username&nbsp;</td>
                <td class="auto-style5">   <asp:TextBox ID="Txtusername" runat="server" Font-Size="Medium" ></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>

                <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">Password</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtPassword" runat="server" Font-Size="Medium" type="Password" ViewStateMode="Disabled" ClientIDMode="Predictable"></asp:TextBox>
                </td>
                
            </tr>

            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">Firstname</td>
                <td class="auto-style5">
                    <asp:TextBox ID="Txtname" runat="server" Font-Size="Medium"></asp:TextBox>
                </td>
                <td><asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click" />
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">Lastname</td>
                <td class="auto-style5">
                    <asp:TextBox ID="Txtlastname" runat="server" Font-Size="Medium"></asp:TextBox></td>
                <td>
                    &nbsp;<asp:Button ID="BtnUpdate" runat="server" Text="Update" OnClick="BtnUpdate_Click1" /></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">User Type</td>
                <td class="auto-style5">
                    <asp:DropDownList ID="drbUserType" runat="server" Font-Size="Medium" >

                        <asp:ListItem Value="">Please Select</asp:ListItem>

                            <asp:ListItem>Super User </asp:ListItem>

                            <asp:ListItem>Admin</asp:ListItem>

                            <asp:ListItem>consultant</asp:ListItem>

                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;<asp:Button ID="BtnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" /></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">Create Date</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TxtCreateDate" runat="server" Font-Size="Medium"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">Activity</td>
                <td class="auto-style5">
                    <asp:RadioButton ID="RdbYes" runat="server" Font-Size="Medium" Text="Active" />
&nbsp;<asp:RadioButton ID="RdbNo" runat="server" Font-Size="Medium" Text="Not Active" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">Create By</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TxtCreateBy" runat="server" Font-Size="Medium"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    
                    
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    
                </td>
                <td class="auto-style5">
    &nbsp;                
                
                    
                    
                <asp:GridView runat="server" ID="gridview"></asp:GridView>
                </td>
                <td>
                    
                </td>
            </tr>
        </table>
      
    </form>
</body>
</html>
