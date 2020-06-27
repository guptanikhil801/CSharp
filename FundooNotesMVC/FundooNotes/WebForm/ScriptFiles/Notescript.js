var tempNoteId;
$(document).ready(function () {
    $('#archivednotesrow').hide();
    $('#trashednotesrow').hide();
    $('#allnotesrow').show();
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
            var NoteId = el.NoteId;
            var reminder = el.Reminder;
            var image = el.Image;
            var lnoteid = "l" + NoteId;
            tempNoteId = NoteId;
            var timg = image;
            $("#searchbar").change(function () {
                $("#allnotesrow").hide();
                $('#allPinnednotesrow').hide();
                $('#Pinnedh4').hide();
                $('#Othersh4').hide();
                $('#searchedh4').text("search result");
                var v = $("#searchbar").val();
                var t = title.search(v);
                var d = description.search(v);
                if (t >= 0 || d >= 0) {
                    $("<div style='background-color: " + color + "' class= 'card carddesign'>" +
                        "<input type='image' style='background-color:transparent; position:absolute; margin-left:80%; margin-top:5px' onclick='PinUnPinfun(" + NoteId + ")' title='Pin Note' class='display' src='Assets/pin.svg' />" +
                        " <img src='" + image + "' class='card-img-top noteimgsize' alt=''>" +
                        "<div class= 'card-body'>" +

                        "<h5 class='card-title' data-toggle='modal' data-target='#updatenotemodal' onclick='updateidfeed(" + NoteId + ")' > " + title + "</h5 > " +
                        "<p class='card-text' data-toggle='modal' data-target='#updatenotemodal'onclick='updateidfeed(" + NoteId + ")' >" + description + "</p>" +
                        "<span  class='badge badge-pill badge-light badgetran'>" + reminder + "</span>" +
                        "<span id = '" + lnoteid + "'  class='badge badge-pill badge-light badgetran'>" + "</span>" +
                        "<div class='anicon display'>" +
                        "<input style='background-color: " + color + "' type='image'  title='Remind me' height='18' width='18' alt='Reminder' src='Assets/reminder.svg' />" +
                        "<input style='background-color: " + color + "' type='image' onclick='collabnoteidfeed(" + NoteId + ")'  data-toggle='modal' data-target='#AddCollabModal' title='Collaborator' height='18' width='18' alt='Collaborator' src='Assets/colab.svg' />" +
                        "<input style='background-color: " + color + "' type='image'  title='Change color' height='14' width='14' alt='Change color' src='Assets/colorpaletteicon.png' />" +
                        "<input style='background-color: " + color + "' type='image'  onclick='NoteImageFun(" + NoteId + ")' title='Add image' height='16' width='16' alt='Add image' src='Assets/uploadicon.png' data-toggle='modal' data-target='#NoteImageModal' />" +
                        "<input style='background-color: " + color + "' type='image' onclick='ArchiveUnArchive(" + NoteId + ")' title='Archive' height='13' width='13' alt='Archive' src='Assets/archiveicon.png' />" +
                        "<input style='background-color: " + color + "' type='image' onclick='mmtoggle(" + NoteId + ")' title='More' height='18' width='18' alt='More' src='Assets/more.svg' />" +
                        "</div>" +
                        "</div>" +
                        "<div id = '" + NoteId + "' class= 'card mmhidden'>" +
                        "<div class='card-body mmbody'>" +
                        "<button class='mmbutton' onclick='TrashAndRestore(" + NoteId + ")' >" + "Delete Note" + "</button>" +
                        "<button  onclick='addlabelfeed(" + NoteId + ")' data-toggle='modal' data-target='#addlabelmodal' class='mmbutton' > " + "Add Label " + "</button > " +
                        "</div>" +
                        "</div >", showlabel(NoteId)
                    ).appendTo($('#searchednotesrow'));

                }

            })

            $("<div style='background-color: " + color + "' class= 'card carddesign'>" +
                "<input type='image' style='background-color:transparent; margin-left:80%; position:absolute; margin-top:5px' onclick='PinUnPinfun(" + NoteId + ")' title='Pin Note' class='display' src='Assets/pin.svg' />" +
                " <img src='" + image + "' class='card-img-top noteimgsize' alt=''>" +
                "<div class= 'card-body'>" +

                "<h5 class='card-title' data-toggle='modal' data-target='#updatenotemodal' onclick='updateidfeed(" + NoteId + ",\"" + image + "\")'> " + title + "</h5 > " +
                "<p class='card-text' data-toggle='modal' data-target='#updatenotemodal' onclick='updateidfeed(" + NoteId + ",\"" + image + "\")' >" + description + "</p>" +
                "<span  class='badge badge-pill badge-light badgetran'>" + reminder + "</span>" +
                "<span id = '" + lnoteid + "'  class='badge badge-pill badge-light badgetran'>" + "</span>" +
                "<div class='anicon display'>" +
                "<input style='background-color: " + color + "' type='image'  title='Remind me' height='18' width='18' alt='Reminder' src='Assets/reminder.svg' />" +
                "<input style='background-color: " + color + "' type='image' onclick='collabnoteidfeed(" + NoteId + ")'  data-toggle='modal' data-target='#AddCollabModal' title='Collaborator' height='18' width='18' alt='Collaborator' src='Assets/colab.svg' />" +
                "<input style='background-color: " + color + "' type='image'  title='Change color' height='14' width='14' alt='Change color' src='Assets/colorpaletteicon.png' />" +
                "<input style='background-color: " + color + "' type='image'  onclick='NoteImageFun(" + NoteId + ")' title='Add image' height='16' width='16' alt='Add image' src='Assets/uploadicon.png' data-toggle='modal' data-target='#NoteImageModal' />" +
                "<input style='background-color: " + color + "' type='image' onclick='ArchiveUnArchive(" + NoteId + ")' title='Archive' height='13' width='13' alt='Archive' src='Assets/archiveicon.png' />" +
                "<input style='background-color: " + color + "' type='image' onclick='mmtoggle(" + NoteId + ")' title='More' height='18' width='18' alt='More' src='Assets/more.svg' />" +
                "</div>" +
                "</div>" +
                "<div id = '" + NoteId + "' class= 'card mmhidden'>" +
                "<div class='card-body mmbody'>" +
                "<button class='mmbutton' onclick='TrashAndRestore(" + NoteId + ")' >" + "Delete Note" + "</button>" +
                "<button  onclick='addlabelfeed(" + NoteId + ")' data-toggle='modal' data-target='#addlabelmodal' class='mmbutton' > " + "Add Label " + "</button > " +
                "</div>" +
                "</div >", showlabel(NoteId)
            ).appendTo($('#allnotesrow'));



        })
    })

});



