<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="FundooNotes.WebForm.DashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DashBoard</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" type="text/css" href="CssFile/newnote.css"/>
    <link rel="stylesheet" type="text/css" href="CssFile/DashBoardStyle.css"/>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
      <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
    <style>
        
.setting-collapse {
    margin-left: 940px;
    margin-top: -10px;
}

    .setting-collapse a {
        color: #383838;
    }

.user-menu-design {
    width: 340px;
    height: 310px;
    margin-left:900px;
}

    .user-menu-design div h5 {
        margin-top: 34px;
        color: #595959
    }
    </style>
    <style>

        .card:hover .display {
    visibility: visible;
}
.icon-button-div {
    margin-top: 0;
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    width: 50%;
}
.carddesign {
    width: 240px;
    margin-right: 15px;
    margin-top: 25px;
    height: 122px;
    border-radius: 10px;
}

.card:hover .display {
    visibility: visible;
}

.anicon {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
}
    </style>
    <script>

        function show(id) {
            document.getElementById(id).style.visibility = "visible";
        }
        
        function hide(id) {
            document.getElementById(id).style.visibility = "hidden";
        }
        function colorinp(id,color) {
            document.getElementById(id).setAttribute("value", color);
            document.getElementById('newnotebody').style.backgroundColor = color;
            document.getElementById('newtitle').style.backgroundColor = color;
            document.getElementById('newdescription').style.backgroundColor = color;
            document.getElementById('newremind').style.backgroundColor = color;
            document.getElementById('changecolor').style.backgroundColor = color;
            document.getElementById('newimage').style.backgroundColor = color;
            document.getElementById('newarchive').style.backgroundColor = color;
            document.getElementById('newcollab').style.backgroundColor = color;
            document.getElementById('moremenu').style.backgroundColor = color;
            document.getElementById('closenotebtn').style.backgroundColor = color;
            document.getElementById('newpinnote').style.backgroundColor = color;
        }
        function openNav() {
            document.getElementById("mySidepanel").style.width = "250px";
        }

        function usermenuemail() {
            var semail = localStorage.getItem("UserEmail");
            $("#show-email").text(semail);
        }

        function closeNav() {
            document.getElementById("mySidepanel").style.width = "0";
        }
        function signoutfun() {
            localStorage.removeItem("UserEmail");
            window.location.href = "https://localhost:44337/Webform/Homepage.aspx";
        }
</script>

</head>
<body>
<nav class="navbar navbar-dark bg-dark">
    <div class="navbar-header">
<button class="openbtn" id="openside" onclick="openNav()" >☰</button> 
      <a class="navbar-brand" style="font-size:32px"href="#">
        &nbsp&nbsp&nbsp  Fundoo Notes</a>
    </div>       
    <input style=" margin-top:8px; width:500px; margin-left:30px; margin-right:30px" class="form-control mr-sm3" id="searchbar" type="text" placeholder="Search"/>
    <a style="margin-right:30px" href="#"><img  src="Assets/listviewicon.png" /></a>
    <a style="margin-right:30px"  data-toggle="collapse" href="#setting-menu" role="button" ><img  src="Assets/settingicon.png" /></a>
    <a style="margin-right:30px " href="#"><img  src="Assets/googleappicon.png" /></a>
     <a style="margin-right:30px" onclick="usermenuemail()" data-toggle="collapse" href="#user-menuid" role="button" ><img src="Assets/userimg.JPG" class="rounded-circle" alt="" width="47" height="47" /></a>


</nav>

  <div>
<div id="mySidepanel" class="sidepanel">
    <input type="hidden" id="testid" value="close"/>
  <a href="javascript:void(0)" class="closebtn" onclick="closeNav()" >×</a>
  <a href="#"><span class="glyphicon glyphicon-envelope">&nbsp</span>Notes</a>
  <a href="#"><span class="glyphicon glyphicon-bell">&nbsp </span>Reminders</a>
  <a href="#"><span class="glyphicon glyphicon-pencil">&nbsp </span>Edit Labels</a>
  <a href="#"><img  src="Assets/archiveicon.png" width="22" height="22" />&nbsp&nbsp&nbsp Archives</a>
  <a href="#"><span class="glyphicon glyphicon-trash">&nbsp</span>Bin</a>
