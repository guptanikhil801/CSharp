<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FundooNotes.Views.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
<title>Register</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"/>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style2 {
            margin-left: 5px;
        }
        .auto-style3 {
            height: 33px;
        }
        .auto-style4 {
            height: 50px;
        }
        .auto-style5 {
            height: 18px;
        }
        .auto-style6 {
            height: 50px;
            width: 120px;
        }
        .auto-style7 {
            height: 18px;
            width: 120px;
        }
        .auto-style8 {
            height: 33px;
            width: 120px;
        }
        .auto-style9 {
            width: 120px;
        }
        </style>
</head>
<body>
    
      <div class="container p-3 my-3 bg-dark text-white" >
  <h1 class=> &nbsp&nbsp&nbsp&nbsp Fundoo Notes</h1>
    </div>
        <br />
    <p class="text-success" style="font-size:45px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Register</p>
    <div class="container">
 <form id="form1" runat="server">
     
        <table style="font-family:Arial">
             <tr>  
            <td class="auto-style6">  
                <asp:Label ID="FirstNameLabel"  runat="server" Text="First Name"></asp:Label>
            </td>  
            <td class="auto-style4"></td>  
            <td class="auto-style4">  
                <asp:TextBox ID="FirstNameTextBox" class="form-control" runat="server"></asp:TextBox>
            </td>  
        </tr>  
               <tr>  
            <td class="auto-style6">  
                <asp:Label ID="LastNameLabel"  runat="server" Text="Last Name"></asp:Label>
            </td>  
            <td class="auto-style4"></td>  
            <td class="auto-style4">  
                <asp:TextBox ID="LastNameTextBox" class="form-control" runat="server"></asp:TextBox>
            </td>  
        </tr> 
                  <tr>  
            <td class="auto-style6">  
                <asp:Label ID="PhoneNumberLabel"  runat="server" Text="Phone Number"></asp:Label>
            </td>  
            <td class="auto-style4"></td>  
            <td class="auto-style4">  
                <asp:TextBox ID="PhoneNumberTextBox" class="form-control" runat="server"></asp:TextBox>
            </td>  
        </tr> 
        <tr>  
            <td class="auto-style6">  
                <asp:Label ID="EmailLabel"  runat="server" Text="Email"></asp:Label>
            </td>  
            <td class="auto-style4"></td>  
            <td class="auto-style4">  
                <asp:TextBox ID="EmailTextBox" class="form-control" runat="server"></asp:TextBox>
            </td>  
        </tr>  
        <tr>  
            <td class="auto-style7"></td>  
            <td class="auto-style5"></td>  
            <td class="auto-style5"></td>  
        </tr>
            <tr>  
            <td class="auto-style8">  
                <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
            </td>  
            <td class="auto-style3"> </td> 
            <td class="auto-style3">  
                <asp:TextBox ID="PasswordTextBox" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
            </td>  
           </tr> 

              <tr>  
            <td class="auto-style7"></td>  
            <td class="auto-style5"></td>  
            <td class="auto-style5"></td>  
        </tr>

            <tr>  
            <td class="auto-style8">  
                <asp:Label ID="ConfirmPasswordLabel" runat="server" Text=" Confirm Password"></asp:Label>
            </td>  
            <td class="auto-style3"> </td> 
            <td class="auto-style3">  
                <asp:TextBox ID="ConfirmPasswordTextBox" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
            </td>  
           </tr> 
            
        <tr>  
            <td class="auto-style8"></td>  
            <td class="auto-style3"></td>  
            <td class="auto-style3"></td>  
        </tr>

         <tr>
            <td class="auto-style9">  
                <asp:Button class="btn btn-info" ID="RegisterButton" runat="server" Text="Register" CssClass="auto-style2" Height="40px" Width="110px"  />
            </td> 
         </tr>
       
        </table>
    </form>
  </div>
</body>
</html>
