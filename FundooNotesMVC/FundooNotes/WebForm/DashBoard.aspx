<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="FundooNotes.WebForm.DashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DashBoard</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" type="text/css" href="CssFile/newnote.css"/>
    <link rel="stylesheet" type="text/css" href="CssFile/sidebar.css"/>
    <link rel="stylesheet" type="text/css" href="CssFile/NotesStyleSheet.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
    <script src="ScriptFiles/Notescript.js"></script>
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
    min-width: 240px;
    margin-right: 15px;
    margin-top: 25px;
    min-height: 122px;
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

.listviewcl {
    width: 590px;
    margin-left: 100px;
}
        .mmhidden{
            visibility:hidden;
            width:120px; 
            height:70px; 
            position:absolute; 
            margin-top:120px; 
            margin-left:220px;
            z-index:1
        }
        .mmshow{
            visibility:visible;
        }
        .mmbody{
            display:flex; 
            padding: 7px 3px 7px 3px; 
            flex-direction:column;
            font-size:15px;
        }
.mmbutton{
    border: none;
    background-color: transparent
}
.badgetran{
    background-color:transparent;
    border: solid  1.5px;
    border-color:#404040;
    margin-right:3px;
    

}

    </style>

    <script type="text/javascript">
        function ce() {
            var semail = localStorage.getItem("UserEmail");
            $("#owneremail").text("owner : " + semail);
        }

        function updatenotefeed(noteid, title, description, color) {
            document.getElementById('updatenotebox').style.backgroundColor = color;
            document.getElementById('updatetitle').style.backgroundColor = color;
            document.getElementById('updatedescription').style.backgroundColor = color;
            $("#updatetitle").val(title);
            $("#updatedescription").val(description);
            document.getElementById('updatenoteclose').setAttribute("value", noteid);
        }

        function mmtoggle(id) {
            $("#" + id).toggleClass("mmshow");
        }

        function hello() {
            alert("hello")
        }
        function ppicfun() {
            var email = localStorage.getItem("UserEmail");
            document.getElementById('ppemail').setAttribute("value", email);
        }
    </script>
</head>
<body>

<nav class="navbar navbar-dark bg-dark">
    <div class="navbar-header">
<button class="openbtn" id="openside" onclick="togglebar()" >☰</button> 
      <button class="navbar-brand" style="font-size:32px; background-color:transparent; border:none">
        &nbsp&nbsp&nbsp  Fundoo Notes</button>
    </div>       
    <input style=" margin-top:8px; width:40%; margin-left:30px; margin-right:30px" class="form-control mr-sm3" id="searchbar" type="text" placeholder="Search"/>
    <button style="margin-right:30px"  onclick="listview()"><img  src="Assets/listviewicon.png" /></button>
    <a style="margin-right:30px"  data-toggle="collapse" href="#setting-menu" role="button" ><img  src="Assets/settingicon.png" /></a>
    <a style="margin-right:30px " href="#"><img  src="Assets/googleappicon.png" /></a>
    <a style="margin-right:30px" onclick="usermenuemail()" data-toggle="collapse" href="#user-menuid" role="button" ><img id="userpic" src="" class="rounded-circle" alt="" width="47" height="47" /></a>
</nav>

