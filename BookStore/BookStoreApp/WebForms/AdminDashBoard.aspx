<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashBoard.aspx.cs" Inherits="BookStoreApp.WebForms.AdminDashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="stylesheet" type="text/css" href="StyleSheets/AdBoard.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous" />
    <title>Admin DashBoard</title>
</head>
<body style="background-color: lightgrey">
    <form id="form1" runat="server">

        <%--NavBar-Top--%>
        <nav id="navbarst" class="navbar navbar-expand-sm bg-danger fixed-top ">
            <div class=" text-white">
                <img id="bookiconimg" src="Assets/bookicon.png" height="25" width="25" />
                <h1 id="bookstorelabel">BookStore</h1>
            </div>
            <h1 id="adlabel" class="text-white">Admin DashBoard</h1>
            <asp:TextBox ID="searchbar" CssClass="form-control w-25" placeholder="Search" runat="server"></asp:TextBox>
        </nav>

        <%-- Add and Update Book Section --%>
        <div style="margin-top: 70px;" class="container">
            <div class="card">
                <div class="card-body">
                    <h5 id="updateaddheading" class="card-title">Add a New Book</h5>

                    <%--Hidden Field for storing Bookid--%>
                    <asp:HiddenField ID="bookid" Value="" runat="server" />
                    <div class="oprow">
                        <label for="AddBookNameTextBox" class=" col-form-label ">Name</label>
                        <asp:TextBox CssClass="form-control w-25" ID="AddBookNameTextBox" runat="server"></asp:TextBox>
                        <label for="AddBookAuthorTextBox" class="col-form-label ">Author</label>
                        <asp:TextBox CssClass="form-control w-25" ID="AddBookAuthorTextBox" runat="server"></asp:TextBox>
                        <label for="AddBookPriceTextBox" class=" col-form-label ">Price</label>
                        <asp:TextBox CssClass="form-control w-25" ID="AddBookPriceTextBox" runat="server"></asp:TextBox>
                    </div>
                    <div class="oprow">
                        <label for="AddBookAvailableStockTextBox" class="col-form-label ">AvailableStock</label>
                        <asp:TextBox CssClass="form-control w-25" ID="AddBookAvailableStockTextBox" runat="server"></asp:TextBox>
                        <label for="AddBookRatingTextBox" class="col-form-label ">Rating</label>
                        <asp:TextBox CssClass="form-control w-25" ID="AddBookRatingTextBox" runat="server"></asp:TextBox>
                        <label for="AddBookDescriptionTextBox" class="col-form-label ">Description</label>
                        <asp:TextBox CssClass="form-control w-25" ID="AddBookDescriptionTextBox" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <label for="AddBookImage" class="col-form-label ">Book Image Link</label>
                        <asp:TextBox CssClass="form-control w-50" ID="AddBookImageTextBox" runat="server"></asp:TextBox>
                        <asp:Button ID="updatebookbtn" CssClass="btn btn-outline-danger updatebookbtn" runat="server" Text="Update Book" OnClick="Update_Book_By_Admin_Btn" />
                        <asp:Button ID="addbookbtn" CssClass="btn btn-outline-danger addbookbtn" runat="server" Text="Add Book" OnClick="Add_Book_By_Admin_Btn" />
                    </div>
                </div>
            </div>
            <asp:Label ID="ResponseLabel" CssClass="text-Danger text-left" Style="font-size: 40px; margin-top: 20px" runat="server"></asp:Label>
            <asp:Button ID="hiddendeletebutton" CssClass="btn btn-outline-danger deletebookbtn " runat="server" Text="delete" OnClick="Delete_Book_By_Admin" />

            <%-- All Books Display Section--%>
            <div class="container">
                <div class=" row" id="allbookrow" runat="server" style="margin-top: 19px">
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
        function deletefun(id) {
            document.getElementById('bookid').setAttribute("value", id);
            deleteclick();
        }

        function deleteclick() {
            $("#hiddendeletebutton").click();
        }

        function updatefun(id) {
            document.getElementById('bookid').setAttribute("value", id);
            $("#updateaddheading").text("Update Book");
            document.getElementById('addbookbtn').style.visibility = "hidden";
            document.getElementById('updatebookbtn').style.visibility = "visible";
        }
    </script>
</body>
</html>
