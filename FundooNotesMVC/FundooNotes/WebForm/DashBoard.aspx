<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="FundooNotes.WebForm.DashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DashBoard</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" type="text/css" href="CssFile/newnote.css"/>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <script>
        $(document).ready(function () {
            $("#moremenu").click(function () {
                $("#menu").css("display", "content")
            })
        });
        function show(id) {
            document.getElementById(id).style.visibility = "visible";
        }
        
        function hide(id) {
            document.getElementById(id).style.visibility = "hidden";
        }
</script>
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
     <li> <form class="form-inline">
    <input style="margin-top:10px; margin-left:200px" class="form-control  mr-sm-2" type="search" placeholder="Search" aria-label="Search"/>
   &nbsp<button style="margin-top:8px"class="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button>
  </form></li>
    </ul>
     <ul class="nav navbar-nav navbar-right">
        <li><a href="#"><span class="glyphicon glyphicon-th-list"></span></a></li>
        <li><a href="#"><span class="glyphicon glyphicon-user"></span></a></li>
      </ul>
  </div>
</nav>

    <nav style="margin-top:50px" class="navbar navbar-inverse">
  <div class="container-fluid">
    <div class="navbar-header">
      &nbsp&nbsp&nbsp<button style="margin-top:8px" type="button" data-toggle="collapse" data-target="#myNavbar">
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
 <section class="newnotebody"  >
        <div class="note-container" >
            <div class="pin-title">
                <input type="text" class="no-outline"  id="newtitle" placeholder="Title."/> <input type="image" title="Pin Note" class="display" src="Assets/pin.svg" />

            </div>
            <input type="text" class="no-outline"  id="newnote" placeholder="Take a Note..."/>
            <div class="button-icons display">
                <div class="but-icons">
                    <input type="image" class="img-icon" title="Remind me" alt="Reminder" src="Assets/reminder.svg" />
                    <input type="image" class="img-icon" title="Collaborator" alt="Collaborator"src="Assets/colab.svg" />
                    <input type="image" class="img-icon " id="changecolor" title="Change color" alt="Change color" src="Assets/colorpaletteicon.png" onmouseover="show('colorbox')"  />
                    <input type="image" class="img-icon" title="Add image" alt="Add image" src="Assets/uploadicon.png" />
                    <input type="image" class="img-icon" title="Archive" alt="Archive" src="Assets/archiveicon.png" onmouseover="hide('colorbox')"/>
                    <div class="more-menu-container">
                    <input type="image" id="moremenu" class="img-icon icon-size" src="Assets/more.svg" />
                        </div>
                </div>
                <input type="button" title="close" value="close"/>
            </div>
        </div>
            <div id="colorbox" class="color-container display">
             <div>
           <input type="image" class="color-icon icon-size" title="white" alt="white" src="Assets/whitecircle.png" />
           <input type="image" class="color-icon icon-size" title="red" alt="red" src="Assets/redcircle.png" />
           <input type="image" class="color-icon icon-size" title="orange" alt="orange" src="Assets/orange.png" />
           <input type="image" class="color-icon icon-size" title="yellow" alt="yellow" src="Assets/yellowHex-ffd94a.png" />
           <input type="image" class="color-icon icon-size" title="green" alt="green" src="Assets/green.png" />  
           <input type="image" class="color-icon icon-size" title="teal" alt="teal" src="Assets/teal.png" /> 
           <input type="image" class="color-icon icon-size" title="lightblue" alt="lightblue" src="Assets/lightblue.png" />
           <input type="image" class="color-icon icon-size" title="darkblue" alt="darkblue" src="Assets/darkblue.png" />
           <input type="image" class="color-icon icon-size" title="purple" alt="purple" src="Assets/purple.png" />
           <input type="image" class="color-icon icon-size" title="pink" alt="pink" src="Assets/pink.png" />
           <input type="image" class="color-icon icon-size" title="brown" alt="brown" src="Assets/brown.png" />
           <input type="image" class="color-icon icon-size" title="grey" alt="grey" src="Assets/greyHexD3D3D3.png" />
            </div>
         </div> 
    </section>
</body>
</html>