<div id="sidepanel">
   <ul>
 <li> <img style="margin-top:-10px; margin-left:-20px" src="Assets/notesicon.jpg" height="35" width="34" /><button type="button" onclick="Refresh()"  style="margin-left:25px" >Notes</button></li> 
 <li> <img style="margin-top:-10px; margin-left:-17px" src="Assets/belliconsb.jpg" height="35" width="34" /><button type="button" style="margin-left:25px" >Reminder</button></li>
 <li> <img style="margin-top:-10px; margin-left:-17px" src="Assets/labelicon.png" height="31" width="31" /><button type="button" style="margin-left:25px" >Label</button></li>
 <li> <img style="margin-top:-10px; margin-left:-17px" src="Assets/archiveiconsb.png" height="31" width="31" /><button type="button" id="showarchivednotes" style="margin-left:25px" >Archive</button></li>
 <li> <img style="margin-top:-10px; margin-left:-17px" src="Assets/biniconsb.jpg" height="31" width="31" /><button type="button" id="showtrashednotes" style="margin-left:25px" >Bin</button></li>
  </ul>
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
            <img style="margin-left:120px" src="" id="userpicbody" class="rounded-circle" alt="" width="80" height="80"/>
            
           <input type="image" style="margin-left: 160px; margin-top: -12px" title="upload a pic" onclick="ppicfun()" src="Assets/cameracircle.png" alt="" width="32" height="32" data-toggle="modal" data-target="#profilepicModal" /> 
            <h5 id="show-email" style="margin-top:40px; margin-left:15px" class="card-title"></h5>          
        </div>
        <div class="card-footer ">
            <button id="sign-out-btn" style="margin-top:5px; margin-left:105px" type="button" class="btn btn-outline-secondary" onclick="signoutfun()">Sign-Out</button>
        </div>
    </div>

 <section  class="newnotebody"  >
        <div class="note-container" id="newnotebody" >
            <div class="pin-title">
                <input type="text" class="no-outline fontbold"  id="newtitle" placeholder="Title."/> <input type="image" title="Pin Note" id="newpinnote" class="display" src="Assets/pin.svg" />
            </div>
            <input type="text" class="no-outline"  id="newdescription" placeholder="Take a Note..."/>
            <div class="button-icons display">
                <div class="but-icons">
                    <input type="image" class="img-icon"  id="newremind" data-toggle='modal' data-target='#newnotereminder' title="Remind me" alt="Reminder" src="Assets/reminder.svg" />
                    <input type="image" class="img-icon"  id="newcollab" title="Collaborator" alt="Collaborator"src="Assets/colab.svg" />
                    <input type="image" class="img-icon" id="newchangecolor" title="Change color" alt="Change color" src="Assets/colorpaletteicon.png" onmouseover="show('colorbox')"  />
                    <input type="image" class="img-icon" id="newimage" title="Add image" alt="Add image" src="Assets/uploadicon.png" />
                    <input type="image" class="img-icon" id="newarchive" title="Archive" alt="Archive" src="Assets/archiveicon.png" onmouseover="hide('colorbox')"/>
                    <div class="more-menu-container">
                    <input type="image" id="moremenu" class="img-icon icon-size" src="Assets/more.svg" />
                        </div>
                </div>
                <input type="button" title="close" value="close"  id="closenotebtn" />
            </div>
        </div>
            <div id="colorbox" class="color-container display">
             <div>
           <input type="hidden" id="colorhid" value="white"/>
           <input type="image" class="color-icon icon-size" onclick="colorinp('colorhid', 'white') "  title="white" alt="white" src="Assets/whitecircle.png" />
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
                        <h5 class='card-title'> manually created </h5 >
                        <p class="card-text"> note</p>
                        <span class="badge badge-pill badge-secondary badgetran">remindercheck</span>
                        <span class="badge badge-pill badge-secondary" ></span>
                      <div class="anicon display">
                            <input type="image"  id="all-note-remind"  title="Remind me" height="18" width="18" alt="Reminder" src="Assets/reminder.svg" />                            
                            <input type="image"  id="all-note-collab"  data-toggle="modal" data-target="#AddCollabModal" title="Collaborator" height="18" width="18" alt="Collaborator" src="Assets/colab.svg" />
                            <input type="image"  id="all-note-changecolor" title="Change color" height="14" width="14" alt="Change color" src="Assets/colorpaletteicon.png" />
                            <input type="image"  id="all-note-image" title="Add image" height="16" width="16" alt="Add image" src="Assets/uploadicon.png" />
                            <input type="image"  id="all-note-archive" title="Archive" height="13" width="13" alt="Archive" src="Assets/archiveicon.png"  />
                            <input type="image"  id="all-note-more"  title="More" height="18" width="18" alt="More" src="Assets/more.svg" />                       
                       </div>
                    </div>                     
                </div> 
            </div>          
        </div>
    </section>

     <section id="archivednotesection">
        <div class="container">
                         <h1 style="margin-left:40%" id="anheading" class='card-title'> </h1>
            <div style="margin-left:220px; margin-top:60px; margin-bottom:60px" id="archivednotesrow" class="row">
            </div>
        </div>
     </section>

        <section id="trashednotesection">
        <div class="container">
              <h1 style="margin-left:40%" id="tnheading" class='card-title'> </h1>
            <div style="margin-left:220px; margin-top:60px; margin-bottom:60px" id="trashednotesrow" class="row">
            </div>
        </div>
        </section>
    
        <div class="modal fade" id="AddCollabModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">              
                <div style="display:flex; flex-direction:column;" class="modal-header">                 
                    <h5 style="margin-bottom:8px" class="modal-title" id="exampleModalLongTitle">Collaborator</h5>
                    <p id="owneremail"></p>
                    <input style=" margin-top:10px; width:80%; border:none;  outline:none" id="collabinpbtn" type="text"  placeholder="Person or email to share with" />
                </div>
                <div class="modal-footer">
                    <button  type="button"  class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <button type="button" id="collab-save-btn" class="btn btn-primary" >save</button>
                </div>
            </div>
        </div>
    </div>

      <div class="modal fade" id="newnotereminder" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">              
                <div style="display:flex; flex-direction:column;" class="modal-header">                 
                    <h5 style="margin-bottom:8px" class="modal-title" id="exampleModalLongTitler">Reminder</h5>
                     <p style=" margin-top:6px; width:80%" >Take a Reminder</p>
                      <input type="datetime-local" id="remindertime" name="choosetime"/>
                </div>
                <div class="modal-footer">
                    <button type="button"  class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <button type="button" id="newreminder-save-btn" data-dismiss="modal" class="btn btn-primary" >save</button>
                </div>
            </div>
        </div>
    </div>

     <div  class="modal fade" id="updatenotemodal" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
        <div  class="modal-dialog modal-dialog-centered" role="document">
            <div style="width:540px; height:180px; background-color:white" id="updatenotebox" class="modal-content">              
                <div style="display:flex; flex-direction:column;" class="modal-header">                 
                    <input type="text" style=" margin-top:10px; width:80%; border:none; background-color:white; outline:none" placeholder="new title" id="updatetitle" />
                    <input type="text" style=" margin-top:10px; width:80%; border:none; background-color:white; outline:none" placeholder="new description" id="updatedescription" />
                </div>
                    <button type="button" id="updatenoteclose" style="border:none; background:none;  margin-left:80%; margin-top:25px;"  data-dismiss="modal" value="">Close</button>
                </div>
        </div>
    </div>

     <div  class="modal fade" id="addlabelmodal" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
        <div  class="modal-dialog modal-dialog-centered" role="document">
            <div style="width:340px; height:150px; background-color:white" id="addlabelbox" class="modal-content">              
                <div style="display:flex; flex-direction:column;" class="modal-header">                 
                    <input type="text" style=" margin-top:10px; width:80%; border:none; background-color:white; outline:none" placeholder="label details" id="labeldetails" />
                </div>
                    <button type="button" id="addlabelclose" style="border:none; background:none;  margin-left:80%; margin-top:10px;"  data-dismiss="modal" value="">Close</button>
                </div>
        </div>
    </div>

        <div class="modal fade" id="profilepicModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Upload a Profile Picture</h5>
                </div>
                <div class="modal-body">
                    <form id="profilepicdata" method="put">
                        <input type="hidden" id="ppemail" name="Email" value="" />
                        <label for="File">Choose a Picture :</label>
                        <input name="File" type="file" />
                        <button class="btn btn-primary">Upload</button>
                    </form>
                </div>
            </div>
        </div>
    </div>

            <script type="text/javascript">
                $('#collab-save-btn').click(function () {
                    var collab = {};
                    collab.UserEmail = localStorage.getItem("UserEmail");
                    collab.CollabratorEmail = $('#collabinpbtn').val();
                    collab.NoteId = parseInt($('#collab-save-btn').val());
                    console.log(JSON.stringify(collab))
                    $.ajax({
                        type: "POST",
                        url: "https://localhost:44337/Collabrator/AddCollabrator",
                        data: JSON.stringify(collab),
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        processData: true,
                        success: function (data) {
                            location.reload();
                            alert("collabrator added successfully" + data);
                        },
                        error: function (data) {
                            alert("collabrator email should not be null");
                        }
                    });
                    return false;
                });
            </script>

