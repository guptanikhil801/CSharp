<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewNote.aspx.cs" Inherits="FundooNotes.AspxFiles.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Note</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"/>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
    <script>
        $(document).ready(function () {
            $("#moremenu").click(function () {
                $("#menu").css("display", "content")
            })
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
     <section class="body">
        <div class="note-container">
            <div class="pin-title">
                <asp:Label runat="server">Title</asp:Label> <asp:ImageButton title="Pin Note" CssClass="display" runat="server" ImageUrl="Assets/pin.svg" />

            </div>
            <input type="text" class="no-outline"  id="newnote" placeholder="Take a Note..."/>
            <div class="button-icons display">
                <div class="but-icons">
                    <asp:ImageButton CssClass="img-icon" title="Remind me" runat="server" ImageUrl="Assets/reminder.svg" />
                    <asp:ImageButton CssClass="img-icon" title="Collaborator" runat="server" ImageUrl="Assets/colab.svg" />
                    <asp:ImageButton CssClass="img-icon" title="Change color" runat="server" ImageUrl="Assets/colorpaletteicon.png" />
                    <asp:ImageButton CssClass="img-icon" title="Add image" runat="server" ImageUrl="Assets/uploadicon.png" />
                    <asp:ImageButton CssClass="img-icon" title="Archive" runat="server" ImageUrl="Assets/archiveicon.png" />
                    <div class="more-menu-container">
                    <asp:ImageButton ID="moremenu" CssClass="img-icon icon-size" runat="server" ImageUrl="Assets/more.svg" />
                        <div class="more-menu" id="menu">
                            <asp:TextBox runat="server" TextMode="DateTimeLocal"></asp:TextBox>
                        </div>
                        </div>
                </div>
                <asp:Button runat="server" title="close" Text="Close"></asp:Button>
            </div>
        </div>
    </section>
        </form>
    <style>
        .note-container{
            padding:20px;
            border:1px solid lightgray;
            width:580px;
            border-radius:6px;
            margin-top:40px;
        }

        .body{
            width:1000px;
            margin:0 auto;
        }

        .pin-title{
            display:flex;
            align-items:center;
            justify-content:space-between;
            margin-bottom:10px;
        }

        .button-icons{
            display:flex;
            align-items:center;
            justify-content:space-around;
            margin-top:10px;
        }
        .but-icons{
             display:flex;
            align-items:center;
        }

        .img-icon{
            margin-right:35px;
        }
        .icon-size{
            height:20px;
        }
        .more-menu-container{
            position:relative;
             display:flex;
            align-items:center;
            transition:all .4s;
        }
        .more-menu{
            display:none;
            padding:10px;
            position:absolute;
            top:100%;
            left:-50%;
        }
        .display{
            visibility:hidden;
        }
        .note-container:hover .display{
            visibility:visible;
        }
              input {
         margin-top:5px;
         margin-bottom:5px;
        border-top-style: hidden;
        border-right-style: hidden;
        border-left-style: hidden;
        border-bottom-style: hidden;
        background-color: white;
      }
      
      .no-outline:focus {
        outline: none;
      }
    </style>

</body>
</html>
