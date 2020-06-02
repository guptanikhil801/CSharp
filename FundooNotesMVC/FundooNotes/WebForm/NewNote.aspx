<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewNote.aspx.cs" Inherits="FundooNotes.WebForm.NewNote" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>New Note</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" type="text/css" href="CssFile/newnote.css"/>
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"/>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
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
    
    <form id="form1" runat="server">
     <section class="newnotebody"  >
        <div class="note-container" >
            <div class="pin-title">
                <asp:Label runat="server">Title</asp:Label> <asp:ImageButton title="Pin Note" CssClass="display" runat="server" ImageUrl="Assets/pin.svg" />

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
                    <asp:ImageButton ID="moremenu" CssClass="img-icon icon-size" runat="server" ImageUrl="Assets/more.svg" />
                        <div class="more-menu" id="menu">
                            <asp:TextBox runat="server" TextMode="DateTimeLocal"></asp:TextBox>
                        </div>
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
        </form>

</body>
</html>