function show(id) {
    document.getElementById(id).style.visibility = "visible";
}

function hide(id) {
    document.getElementById(id).style.visibility = "hidden";
}

function colorinp(id, color) {
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

function usermenuemail() {
    var semail = localStorage.getItem("UserEmail");
    $("#show-email").text(semail);

}

function signoutfun() {
    localStorage.removeItem("UserEmail");
    window.location.href = "https://localhost:44337/Webform/Homepage.aspx";
}

function collabnoteidfeed(id) {
    document.getElementById('collab-save-btn').setAttribute("value", id)
    ce();
}

function listview() {
    $(".carddesign").toggleClass("listviewcl");
}

function Refresh() {
    window.location.reload();
}

function togglebar() {
    $("#sidepanel").toggleClass("active");
}

function updateidfeed(id, pic) {
    console.log(id);
    console.log("picture" + pic);
    document.getElementById('updatenoteclose').setAttribute("value", id);
    $("#unimg").attr("src", pic);
}

function updateimgfeed(event, pic) {
    console.log(event.currentTarget, "dhhuj");
    $("#unimg").attr("src", pic);

}

function addlabelfeed(id) {
    document.getElementById('addlabelclose').setAttribute("value", id)
    ce();
}

$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "https://localhost:44337/Account/GetProfilePic",
        data: { id: localStorage.getItem("UserEmail") },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            console.log(data);
            var pic = data.profilepic;
            $("#userpic").attr("src", pic);
            $("#userpicbody").attr("src", pic);
        }
    })
});

    function showlabel(ge) {
        $.ajax({
            type: "GET",
            url: "https://localhost:44337/Label/GetLabelByNoteId",
            data: { id: ge },
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                console.log(data);
                var noteid = data.label.NoteId;
                var labelid = data.label.LabelId;
                var details = data.label.Details;
                $("#l" + ge).text(details);
                if (details != null) {
                    $("#reminderlisb").after("<li>" + "<img style='margin-top:-10px; margin-left:-17px'  src='Assets/newlabel.png' height='25' width='25' />" + "<button type='button' style='margin-left:25px' >" + details + "</button >" + "</li >");

                    $("<div style='display:flex;flex-direction:row; justify-content: space-between'>" +
                        "<input type='image' title='Label' height='15' width='20' alt='label' src='Assets/labelicongrey.png'>" +
                        "<input type='text' style='outline:none; border:none' value= '" + details + "' >" +
                        "<input type='image' title='Delete Label' height='15' width='20' onclick='DeleteLabelFun(" + labelid + ")' alt='Delete label' src='Assets/deleteforever.png'>" +
                        "</div>").appendTo($('#editlabellist'));
                }
            }
            });
    }

function NoteImageFun(noteid) {
    document.getElementById('noteimageid').setAttribute("value", noteid);
}

function EditLabelIdFeed(labelid) {
    document.getElementById('editlabelidhid').setAttribute("value", labelid);
}

function UpdateLabelFun (newdetails) {
    var x = parseInt($('#editlabelidhid').val());
    var ulabel = {};
    ulabel.labelid = x;
    ulabel.details = newdetails.val();
    console.log(JSON.stringify(ulabel))
    $.ajax({
        type: "PUT",
        url: "https://localhost:44337/Label/UpdateLabel",
        data: JSON.stringify(ulabel),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        processData: true,
        success: function () {
            window.location.reload();
        },
        error: function () {
            alert("some error occured");
        }
    });
    return false;
}