<script type="text/javascript">
    $('#closenotebtn').click(function () {
        var note = {};
        note.Email = localStorage.getItem("UserEmail");
        note.Title = $('#newtitle').val();
        note.Description = $('#newdescription').val();
        note.color = $('#colorhid').val();
        note.Reminder = $('#remindertime').val()
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

    <script type="text/javascript" >
        function ArchiveUnArchive(noteid) {
            var x = parseInt(noteid);
            console.log(JSON.stringify(x))
            $.ajax({
                type: "PUT",
                url: "https://localhost:44337/Notes/Archive/" + x,
                dataType: "json",
                success: function (data) {
                    location.reload();
                },
                error: function () {
                    alert("error");
                }
            });
            return false;
        }
    </script>

    <script type="text/javascript" >
        function TrashAndRestore(noteid) {
            var x = parseInt(noteid);
            console.log(JSON.stringify(x))
            $.ajax({
                type: "PUT",
                url: "https://localhost:44337/Notes/TrashAndRestore/" + x,
                dataType: "json",
                success: function (data) {
                    alert(" note trashed/untrashed" + data);
                },
                error: function () {
                    alert("error");
                }
            });
            return false;
        }
    </script>

    <script type="text/javascript" >
        function DeleteForever(noteid) {
            var x = parseInt(noteid);
            console.log(JSON.stringify(x))
            $.ajax({
                type: "DELETE",
                url: "https://localhost:44337/Notes/DeleteForever/" + x,
                dataType: "json",
                success: function (data) {
                    location.reload();
                    alert(" note deleted parmanently" + data);
                },
                error: function () {
                    alert("error");
                }
            });
            return false;
        }
    </script>

    <script>
        $('#updatenoteclose').click(function () {
            var x = parseInt($('#updatenoteclose').val());
            var unote = {};
            unote.noteid = x;
            unote.title = $('#updatetitle').val();
            unote.description = $('#updatedescription').val();
            console.log(JSON.stringify(unote))
            $.ajax({
                type: "PUT",
                url: "https://localhost:44337/Notes/UpdateNote",
                data: JSON.stringify(unote),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                processData: true,
                success: function () {
                    alert("note updated");
                    window.location.reload();
                },
                error: function () {
                    alert("some error occured");
                }
            });
            return false;
        });
    </script>

    <script>
        $('#showarchivednotes').click(function () {
            $("#allnotesrow").hide();
            $('#archivednotesrow').show();
            $('#newnotebody').hide();
            $('#trashednotesrow').hide();
            var x = localStorage.getItem("UserEmail");
            $.ajax({
                type: "GET",
                url: "https://localhost:44337/Notes/GetAllArchivedNotes" ,
                data: { id: localStorage.getItem("UserEmail") },
                contentType: "application/json; charset=utf-8",
                dataType: "json",
            }).then(res => {
                console.log(res);
                res.allarchivednotes.forEach(el => {
                    var title = el.Title
                    var description = el.Description;
                    var color = el.Colour;
                    var NoteId = el.NoteId;
                    $("<div style='background-color: " + color + "' class= 'card carddesign'>" +
                        "<div class= 'card-body'>" +
                        "<h5 class='card-title' data-toggle='modal' data-target='#updatenotemodal' onclick='updateidfeed(" + NoteId + ")' > " + title + "</h5 > " +
                        "<p class='card-text' data-toggle='modal' data-target='#updatenotemodal'onclick='updateidfeed(" + NoteId + ")' >" + description + "</p>" +
                        "<div class='anicon display'>" +
                        "<input style='background-color: " + color + "' type='image'  title='Remind me' height='18' width='18' alt='Reminder' src='Assets/reminder.svg' />" +
                        "<input style='background-color: " + color + "' type='image' onclick='collabnoteidfeed(" + NoteId + ")'  data-toggle='modal' data-target='#AddCollabModal' title='Collaborator' height='18' width='18' alt='Collaborator' src='Assets/colab.svg' />" +
                        "<input style='background-color: " + color + "' type='image'  title='Change color' height='14' width='14' alt='Change color' src='Assets/colorpaletteicon.png' />" +
                        "<input style='background-color: " + color + "' type='image'  title='Add image' height='16' width='16' alt='Add image' src='Assets/uploadicon.png' />" +
                        "<input style='background-color: " + color + "' type='image' onclick='ArchiveUnArchive(" + NoteId + ")' title='UnArchive' height='13' width='13' alt='Archive' src='Assets/archiveicon.png' />" +
                        "<input style='background-color: " + color + "' type='image' onclick='mmtoggle(" + NoteId +")'  title='More' height='18' width='18' alt='More' src='Assets/more.svg' />" +
                        "</div>" +
                        "</div>" +

                        "<div id = '" + NoteId + "' class= 'card mmhidden'>" +
                        "<div class='card-body mmbody'>" +
                        "<button class='mmbutton' onclick='TrashAndRestore(" + NoteId + ")' >" + "Delete Note" + "</button>" +
                        "<button class='mmbutton'>" + "Add Label " + "</button>" +
                        "</div>" +
                        "</div >"
                    ).appendTo($('#archivednotesrow'));
                })
            })
        });

    </script>

    <script>
        $('#showtrashednotes').click(function () {
            $("#allnotesrow").hide();
            $('#archivednotesrow').hide();
            $('#trashednotesrow').show();
            $('#newnotebody').hide();
            var x = localStorage.getItem("UserEmail");
            $.ajax({
                type: "GET",
                url: "https://localhost:44337/Notes/GetAllTrashedNotes",
                data: { id: localStorage.getItem("UserEmail") },
                contentType: "application/json; charset=utf-8",
                dataType: "json",
            }).then(res => {
                console.log(res);
                res.alltrashednotes.forEach(el => {
                    var title = el.Title
                    var description = el.Description;
                    var color = el.Colour;
                    var NoteId = el.NoteId;
                    $("<div style='background-color: " + color + "' class= 'card carddesign'>" +
                        "<div class= 'card-body'>" +
                        "<h5 class='card-title' > " + title + "</h5 > " +
                        "<p class='card-text' >" + description + "</p>" +
                        "<div class='anicon display'>" +
                        "<input onclick='DeleteForever(" + NoteId + ")' style='background-color: " + color + "' type='image'  title='Delete Forever' height='20' width='20' alt='Delete Forever' src='Assets/deleteforever.png' />" +
                        "<input onclick='TrashAndRestore(" + NoteId + ")' style='background-color: " + color + "' type='image'  title='Restore' height='20' width='20' alt='Restore' src='Assets/restore.png' />" +
                        "</div>" +
                        "</div>"                       
                    ).appendTo($('#trashednotesrow'));
                })
            })
        });

    </script>

     <script type="text/javascript">
         $('#addlabelclose').click(function () {
             var nlabel = {};
             nlabel.Details = $('#labeldetails').val();
             nlabel.NoteId = parseInt($('#addlabelclose').val());
             console.log(JSON.stringify(nlabel))
             $.ajax({
                 type: "POST",
                 url: "https://localhost:44337/Label/AddLabel",
                 data: JSON.stringify(nlabel),
                 contentType: "application/json; charset=utf-8",
                 dataType: "json",
                 processData: true,
                 success: function (data) {
                     location.reload();
                     alert("Label added successfully" + data);
                 },
                 error: function (data) {
                     alert("details should not be null");
                 }
             });
             return false;
         });
     </script>

    <script>
        $("form#profilepicdata").submit(function (e) {
            e.preventDefault();
            var formData = new FormData(this);
            $.ajax({
                url: "https://localhost:44337/Notes/ProfilePicture",
                type: 'PUT',
                data: formData,
                success: function (data) {
                    window.location.reload();
                },
                cache: false,
                contentType: false,
                processData: false
            });
        });
    </script>

</body>
</html>