</div>
  </div>

                <div class="collapse setting-collapse" id="setting-menu">
                <div style="width:180px;" class="card ">
                    <div style="display:flex; flex-direction:column; font-size:15px;" class="card-body">
                        <a  href="#">Settings</a>
                        <a  href="#">Enable Light Theme</a>
                        <a  href="#">Send Feedback</a>
                        <a  href="#">Help</a>
                        <a  href="#">App Downloads</a>
                        <a  href="#">Keyboard Shortcuts</a>
                    </div>
                </div>
            </div>

        <div id="user-menuid" class="collapse card user-menu-design ">
        <div class="card-body ">
            <img style="margin-left:120px" src="Assets/userimg.JPG" class="rounded-circle" alt="" width="80" height="80"/>
            <h5 id="show-email" style="margin-top:40px; margin-left:15px" class="card-title"></h5>          
        </div>
        <div class="card-footer ">
            <button id="sign-out-btn" style="margin-top:5px; margin-left:105px" type="button" class="btn btn-outline-secondary" onclick="signoutfun()">Sign-Out</button>
        </div>
    </div>

 <section class="newnotebody"  >
        <div class="note-container" id="newnotebody" >
            <div class="pin-title">
                <input type="text" class="no-outline fontbold"  id="newtitle" placeholder="Title."/> <input type="image" title="Pin Note" id="newpinnote" class="display" src="Assets/pin.svg" />

            </div>
            <input type="text" class="no-outline"  id="newdescription" placeholder="Take a Note..."/>
            <div class="button-icons display">
                <div class="but-icons">
                    <input type="image" class="img-icon" id="newremind" title="Remind me" alt="Reminder" src="Assets/reminder.svg" />
                    <input type="image" class="img-icon" id="newcollab" title="Collaborator" alt="Collaborator"src="Assets/colab.svg" />
                    <input type="image" class="img-icon" id="newchangecolor" title="Change color" alt="Change color" src="Assets/colorpaletteicon.png" onmouseover="show('colorbox')"  />
                    <input type="image" class="img-icon" id="newimage" title="Add image" alt="Add image" src="Assets/uploadicon.png" />
                    <input type="image" class="img-icon" id="newarchive" title="Archive" alt="Archive" src="Assets/archiveicon.png" onmouseover="hide('colorbox')"/>
                    <div class="more-menu-container">
                    <input type="image" id="moremenu" class="img-icon icon-size" src="Assets/more.svg" />
                        </div>
                </div>
                <input type="button" title="close" value="close" id="closenotebtn"/>
            </div>
        </div>
            <div id="colorbox" class="color-container display">
             <div>
           <input type="hidden" id="colorhid" value="white"/>
           <input type="image" class="color-icon icon-size" onclick="colorinp('colorhid', 'white') " title="white" alt="white" src="Assets/whitecircle.png" />
           <input type="image" class="color-icon icon-size" onclick="colorinp('colorhid','#f88379') " title="red" alt="red" src="Assets/redcircle.png" />
           <input type="image" class="color-icon icon-size" onclick="colorinp('colorhid', '#ffa500')" title="orange" alt="orange" src="Assets/orange.png" />
           <input type="image" class="color-icon icon-size" onclick="colorinp('colorhid', '#FEDC56')" value="yellow" id="yellow" title="yellow" alt="yellow" src="Assets/yellowHex-ffd94a.png" />
           <input type="image" class="color-icon icon-size" onclick="colorinp('colorhid', '#90ee90')" title="green" alt="green" src="Assets/green.png" />  
           <input type="image" class="color-icon icon-size" onclick="colorinp('colorhid', '#73ffff')" title="teal" alt="teal" src="Assets/teal.png" /> 
           <input type="image" class="color-icon icon-size" onclick="colorinp('colorhid', '#87d4d4')" title="lightblue" alt="lightblue" src="Assets/lightblue.png" />
           <input type="image" class="color-icon icon-size" onclick="colorinp('colorhid', '#7f7fff')" title="darkblue" alt="darkblue" src="Assets/darkblue.png" />
           <input type="image" class="color-icon icon-size" onclick="colorinp('colorhid', '#CC99CC')" title="purple" alt="purple" src="Assets/purple.png" />
           <input type="image" class="color-icon icon-size" onclick="colorinp('colorhid', '#ffb6e6')" title="pink" alt="pink" src="Assets/pink.png" />
           <input type="image" class="color-icon icon-size" onclick="colorinp('colorhid', '#d3a27f')" title="brown" alt="brown" src="Assets/brown.png" />
           <input type="image" class="color-icon icon-size" onclick="colorinp('colorhid', '#E8E8E8')" title="grey" alt="grey" src="Assets/greyHexD3D3D3.png" />
                 </div>
         </div> 
    </section>
        <section id="allnotesection">
        <div class="container">
            <div style="margin-left:220px; margin-top:60px; margin-bottom:60px" id="allnotesrow" class="row">
                <div style="background-color:antiquewhite" class="card carddesign">
                    <div class="card-body">
                        <h5 class="card-title">hello</h5>
                        <p class="card-text">new description</p>
                       <div class="anicon display">
                            <input type="image"  id="all-note-remind" title="Remind me" height="18" width="18" alt="Reminder" src="Assets/reminder.svg" />                            
                            <input type="image"  id="all-note-collab" title="Collaborator" height="18" width="18" alt="Collaborator" src="Assets/colab.svg" />
                            <input type="image"  id="all-note-changecolor" title="Change color" height="14" width="14" alt="Change color" src="Assets/colorpaletteicon.png" />
                            <input type="image"  id="all-note-image" title="Add image" height="16" width="16" alt="Add image" src="Assets/uploadicon.png" />
                            <input type="image"  id="all-note-archive" title="Archive" height="13" width="13" alt="Archive" src="Assets/archiveicon.png"  />
                            <input type="image"  id="all-note-more" title="More" height="18" width="18" alt="More" src="Assets/more.svg" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
        <script type="text/javascript">
            $(document).ready(function () {
                $.ajax({
                    type: "GET",
                    url: "https://localhost:44337/Notes/GetAllNotes",
                    data: { id: localStorage.getItem("UserEmail") },
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                }).then(res => {
                    console.log(res);
                    res.allnotes.forEach(el => {
                        var title = el.Title
                        var description = el.Description;
                        var color = el.Colour;
                        $("<div style='background-color: "+color+"' class= 'card carddesign'>" +
                            "<div class= 'card-body'>" +
                            "<h5 class='card-title'>" + title + "</h5 >" +
                            "<p class='card-text'>" + description + "</p>" +
                            "<div class='anicon display'>"+
                            "<input style='background-color: " + color +"' type='image' id='all-note-remind' title='Remind me' height='18' width='18' alt='Reminder' src='Assets/reminder.svg' />"+
                            "<input style='background-color: " + color +"' type='image' id='all-note-collab' title='Collaborator' height='18' width='18' alt='Collaborator' src='Assets/colab.svg' />" +
                            "<input style='background-color: " + color +"' type='image' id='all-note-changecolor' title='Change color' height='14' width='14' alt='Change color' src='Assets/colorpaletteicon.png' />"+
                            "<input style='background-color: " + color +"' type='image' id='all-note-image' title='Add image' height='16' width='16' alt='Add image' src='Assets/uploadicon.png' />"+
                            "<input style='background-color: " + color +"' type='image' id='all-note-archive' title='Archive' height='13' width='13' alt='Archive' src='Assets/archiveicon.png' />"+
                            "<input style='background-color: " + color +"' type='image' id='all-note-more' title='More' height='18' width='18' alt='More' src='Assets/more.svg' />"+
                            "</div>"+
                            "</div>"
                        ).appendTo($('#allnotesrow'));                     
                    })
                })
            });
    </script>
            <script type="text/javascript">
                $('#closenotebtn').click(function () {
                    var note = {};
                    note.Email = localStorage.getItem("UserEmail");
                    note.Title = $('#newtitle').val();
                    note.Description = $('#newdescription').val();
                    note.color = $('#colorhid').val();
                    console.log(JSON.stringify(note))
                    $.ajax({
                        type: "POST",
                        url: "https://localhost:44337/Notes/AddNote",
                        data: JSON.stringify(note),
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        processData: true,
                        success: function (data) {
                            location.reload();
                            alert("note created" + data);                          
                        },
                        error: function (data) {
                            alert("Title and description should not be empty");
                        }
                    });
                    return false;
                });
    </script>
</body>
</html>
