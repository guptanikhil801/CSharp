<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="BookStoreApp.WebForms.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous" />
    <title>Welcome to BookStore</title>
    <style>
        #bookiconimg {
            margin-left: 30%;
            border-radius: 4px;
            margin-bottom: 3px
        }

        #bookstorelabel {
            font-size: 25px;
            margin-top: -32px;
            margin-left: 55%;
            margin-bottom: -1px;
        }

        #navbarst {
            margin-top: 2px;
            border-radius: 5px
        }

        #navfooter {
            margin-left: 40%;
            margin-bottom: -3px
        }

        #searchbar {
            margin-left: 15%;
            margin-right: 8%
        }

        #wishlist {
            margin-right: 5%;
        }
    </style>
</head>
<body style="background-color: lightgrey">
    <form id="form1" runat="server">
        <div class="container">
            <nav id="navbarst" class="navbar navbar-expand-sm bg-danger ">
                <div class=" text-white">
                    <img id="bookiconimg" src="Assets/bookicon.png" height="25" width="25" />
                    <h1 id="bookstorelabel">BookStore</h1>
                </div>
                <asp:TextBox ID="searchbar" CssClass="form-control w-50" placeholder="Search" runat="server"></asp:TextBox>
                <img id="wishlist" src="Assets/wishlisticon.png" height="30" width="30" title="Wishlist" />
                <img id="cart" src="Assets/carticon.png" height="40" width="40" title="Cart" />
            </nav>

            <nav class="navbar navbar-expand-sm bg-dark navbar-dark fixed-bottom">
                <p id="navfooter" class="text-white text-center">Copyright @ BookStore Private Limited</p>
            </nav>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
</body>
</html>
