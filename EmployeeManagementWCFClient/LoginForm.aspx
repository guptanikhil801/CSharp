<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="EmployeeManagementWCFClient.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <h1 style="color:#069">Login</h1>
    <form id="form1" runat="server">
        <table style="font-family:Arial">
        <tr>  
            <td>  
                <asp:Label ID="EmailLabel" runat="server" Text="Email"></asp:Label>
            </td>  
            <td></td>  
            <td>  
                <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
            </td>  
        </tr>  
        <tr>  
            <td></td>  
            <td></td>  
            <td></td>  
        </tr>
            <tr>  
            <td>  
                <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
            </td>  
            <td> </td> 
            <td>  
                <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
            </td>  
           </tr>  
        <tr>  
            <td></td>  
            <td></td>  
            <td></td>  
        </tr>
         <tr>
            <td>  
                <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="Login_Button_Click" />
            </td>  
         </tr>
            <tr>  
            <td></td>  
            <td></td>  
            <td></td>  
        </tr>  
        <tr>  
            <td></td>  
            <td>  
                <asp:Label ID="ResponseLabel" runat="server"></asp:Label></td>  
            <td></td>
            </tr>
        </table>
    </form>
</body>
</html>
