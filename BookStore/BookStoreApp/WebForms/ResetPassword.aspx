<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="BookStoreApp.WebForms.ResetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous" />
    <title>Reset Password</title>
    <style>
        #bookiconimg {
            margin-top: -47px;
            margin-bottom: -12px;
            margin-left: 210%;
            border-radius: 6px;
        }

        #bookstorelabel {
            font-size: 45px;
            margin-top: -57px;
            margin-bottom: -23px;
            margin-left: 230%;
            margin-right: 45%
        }

        #navbarst {
            margin-top: 2px;
            margin-left: 2px;
            margin-right: 2px;
            border-radius: 5px
        }

        #navfooter {
            margin-left: 40%;
            margin-bottom: -3px
        }
    </style>
</head>
<body style="background-color: lightgrey">
    <form id="form1" runat="server">
        <nav id="navbarst" style="" class="navbar navbar-dark bg-danger">
            <div class=" p-3 my-3  text-white">
                <img id="bookiconimg" src="Assets/bookicon.png" height="40" width="40" />
                <h1 id="bookstorelabel">BookStore</h1>
            </div>
        </nav>
        <div class="container">
            <p class="text-Danger text-left" style="font-size: 60px">Reset Password</p>
            <asp:Label ID="ResponseLabel" CssClass="text-Danger text-left" Style="font-size: 33px" runat="server"></asp:Label>
            <div style="margin-top: 10px" class="input-group mb-3 w-50">
                <div class="input-group-prepend">
                    <span class="input-group-text">&nbsp&nbsp Email &nbsp&nbsp</span>
                </div>
                <asp:TextBox CssClass="form-control" ID="EmailTextBox" runat="server" placeholder="Enter Email"></asp:TextBox>
            </div>
            <div style="margin-top: 7px" class="input-group mb-3">
                <div class="input-group-prepend">
                    <span class="input-group-text">&nbsp&nbsp&nbsp&nbsp Password&nbsp&nbsp&nbsp&nbsp</span>
                </div>
                <asp:TextBox class="form-control" ID="PasswordTextBox" TextMode="Password" runat="server" placeholder="Enter Password"></asp:TextBox>
                <asp:TextBox class="form-control" ID="ConfirmPasswordTextBox" TextMode="Password" runat="server" placeholder="Confirm Password"></asp:TextBox>
            </div>
            <asp:Button CssClass="btn btn-outline-danger" runat="server" Text="Reset" OnClick="Reset_Button" />

        </div>
        <nav class="navbar navbar-expand-sm bg-dark navbar-dark fixed-bottom">
            <p id="navfooter" class="text-white text-center">Copyright @ BookStore Private Limited</p>
        </nav>
    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
</body>
</html>
