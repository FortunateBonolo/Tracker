<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form4Cust2.aspx.cs" Inherits="IT_Project.Form4Cust2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
 <link href='https://netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css' rel='stylesheet' type='text/css'>
 <link href='//cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.2.0/css/datepicker.min.css' rel='stylesheet' type='text/css'>
 <link href='//cdnjs.cloudflare.com/ajax/libs/bootstrap-switch/1.8/css/bootstrap-switch.css' rel='stylesheet' type='text/css'>
 <link href='https://davidstutz.github.io/bootstrap-multiselect/css/bootstrap-multiselect.css' rel='stylesheet' type='text/css'>
 <script src='//cdnjs.cloudflare.com/ajax/libs/jquery/2.0.3/jquery.min.js' type='text/javascript'></script>
 <script src='//cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.0/js/bootstrap.min.js' type='text/javascript'></script>
 <script src='//cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.2.0/js/bootstrap-datepicker.min.js' type='text/javascript'></script>
 <script src='//cdnjs.cloudflare.com/ajax/libs/bootstrap-switch/1.8/js/bootstrap-switch.min.js' type='text/javascript'></script>
 <script src='https://davidstutz.github.io/bootstrap-multiselect/js/bootstrap-multiselect.js' type='text/javascript'></script>
<head runat="server">
 <style type="text/css">
.indent-small {
  margin-left: 5px;
}
.form-group.internal {
  margin-bottom: 0;
}

.dialog-panel {
  margin: 10px;
}

.datepicker-dropdown {
  z-index: 200 !important;
}

.panel-body {  
  
  background: #e5e5e5; /* Old browsers */
  background: -moz-radial-gradient(center, ellipse cover,  #e5e5e5 0%, #ffffff 100%); /* FF3.6+ */
  background: -webkit-gradient(radial, center center, 0px, center center, 100%, color-stop(0%,#e5e5e5), color-stop(100%,#ffffff)); /* Chrome,Safari4+ */
  background: -webkit-radial-gradient(center, ellipse cover,  #e5e5e5 0%,#ffffff 100%); /* Chrome10+,Safari5.1+ */

  background: radial-gradient(ellipse at center,  #e5e5e5 0%,#ffffff 100%); /* W3C */

  font: 600 15px "Open Sans",Arial,sans-serif;
}

label.control-label {
  font-weight: 600;
  color: #777;  
}
 </style>
</head>

 
<body>
  <div class='container'>

    <div class='panel panel-primary dialog-panel'>
      <div class='panel-heading'>
        <h5 >Intermediary Tracker</h5>
      </div>
      <div class='panel-body'>
        <form class='form-horizontal' role='form' runat="server">
             <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
                  <div class='form-group'>
                    <label class='control-label col-md-2 col-md-offset-2' for='Intermediary_House'>Intermediary House</label>
                    <div class='col-md-6'>
                      <div class='form-group'>
                        <div class='col-md-11'>
        <%--                  <input class='form-control'  id="txtInterhouse"  placeholder="Intermediary House" type="text" />--%>
                            <asp:TextBox  id="txtInterhouse" runat="server" placeholder='Intermediary House'></asp:TextBox>
                  

                        </div>
                      </div>

                    </div>
                  </div>
            <div class='form-group'>
                  <label class='control-label col-md-2 col-md-offset-2' for='id_email'>Kaelo Consultant</label>
                  <div class='col-md-6' >
                    <div class='form-group'>
                      <div class='col-md-11'>
<%--                        <input class='form-control' id="txtConsult" runat="server" placeholder='Kaelo Consultant' type="text" />--%>
                          <asp:TextBox id="txtConsult" runat="server" placeholder='Kaelo Consultant'></asp:TextBox><asp:UpdatePanel runat="server"></asp:UpdatePanel>
                      </div>
                    </div>
                  </div>
                </div>
   
          <div class='form-group'>
            <label class='control-label col-md-2 col-md-offset-2' for='id_equipment'>Activity type</label>
            <div class='col-md-8'>
              <div class='col-md-3'>
                <div class='form-group internal'>
                 <asp:DropDownList ID="drbUserType" runat="server" Font-Size="Medium" >

                <asp:ListItem Value="">Please Select</asp:ListItem>

                    <asp:ListItem>Call </asp:ListItem>

                    <asp:ListItem>Meeting</asp:ListItem>

                    <asp:ListItem>Email</asp:ListItem>

                    <asp:ListItem>Whatsapp</asp:ListItem>

            </asp:DropDownList>
                </div>
              </div>
            </div>
           </div>
               
               
              <div class='form-group'>
    
               <label class='control-label col-md-2 col-md-offset-2' for='id_equipment'>Region</label>
                 <div class='col-md-8'>
                  <div class='col-md-3'>

                     <div class='form-group internal'>
         
                 <asp:DropDownList ID="drbUserType2" runat="server" Font-Size="Medium" >

                            <asp:ListItem Value="">Please Select</asp:ListItem>

                                <asp:ListItem>KZN </asp:ListItem>

                                <asp:ListItem>CT</asp:ListItem>

                                <asp:ListItem>GT</asp:ListItem>

                        </asp:DropDownList>
  
                  </div>
                </div>
              </div>
            </div>
                        <div class='form-group'>
                  <label class='control-label col-md-2 col-md-offset-2'>Intermediary Consultant</label>
                  <div class='col-md-6' >
                    <div class='form-group'>
                      <div class='col-md-11'>
<%--                        <input class='form-control' id="txtConsult" runat="server" placeholder='Kaelo Consultant' type="text" />--%>
                          <asp:TextBox id="IntermediaryConsultant" runat="server" placeholder='Intermediary Consultant'></asp:TextBox>
                      </div>
                    </div>
                  </div>
                </div>

                 <div class='form-group'>
                  <label class='control-label col-md-2 col-md-offset-2' >Company name</label>
                  <div class='col-md-6' >
                    <div class='form-group'>
                      <div class='col-md-11'>
<%--                        <input class='form-control' id="txtConsult" runat="server" placeholder='Kaelo Consultant' type="text" />--%>
                          <asp:TextBox id="txtCompany" runat="server" placeholder='Company name'></asp:TextBox>
                      </div>
                    </div>
                  </div>
                </div>
             <div class='form-group'>
                    <label class='control-label col-md-2 col-md-offset-2'>Date</label>
                    <div class='col-md-8'>
                      <div class='col-md-3' id="date">
                        <div class='form-group internal input-group'>
                          <asp:TextBox id="date" runat="server" placeholder='Created date'></asp:TextBox>
                            </div>
                      </div>
                    </div>
                  </div>
       


           <div class='form-group'>
            <label class='control-label col-md-2 col-md-offset-2' for='id_comments'>Comment</label>
            <div class='col-md-6'>
              <div class='form-group'>
                <div class='col-md-11' >
                  
                      <asp:TextBox id="txtComment" runat="server" placeholder='add comment'></asp:TextBox>


                </div>
              </div>

            </div>
          </div>

          <div class='form-group' colspan="2">
            <div class='col-md-6' >
             <%-- <textarea class='form-control' runat="server" id="txtComment"  placeholder='Additional comments' rows='3'  type="text"></textarea>--%>
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="BtnUpdate_Click1" />
            </div>
             
          

                    <div class='col-md-3'>
                        <asp:Button runat="server" Text="View History" ID="Button2" OnClick="btnView_Click"></asp:Button>
                      </div>
           </div>
               <br /><br />
        


        </form>
      </div>
    </div>

  </div>


          

    
     


      
</body>


</html>

