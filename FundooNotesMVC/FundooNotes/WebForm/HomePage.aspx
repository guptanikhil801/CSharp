<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="FundooNotes.WebForm.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>HomePage Fundoo Notes</title>
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
        .auto-style12 {
            height: 17px;
            width: 120px;
        }
        .auto-style13 {
            height: 17px;
        }
        .auto-style14 {
            height: 10px;
            width: 120px;
        }
        .auto-style15 {
            height: 10px;
        }
        .auto-style16 {
            width: 121px;
        }
        .brad{
            border-radius:9px;
        }
        </style>
</head>
<body>
    
      <div class="container p-3 my-3 bg-dark text-white brad" >
  <h1 style="text-align:center"> Fundoo Notes</h1>
    </div>
        <br />
         <div class="container">
      <form class="px-4 py-3">
        <div class="form-group w-50">
            <label for="email">&nbsp&nbsp&nbsp Email :</label>
            <input type="email" class="form-control" id="email" placeholder="Enter email"/>
        </div>
        <div class="form-group w-50">
            <label for="pwd">&nbsp&nbsp&nbsp Password :</label>
            <input type="password" class="form-control" id="pwd" placeholder="Enter password"/>
        </div>&nbsp&nbsp&nbsp;
        <button type="submit" class="btn btn-info" id="loginbtn">Login</button>
      </form>
         <br />
         
<p style="font-size:20px" ><a href="https://localhost:44337/WebForm/ForgotPassword.aspx"> Forgot Password</a></p>
<p style="font-size:20px" ><a href="https://localhost:44337/WebForm/Register.aspx">Register</a></p>
    </div>
       <script type="text/javascript">
           $('#loginbtn').click(function () {
               var login = {};
               login.Email = $('#email').val();
               login.Password = $('#pwd').val();
               console.log(JSON.stringify(login))
               $.ajax({
                   type: "POST",
                   url: "https://localhost:44337/Account/Login",
                   data: JSON.stringify(login),
                   contentType: "application/json; charset=utf-8",
                   dataType: "json",
                   processData: true,
                   success: function (data) {
                       alert("login Successfull" + data);
                       localStorage.setItem("UserEmail", login.Email);
                       window.location.href = "https://localhost:44337/Webform/DashBoard.aspx";
                   },
                   error: function () {
                       alert("incorrect email and password combination");
                       
                   }
               });
               return false;
           });
    </script>
</body>
</html>
