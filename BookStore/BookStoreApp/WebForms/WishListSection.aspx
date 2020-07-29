<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WishListSection.aspx.cs" Inherits="BookStoreApp.WebForms.WishListSection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="stylesheet" type="text/css" href="StyleSheets/HomePageStyle.css" />
    <link rel="stylesheet" type="text/css" href="StyleSheets/CartStyle.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous" />
    <title>WishLists</title>
</head>
<body style="background-color: lightgrey">
    <form id="form1" runat="server">
        <%--hidden fields--%>
        <asp:HiddenField ID="emailhidden" runat="server" Value="" />

        <%--NavBar-Top--%>
        <nav id="navbarst" class="navbar navbar-expand-sm bg-danger fixed-top " style="margin-bottom: 80px">
            <div class=" text-white">
                <img id="bookiconimg" src="Assets/bookicon.png" height="25" width="25" />
                <h1 id="bookstorelabel">BookStore</h1>
            </div>
            <asp:TextBox ID="searchbar" CssClass="form-control w-50" placeholder="Search" runat="server" />
            <asp:ImageButton ID="cartbtn" ImageUrl="Assets/carticon.png" Height="40" Width="40" runat="server" CssClass="ml7" />
            <button onclick="signout()" style="outline: none; border: none; background: none; margin-left: 20px">
                <h4 id="logoutbtn" class=" text-lg text-white font-italic"></h4>
            </button>
        </nav>
        <asp:Button runat="server" Text="pressme" ID="showbtn" OnClick="Show_WishList" />

        <%--WishList Display Section--%>
        <div class="container" style="margin-bottom: 50px" id="wildiv" runat="server">
            <h1 class="badge badge-secondary  font-italic" id="yourwishlistsh1" runat="server" style="font-size: 35px; margin-top: 40px"></h1>
            <div id="wishlistsection" class="bg-white" runat="server">
            </div>
        </div>

        <%--NavBar-Bottom--%>
        <nav class="navbar navbar-expand-sm bg-dark navbar-dark fixed-bottom">
            <p id="navfooter" class="text-white text-center">Copyright @ BookStore Private Limited</p>
        </nav>
    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
    <script>
        $(document).ready(function () {
            var em = localStorage.getItem("useremail");
            if (em != null) {
                document.getElementById('emailhidden').setAttribute("value", em);
                $('#logoutbtn').text("Logout");
                $('#showbtn').click();
            }
        });

        function signout() {
            localStorage.removeItem('useremail');
            localStorage.removeItem('totalamount');
            window.location.reload();
        }

        function deletewishlistfun(id) {
            document.getElementById('wishlistid').setAttribute("value", id);
            deletewishlistclick();
        }

        function deletewishlistclick() {
            $("#wishlistdeletebutton").click();
        }

    </script>
</body>
</html>
