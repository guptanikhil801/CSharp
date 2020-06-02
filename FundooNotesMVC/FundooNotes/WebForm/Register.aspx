<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FundooNotes.WebForm.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
<title>Register</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style2 {
            margin-left: 5px;
        }
        .auto-style3 {
            height: 33px;
        }
        .auto-style4 {
            height: 50px;
        }
        .auto-style5 {
            height: 18px;
        }
        .auto-style6 {
            height: 50px;
            width: 120px;
        }
        .auto-style7 {
            height: 18px;
            width: 120px;
        }
        .auto-style8 {
            height: 33px;
            width: 120px;
        }
        .auto-style9 {
            width: 120px;
        }
        </style>
</head>
<body>   
      <div class="container p-3 my-3 bg-dark text-white" >
  <h1 style="font-size:45px"> &nbsp&nbsp&nbsp&nbsp Fundoo Notes</h1>
    </div>
        <br />
    <p class="text-success text-center"  style="font-size:60px"> Register</p>
    <br />
    <div class="container ">
        <div class=" d-flex justify-content-center align-items-center  ">
  <form>
    <div class="form-group " >
      <label  for="name">First Name:</label>
      <input type="text" class="form-control" id="fname" name="name"/>
    </div>
    <div class="form-group ">
      <label for="usr">Last Name :</label>
      <input type="text" class="form-control" id="lname" name="lastname"/>
    </div>
        <div class="form-group">
      <label for="usr">Phone Number :</label>
      <input type="text" class="form-control" id="pnumber" name="phonenumber"/>
    </div>
    <div class="form-group">
      <label for="usr">Email :</label>
      <input type="text" class="form-control" id="email" name="email"/>
    </div>
        <div class="form-group ">
      <label for="usr">Password :</label>
      <input type="password" class="form-control" id="password" name="password"/>
    </div>
    <div class="form-group ">
      <label for="usr"> Confirm Password :</label>
      <input type="password" class="form-control" id="cpasword" name="cpassword"/>
    </div>
    <button type="submit" class="btn btn-primary" id="registerbtn">Register</button>
  </form>
            </div>
        <br />
</div>
    <script type="text/javascript">
        $('#registerbtn').click(function () {
            var user = {};
            user.FirstName = $('#fname').val();
            user.LastName = $('#lname').val();
            user.PhoneNumber = parseInt($('#pnumber').val());
            user.Email = $('#email').val();
            user.Password = $('#password').val();
            console.log(JSON.stringify(user))
            $.ajax({
                type: "POST",
                url: "https://localhost:44337/Account/Register",
                data: JSON.stringify(user),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                processData: true,
                success: function (data) {
                    alert("Registration successfull" + data);
                    window.location.href = "https://localhost:44337/WebForm/HomePage.aspx";
                },
                error: function (data) {
                    alert("fill all details correctly");
                }
            });
            return false;
        });
    </script>
</body>
</html>
