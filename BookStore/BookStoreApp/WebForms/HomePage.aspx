<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="BookStoreApp.WebForms.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="stylesheet" type="text/css" href="StyleSheets/HomePageStyle.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous" />
    <title id="pagetitle" runat="server">Welcome to BookStore</title>
</head>
<body style="background-color: lightgrey">
    <form id="form1" runat="server">

        <%--NavBar-Top--%>
        <nav id="navbarst" class="navbar navbar-expand-sm bg-danger fixed-top ">
            <div class=" text-white">
                <img id="bookiconimg" src="Assets/bookicon.png" height="25" width="25" />
                <h1 id="bookstorelabel">BookStore</h1>
            </div>
            <asp:TextBox ID="searchbar" CssClass="form-control w-50" placeholder="Search" runat="server" OnTextChanged="Search_Button_Click"></asp:TextBox>
            <img id="wishlist" src="Assets/wishlisticon.png" height="30" width="30" title="Wishlist" />
            <img id="cart" src="Assets/carticon.png" height="40" width="40" title="Cart" />
        </nav>

        <%--Hidden Fields--%>
        <asp:HiddenField ID="emailid" Value="" runat="server" />
        <asp:HiddenField ID="bookid" Value="" runat="server" />

        <%--Response Label--%>
        <asp:Label ID="ResponseLabel" CssClass="text-Danger text-left" Style="font-size: 40px; margin-top: 20px" runat="server"></asp:Label>

        <%-- All Books Display Section--%>
        <div class="container">
            <div class=" row" id="allbookrow" runat="server" style="margin-top: 100px; margin-left: 30px; margin-bottom: 10px;">
            </div>
        </div>

        <%--Pagination Section--%>
        <nav style="margin-bottom: 50px">
            <ul class="pagination justify-content-center">
                <li class="page-item disabled">
                    <a class="page-link" href="#" tabindex="-1" aria-disabled="true">Previous</a>
                </li>
                <li class="page-item">
                    <asp:Button ID="page1btn" CssClass="btn btn-light" runat="server" Text="1" /></li>
                <li class="page-item">
                    <asp:Button ID="page2btn" CssClass="btn btn-light" runat="server" Text="2" OnClick="Page_2_Btn" /></li>
                <li class="page-item">
                    <asp:Button ID="page3btn" CssClass="btn btn-light" runat="server" Text="3" OnClick="Page_3_Btn" /></li>
                <li class="page-item">
                    <a class="page-link" href="#">Next</a>
                </li>
            </ul>
        </nav>

        <asp:Button ID="addtowlbtn" CssClass="hbtn" runat="server" OnClick="Add_To_WishList" Text="awl" />

        <%--WishList Display Section--%>
        <div class="container" style="margin-bottom: 50px">
            <h1 class="badge badge-secondary" id="yourwishlistsh1" style="font-size: 35px"></h1>
            <div id="wishlistsection" class="bg-white">
                <div class="wlmaindiv mb-1">
                    <img src="https://www.amazon.in/images/I/41FFzKkk+UL._SX326_BO1,204,203,200_.jpg" width="45" height="55" />
                    <p class="text-primary mt10">You are the Best Wife</p>
                    <div class="wlmaindiv mt10">
                        <p style="margin-right: 8px">Author : </p>
                        <p class="text-dark">Ajay K Pandey</p>
                    </div>
                    <div class="wlmaindiv mt10">
                        <img src='https://png.pngtree.com/png-clipart/20190614/original/pngtree-star-vector-icon-png-image_3725282.jpg' alt='' height='22' width='22' title='Rating' />
                        <p class="ml-2">4.6</p>
                    </div>
                    <div class="wlmaindiv mt10">
                        <p>
                            ₹
                        </p>
                        <p class="text-dark ml-1">499</p>
                    </div>
                    <img class="mt-2" src='Assets/addtocartbtn.png' alt='' height="36" width="95" title='Add to cart' />
                    <img class="mt-3" src='Assets/deleteforever.png' alt='' height='26' width='26' title='Delete From WishList' />
                </div>
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
        function wlfun(bookid) {
            var em = localStorage.getItem("useremail");
            document.getElementById('emailid').setAttribute("value", em);
            document.getElementById('bookid').setAttribute("value", bookid);
            //$("#yourwishlistsh1").text("Your WishLists");
            addtowlbtnclick();
        }
        function addtowlbtnclick() {
            $("#addtowlbtn").click();
        }
    </script>
</body>
</html>
