$(document).ready(function () {
    $('#archivednotesrow').hide();
    $('#trashednotesrow').hide();
    $('#allnotesrow').show();
    $.ajax({
        type: "GET",
        url: "https://localhost:44337/Notes/GetAllPinnedNotes",
        data: { id: localStorage.getItem("UserEmail") },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
    }).then(res => {
        console.log(res);
        res.allpinnednotes.forEach(el => {
            var title = el.Title
            var description = el.Description;
            var color = el.Colour;
            var NoteId = el.NoteId;
            var reminder = el.Reminder;
            var image = el.Image;
            var lnoteid = "l" + NoteId;


            $("<div style='background-color: " + color + "' class= 'card carddesign'>" +
                "<input type='image' style='background-color:transparent; margin-left:80%; margin-top:5px' onclick='PinUnPinfun(" + NoteId + ")' title='UnPin Note' height='22' width='22'  class='display' src='Assets/pinicongrey.png' />" +
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
            ).appendTo($('#allPinnednotesrow'));
        })
    })

});

