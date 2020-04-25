namespace FundooApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BusinessManager.InterfaceManager;
    using Common.ModelsOfNotes;
    using Common.UserModel;
    using FundooRepository.Context;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    //[Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly UserManager<User> userManager;
        private readonly UserDBContext dbcontext;
        private readonly INotesManager manager;

        public NotesController(UserManager<User> userManager, UserDBContext dbcontext, INotesManager manager)
        {
            this.userManager = userManager;
            this.dbcontext = dbcontext;
            this.manager = manager;
        }

        [HttpPost]
        [Route("api/Notes/AddNote")]
        public IActionResult AddNote([FromBody]  NewNote notemodel, IFormFile file)
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                if (manager.AddNote(useremail, notemodel, file))
                {
                    return this.Ok("Note created");
                }
            }

            return this.BadRequest();
        }

        [HttpGet]
        [Route("api/Notes/GetNote")]
        public IActionResult GetNote([FromBody] int id)
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                var note = manager.GetNote(useremail, id);
                {
                    return this.Ok(note);
                }
            }

            return this.BadRequest();
        }

        [HttpGet]
        [Route("api/Notes/GetAllNotes")]
        public IActionResult GetAllNotes()
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                var note = manager.GetAllNotes(useremail);
                {
                    return this.Ok(note);
                }
            }

            return this.BadRequest();
        }

        [HttpPut]
        [Route("api/Notes/UpdateNote")]
        public IActionResult UpdateNote([FromBody] NewNote note, int id)
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                if (this.manager.UpdateNote(useremail, note, id))
                {
                    return this.Ok("Note has been updated successfully");
                }
            }

            return this.BadRequest();
        }

        [HttpPut]
        [Route("api/Notes/UpdateNoteImage")]
        public IActionResult UpdateNoteImage([FromBody] IFormFile imgfile, int id)
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                if (this.manager.UpdateNoteImage(useremail, id, imgfile))
                {
                    return this.Ok("Note Image updated successfully");
                }
            }

            return this.BadRequest();
        }

        [HttpDelete]
        [Route("api/Notes/DeleteNote")]
        public IActionResult DeleteNote([FromBody] NewNote note, int id)
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                if (this.manager.DeleteNote(useremail, id))
                {
                    return this.Ok("Note deleted Successfully");
                }
            }

            return this.BadRequest();
        }

        [HttpPut]
        [Route("api/Notes/Archive")]
        public IActionResult Archive([FromBody] int id)
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                if (this.manager.Archive(useremail, id))
                {
                    return this.Ok("Note Archived/UnArchived");
                }
            }

            return this.BadRequest();
        }

        [HttpGet]
        [Route("api/Notes/ArchivedNotes")]
        public IActionResult ArchivedNotes()
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                var note = manager.ArchivedNoteList(useremail);
                {
                    return this.Ok(note);
                }
            }

            return this.BadRequest();
        }

        [HttpPut]
        [Route("api/Notes/Pin")]
        public IActionResult Pin([FromBody] int id)
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                if (this.manager.Pin(useremail, id))
                {
                    return this.Ok("Note Pinned/Unpinned");
                }
            }

            return this.BadRequest();
        }

        [HttpGet]
        [Route("api/Notes/PinnedNotes")]
        public IActionResult PinnedNotes()
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                var note = manager.PinnedNoteList(useremail);
                {
                    return this.Ok(note);
                }
            }

            return this.BadRequest();
        }

        [HttpPut]
        [Route("api/Notes/Trash")]
        public IActionResult Trash([FromBody] int id)
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                if (this.manager.Trash(useremail, id))
                {
                    return this.Ok("Note put into Trash");
                }
            }

            return this.BadRequest();
        }



    }
}
