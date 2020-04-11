<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeForm.aspx.cs" Inherits="EmployeeManagementWCFClient.EmployeeForm" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Management Home Page</title>
    <style>
        .button {
  background-color: #4CAF50; /* Green */
  border: none;
  color: white;
  padding: 6px 14px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 14px;
  margin: 4px 2px;
  transition-duration: 0.4s;
  cursor: pointer;
}
  .button1 {
  background-color: white; 
  color: black; 
  border: 2px solid #4CAF50;
}

  .button1:hover {
  background-color: #4CAF50;
  color: white;
}
    </style>
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
                <asp:Label ID="FirstNameLabel" runat="server" Text="First Name"></asp:Label>
            </td>  
            <td> </td> 
            <td>  
                <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
            </td>  
        </tr>
         <tr>   
            <td>  
                <asp:Label ID="LastNameLabel" runat="server" Text="Last Name"></asp:Label>
            </td>  
            <td></td>  
            <td>  
                <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
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
            <tr>
            <td>  
                <asp:Label ID="DeptIdLabel" runat="server" Text="Department Id"></asp:Label>
            </td>  
            <td> </td> 
            <td>  
                <asp:TextBox ID="DeptIdTextBox" runat="server"></asp:TextBox>
            </td> 
              <td> </td>
            <td> &emsp;&emsp; 
                <asp:Label ID="EmpLabel" runat="server" Text="Employee Id"></asp:Label>
            </td>
                 <td>  
                <asp:TextBox ID="EmpTextBox" runat="server"></asp:TextBox>
            </td> 
        </tr>
              <tr>
            <td>  
                <asp:Button class="button button1" ID="AddButton" runat="server" Text="Add Employee" />
            </td> 
              <td></td>
            <td> &emsp;&emsp;&emsp;
                <asp:Button class="button button1" ID="UpdateButton" runat="server" Text="Update Details" />
            </td>
                 <td></td>
             <td> &emsp;&emsp; 
                <asp:Button class="button button1" ID="DeleteButton" runat="server" Text="Delete" />
            </td>
             <td> &emsp;
                <asp:Button class="button button1" ID="EmployeeByIdButton" runat="server" Text="Search Employee" />
            </td> 
         </tr>
      </table>
    </form>
</body>
</html>
