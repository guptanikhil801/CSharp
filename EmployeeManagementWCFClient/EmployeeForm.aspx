<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeForm.aspx.cs" Inherits="EmployeeManagementWCFClient.EmployeeForm" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Management Home Page</title>
</head>
<body>
    <h1 style="color:#069">Employee Management WCF Service</h1>
    <form id="form1" runat="server">
        <table style="font-family:Arial">
              <tr>
            <td>  
                <asp:Label ID="EmployeeIdLabel" runat="server" Text="Employee Id"></asp:Label>
            </td>  
            <td> </td> 
            <td>  
                <asp:TextBox ID="EmployeeIDTextBox" runat="server"></asp:TextBox>
            </td>  
        </tr>
                <tr>   
            <td>  
                <asp:Label ID="EmailLabel" runat="server" Text="Email&emsp;"></asp:Label>
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
            
      </table>
    </form>
</body>
</html>
