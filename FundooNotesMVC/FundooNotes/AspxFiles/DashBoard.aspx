<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="FundooNotes.AspxFiles.DashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DashBoard</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body>
<nav class="navbar navbar-inverse navbar-fixed-top">
  <div class="container-fluid">
    <div class="navbar-header">
      <a class="navbar-brand" href="#">Fundoo Notes</a>
    </div>
    <ul class="nav navbar-nav">
      <li><a href="#">Home</a></li>
     <li> &nbsp&nbsp&nbsp</li>
     <li><a href="#"> <form class="form-inline">
    <input class="form-control  mr-sm-2" type="search" placeholder="Search" aria-label="Search"/>
   &nbsp<button class="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button>
  </form></a></li>
    </ul>
     <ul class="nav navbar-nav navbar-right">
        <li><a href="#"><span class="glyphicon glyphicon-th-list"></span></a></li>
        <li><a href="#"><span class="glyphicon glyphicon-user"></span></a></li>
      </ul>
  </div>
</nav>
    <br />
    <br />
    <br />
    <nav class="navbar navbar-inverse">
  <div class="container-fluid">
    <div class="navbar-header">
      &nbsp&nbsp&nbsp<button type="button" data-toggle="collapse" data-target="#myNavbar">
        <span class="glyphicon glyphicon-align-justify"></span>                  
      </button>   
    </div>
    <div class="collapse" id="myNavbar">
      &nbsp&nbsp<ul class="nav navbar-nav">
        <li><a href="#"><span class="glyphicon glyphicon-envelope"></span>&nbsp&nbsp&nbsp&nbsp Notes</a></li>	
        <li><a href="#"><span class="glyphicon glyphicon-bell"></span> &nbsp&nbsp&nbsp Reminders</a></li>
        <li><a href="#"><span class="glyphicon glyphicon-pencil"></span> &nbsp&nbsp&nbsp Edit Labels</a></li>
        <li><a href="#"><span class="glyphicon glyphicon-text-background"></span> &nbsp&nbsp&nbsp Archive</a></li>
        <li><a href="#"><span class="glyphicon glyphicon-trash"></span> &nbsp&nbsp&nbsp Bin</a></li>
      </ul>
    </div>
  </div>
</nav>

</body>
</html>
