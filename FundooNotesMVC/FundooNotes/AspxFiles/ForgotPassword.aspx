<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="FundooNotes.Views.ForgotPassword" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forgot Password</title>
    <meta name="viewport" content="width=device-width, initial-scale=1/">
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
        .auto-style6 {
            height: 50px;
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
     <p class="text-success" style="font-size:45px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Forgot Password</p>
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
            <td class="auto-style8"></td>  
            <td class="auto-style3"></td>  
            <td class="auto-style3"></td>  
        </tr>
         <tr>
            <td class="auto-style9">  
                <asp:Button class="btn btn-info" ID="FogotButton" runat="server" Text="Submit" CssClass="auto-style2" Height="40px" Width="110px"  />
            </td> 
        </table>
         
    </form>
  </div>
</body>
</html>
