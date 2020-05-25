<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="FundooNotes.AspxFiles.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HomePage Fundoo Notes</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
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
        .auto-style12 {
            height: 17px;
            width: 120px;
        }
        .auto-style13 {
            height: 17px;
        }
        .auto-style14 {
            height: 10px;
            width: 120px;
        }
        .auto-style15 {
            height: 10px;
        }
        .auto-style16 {
            width: 121px;
        }
        </style>
</head>
<body>
    
      <div class="container p-3 my-3 bg-dark text-white" >
  <h1 class=> &nbsp&nbsp&nbsp&nbsp Fundoo Notes</h1>
    </div>
        <br />
    <div class="container">
 <form id="form1" runat="server">
     
        <table style="font-family:Arial">
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
            <td class="auto-style8"></td>  
            <td class="auto-style3"></td>  
            <td class="auto-style3"></td>  
        </tr>
         <tr>
            <td class="auto-style9">  
                <asp:Button class="btn btn-info" ID="LoginButton" runat="server" Text="Login" CssClass="auto-style2" Height="40px" Width="110px"  />
            </td> 
             
         </tr>
            <tr>  
            <td class="auto-style12"></td>
               
            <td class="auto-style13"></td>  
            <td class="auto-style13"></td>  
        </tr>  
        <tr>  
            <td class="auto-style14"></td>  
            <td class="auto-style15">  
                <asp:Label ID="ResponseLabel" runat="server"></asp:Label></td>  
            <td class="auto-style15"></td>
            </tr>
            <tr>
               <td>  
               <p style="font-size:20px" ><a href="https://localhost:44337/AspxFiles/ForgotPassword.aspx">Forgot Password</a></p></td>
            <td></td>
                <td>  
               <p style="font-size:20px" ><a href="https://localhost:44337/AspxFiles/Register.aspx">Register</a></p></td>
            </tr>
        </table>
         
    </form>
  </div>
</body>
</html>
