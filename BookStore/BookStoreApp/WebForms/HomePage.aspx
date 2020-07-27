<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="BookStoreApp.WebForms.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="stylesheet" type="text/css" href="StyleSheets/HomePageStyle.css" />
    <link rel="stylesheet" type="text/css" href="StyleSheets/CartStyle.css" />
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
            <asp:ImageButton ImageUrl="Assets/wishlisticon.png" Height="30" Width="30" runat="server" OnClick="wishlistdisplay" />
            <asp:ImageButton ID="cartbtn" ImageUrl="Assets/carticon.png" Height="40" Width="40" runat="server" CssClass="ml7" OnClick="Cartdisplay" />
            <button onclick="signout()" style="outline: none; border: none; background: none; margin-left: 20px">
                <h4 id="logoutbtn" class=" text-lg text-white font-italic"></h4>
            </button>
        </nav>

        <%--  Hidden Fields  --%>
        <asp:HiddenField ID="emailid" Value="" runat="server" />
        <asp:HiddenField ID="bookid" Value="" runat="server" />
        <asp:HiddenField ID="wishlistid" Value="" runat="server" />
        <asp:HiddenField ID="cartid" Value="" runat="server" />
        <asp:Button ID="addtowlbtn" CssClass="hbtn" runat="server" OnClick="Add_To_WishList" Text="awl" />
        <asp:Button ID="wishlistdeletebutton" CssClass="hbtn " runat="server" Text="deletewislist" OnClick="Delete_Book_From_WishList" />
        <asp:Button ID="AddToCartButton" CssClass="hbtn" runat="server" OnClick="Add_To_Cart" Text="atc" />
        <asp:Button ID="cartbookdeletebutton" CssClass="hbtn" runat="server" OnClick="Cart_Delete" />

        <%--Response Label--%>
        <asp:Label ID="ResponseLabel" CssClass="text-Danger text-left" Style="font-size: 40px; margin-top: 20px" runat="server"></asp:Label>

        <%-- All Books Display Section--%>
        <div class="container" id="bookdisplaydiv" runat="server">
            <div class=" row" id="allbookrow" runat="server" style="margin-top: 100px; margin-left: 30px; margin-bottom: 10px;">
            </div>
        </div>


        <%--Pagination Section--%>
        <nav style="margin-bottom: 50px" id="paginationsection" runat="server">
            <ul class="pagination justify-content-center">
                <li class="page-item disabled">
                    <a class="page-link" href="#" tabindex="-1" aria-disabled="true">Previous</a>
                </li>
                <li class="page-item">
                    <asp:Button ID="page1btn" CssClass="btn btn-light" runat="server" Text="1" />
                </li>
                <li class="page-item">
                    <asp:Button ID="page2btn" CssClass="btn btn-light" runat="server" Text="2" OnClick="Page_2_Btn" />
                </li>
                <li class="page-item">
                    <asp:Button ID="page3btn" CssClass="btn btn-light" runat="server" Text="3" OnClick="Page_3_Btn" />
                </li>
                <li class="page-item">
                    <a class="page-link" href="#">Next</a>
                </li>
            </ul>
        </nav>

        <%--WishList Display Section--%>
        <div class="container" style="margin-bottom: 50px">
            <h1 class="badge badge-secondary  font-italic" id="yourwishlistsh1" runat="server" style="font-size: 35px; margin-top: 40px"></h1>
            <div id="wishlistsection" class="bg-white" runat="server">
            </div>
        </div>

        <%--Cart section--%>
        <div class="bg-white cartmaindiv">
            <h4 class="ml-5 mt-2" id="MYCartHeading" runat="server"></h4>
            <div id="MyCartDispDiv" runat="server">
            </div>
        </div>

        <%--change quantity--%>
        <div class="modal fade" id="changequantitymodal" tabindex="-1" role="dialog" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <asp:TextBox ID="changequantityinp" CssClass="form-control" runat="server" placeholder="Enter quantity of books" OnTextChanged="Change_Quantity" />
                    </div>
                    <button type="button" class=" btn-primary w-50" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>

        <%--Address Details--%>
        <div runat="server" style="display: none" id="addresssection">
            <div class="bg-white cartmaindiv mt-n4 ">
                <h5 class="ml-5 mt-2">Customer Details</h5>
                <div class="form-row mt-4">
                    <div class="form-group col  ml-3">
                        <label>Name</label>
                        <input id="CustomerName" type="text" class="form-control w90" value="" runat="server" disabled="disabled" />
                    </div>
                    <div class="form-group col">
                        <label>Phone Number</label>
                        <input type="text" id="CustomerPhone" class="form-control w90" style="width: 90%" value="" runat="server" disabled="disabled" />
                    </div>
                </div>
                <div class="form-group ml-3">
                    <label>Address</label>
                    <input type="text" class="form-control" id="CustomerAddress" value="" runat="server" style="width: 95%" disabled="disabled" />
                </div>
                <div class="form-row">
                    <div class="form-group col-md-6 ml-3">
                        <label>City</label>
                        <input type="text" id="CustomerCity" class="form-control w90" value="" runat="server" disabled="disabled" />
                    </div>

                    <div class="form-group col mb-4">
                        <label>Pin Code</label>
                        <input type="text" id="CustomerPin" class="form-control" value="" runat="server" style="width: 90%" disabled="disabled" />
                    </div>
                </div>
                <asp:Button runat="server" CssClass=" btn-outline-danger" Text="Continue to Payment" OnClick="Go_To_Payment" />
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
                document.getElementById('emailid').setAttribute("value", em);
                $('#logoutbtn').text("Logout");
            }
        });

        function wlfun(bookid) {
            document.getElementById('bookid').setAttribute("value", bookid);
            addtowlbtnclick();
        }
        function addtowlbtnclick() {
            $("#addtowlbtn").click();
        }

        function deletewishlistfun(id) {
            document.getElementById('wishlistid').setAttribute("value", id);
            deletewishlistclick();
        }

        function deletewishlistclick() {
            $("#wishlistdeletebutton").click();
        }

        function AddToCartfun(id) {
            document.getElementById('bookid').setAttribute("value", id);
            AddToCartClick();
        }

        function AddToCartClick() {
            $("#AddToCartButton").click();
        }

        function cartbookdelete(id) {
            document.getElementById('cartid').setAttribute("value", id);
            deletecartclick();
        }

        function deletecartclick() {
            $('#cartbookdeletebutton').click();
        }

        function changequantityfun(id) {
            document.getElementById('cartid').setAttribute("value", id);
        }

        function signout() {
            localStorage.removeItem('useremail');
            localStorage.removeItem('totalamount');
            window.location.reload();
        }
    </script>
</body>
</html>
