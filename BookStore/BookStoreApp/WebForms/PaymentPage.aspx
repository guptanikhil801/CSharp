<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentPage.aspx.cs" Inherits="BookStoreApp.WebForms.PaymentPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="stylesheet" type="text/css" href="StyleSheets/PaymentStyle.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous" />
    <title>Payment</title>

</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField ID="emailid" Value="" runat="server" />
        <asp:Button runat="server" ID="addbtn" CssClass=" dn" Text="add" OnClick="ShowAdd" />
        <%--NavBar-Top--%>
        <nav id="navbarst" class="navbar navbar-expand-sm bg-danger fixed-top ">
            <div class=" text-white">
                <img id="bookiconimg" src="Assets/bookicon.png" height="25" width="25" />
                <h1 id="bookstorelabel">BookStore</h1>
            </div>
        </nav>

        <%--Address Details--%>
        <div runat="server" id="addresssection" class="selectpaymentdiv">
            <div class="bg-white cartmaindiv mt-n4 ">
                <h5 class="ml-5 mt-2">Customer Address and details</h5>
                <p id="amountp" style="margin-left: 50%; margin-bottom: -20px; margin-top: -30px"></p>
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
                <label style="margin-right: 60px;">
                    <input type="radio" id="homeaddradio" runat="server" class="radio" name="aoptradio" onclick="ShowAdd()" />&nbsp&nbsp Home
                </label>
                <label style="margin-right: 60px;">
                    <input type="radio" id="workaddradio" class="radio" name="aoptradio" />&nbsp&nbsp Work
                </label>
                <asp:Button runat="server" CssClass="btn-outline-danger" Text="Continue to Payment" OnClick="PayDetails" />
            </div>
        </div>

        <div class="selectpaymentdiv" runat="server" id="maindiv" style="display: none">
            <h4>Select A Payment Method</h4>
            <div class="card">
                <div class="addcardmar">
                    <h6 id="amounth6"></h6>
                    <label>
                        <input type="radio" id="cardradio" class="radio" name="optradio" checked="checked" />&nbsp&nbsp Add Debit/Credit/ATM Card
                    </label>
                    <br />
                    <img src="Assets/cardtype.png" height="36" width="366" />
                    <div id="paybycardsection" class="addcarddiv">
                        <div class="form-group col  ml-3">
                            <label>Name On Card</label>
                            <input type="text" class="form-control" value="" />
                        </div>
                        <div class="form-group col  ml-3">
                            <label>Card Number</label>
                            <input type="text" class="form-control" value="" />
                        </div>
                        <div class="form-group col  ml-3">
                            <label>Expiry Month</label>
                            <input type="text" class="form-control w-25" value="" />
                        </div>
                        <div class="form-group col expyst">
                            <label>Expiry Year</label>
                            <input type="text" class="form-control w-25" value="" />
                        </div>
                    </div>
                </div>
                <div class="netbankingdiv">
                    <label>
                        <input type="radio" class="radio" name="optradio" />&nbsp&nbsp   Net Banking
                    </label>
                    <br />
                    <select style="background-color: lavender">
                        <option>Select Bank</option>
                        <option>Canara Bank</option>
                        <option>State Bank Of India</option>
                        <option>HDFC</option>
                        <option>Axis</option>
                        <option>Indian Overseas Bank</option>
                        <option>Kotak Mahindra Bank</option>
                    </select>
                </div>

                <div class="otherupidiv">
                    <label>
                        <input type="radio" class="radio" name="optradio" />&nbsp&nbsp Other Upi and Wallets
                    </label>
                    <div class="form-group col  ml-3">
                        <label>Enter your Upi or Wallet Id</label>
                        <input type="text" class="form-control w-25" value="" />
                    </div>
                </div>

                <div class="otherupidiv">
                    <label>
                        <input type="radio" class="radio" name="optradio" />&nbsp&nbsp Cash On Delivery
                    </label>
                </div>
                <asp:Button CssClass=" btn btn-danger w-25 ml-4 upipaynowbtn" Text="Pay/Order" runat="server" OnClick="Success_Message" />
            </div>
        </div>

    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
    <script>
        $(document).ready(function () {
            var em = localStorage.getItem("totalamount");
            var email = localStorage.getItem("useremail");
            if (em != null) {
                var x = "Total Amount ₹ " + em;
                var y = " (including 50 ₹ delivery charge)";
                document.getElementById('amounth6').innerText = x + y;
                document.getElementById('emailid').setAttribute("value", email)
                document.getElementById('amountp').innerText = x + y;
            }
        });

        function ShowAdd() {
            $('#addbtn').click();
        }
    </script>
</body>
</html>
