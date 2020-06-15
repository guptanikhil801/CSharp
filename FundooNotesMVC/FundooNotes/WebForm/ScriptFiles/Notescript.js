
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
            $("<div style='background-color: " + color + "' class= 'card carddesign'>" +
                "<div class= 'card-body'>" +
                "<h5 class='card-title' data-toggle='modal' data-target='#updatenotemodal' onclick='updateidfeed(" + NoteId + ")' > " + title + "</h5 > " +
                "<p class='card-text' data-toggle='modal' data-target='#updatenotemodal'onclick='updateidfeed(" + NoteId + ")' >" + description + "</p>" +
                "<div class='anicon display'>" +
                "<input style='background-color: " + color + "' type='image'  title='Remind me' height='18' width='18' alt='Reminder' src='Assets/reminder.svg' />" +
                "<input style='background-color: " + color + "' type='image' onclick='collabnoteidfeed(" + NoteId + ")'  data-toggle='modal' data-target='#AddCollabModal' title='Collaborator' height='18' width='18' alt='Collaborator' src='Assets/colab.svg' />" +
                "<input style='background-color: " + color + "' type='image'  title='Change color' height='14' width='14' alt='Change color' src='Assets/colorpaletteicon.png' />" +
                "<input style='background-color: " + color + "' type='image'  title='Add image' height='16' width='16' alt='Add image' src='Assets/uploadicon.png' />" +
                "<input style='background-color: " + color + "' type='image' onclick='ArchiveUnArchive(" + NoteId + ")' title='Archive' height='13' width='13' alt='Archive' src='Assets/archiveicon.png' />" +
                "<input style='background-color: " + color + "' type='image' onclick='mmtoggle(" + NoteId +")' title='More' height='18' width='18' alt='More' src='Assets/more.svg' />" +
                "</div>" +
                "</div>" +

                "<div id = '" + NoteId + "' class= 'card mmhidden'>"+
                "<div class='card-body mmbody'>"+
                "<button class='mmbutton' onclick='TrashAndRestore(" + NoteId + ")' >"+ "Delete Note" +"</button>"+
                    "<button class='mmbutton'>" + "Add Label "+"</button>"+
                "</div>"+
    "</div >"
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

function updateidfeed(id) {
        document.getElementById('updatenoteclose').setAttribute("value", id);    
}

