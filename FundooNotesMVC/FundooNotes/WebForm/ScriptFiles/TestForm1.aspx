<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestForm1.aspx.cs" Inherits="FundooNotes.WebForm.ScriptFiles.TestForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />  
<asp:Button ID="Button1" runat="server" Text="Upload" onclick="Button1_Click"/>  
<br />  
<asp:Image ID="Image1" runat="server" />  

        </div>
    </form>
</body>
</html>
