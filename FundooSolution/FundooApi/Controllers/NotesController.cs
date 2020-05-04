// -------------------------------------------------------------------------------------------------------
// <copyright file="NotesController.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------

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
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Notes controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController] [Authorize]
    public class NotesController : ControllerBase
    {
        /// <summary>
        /// The user manager
        /// </summary>
        private readonly UserManager<User> userManager;

        /// <summary>
        /// The dbcontext
        /// </summary>
        private readonly UserDBContext dbcontext;

        /// <summary>
        /// The manager
        /// </summary>
        private readonly INotesManager manager;

        /// <summary>
        /// The object
        /// </summary>
        private INotesManager @object;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotesController"/> class.
        /// </summary>
        /// <param name="userManager">The user manager.</param>
        /// <param name="dbcontext">The dbcontext.</param>
        /// <param name="manager">The manager.</param>
        public NotesController(UserManager<User> userManager, UserDBContext dbcontext, INotesManager manager)
        {
            this.userManager = userManager;
            this.dbcontext = dbcontext;
            this.manager = manager;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotesController"/> class.
        /// </summary>
        /// <param name="object">The object.</param>
        public NotesController(INotesManager @object)
        {
            this.@object = @object;
        }

        /// <summary>
        /// Adds the note.
        /// </summary>
        /// <param name="notemodel">The notemodel.</param>
        /// <returns>200 status if success otherwise 400</returns>
        [HttpPost]
        [Route("api/Notes/AddNote")]
        public IActionResult AddNote([FromBody] NewNote notemodel)
        {
            IFormFile file = null;
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                if (this.manager.AddNote(useremail, notemodel, file))
                {
                    return this.Ok("Note created");
                }
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Gets the note.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>200 status if success otherwise 400</returns>
        [HttpGet]
        [Route("api/Notes/GetNote")]
        public IActionResult GetNote([FromBody] int id)
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                var note = this.manager.GetNote(useremail, id);
                {
                    return this.Ok(note);
                }
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Gets all notes.
        /// </summary>
        /// <returns>all notes</returns>
        [HttpGet]
        [Route("api/Notes/GetAllNotes")]
        public IActionResult GetAllNotes()
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                var note = this.manager.GetAllNotes(useremail);
                {
                    return this.Ok(note);
                }
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Updates the note.
        /// </summary>
        /// <param name="note">The note.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>200 status if success otherwise 400</returns>
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

        /// <summary>
        /// Updates the note image.
        /// </summary>
        /// <param name="imgfile">The imgfile.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>200 status if success otherwise 400</returns>
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

        /// <summary>
        /// Deletes the note.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>200 status if success otherwise 400</returns>
        [HttpDelete]
        [Route("api/Notes/DeleteNote")]
        public IActionResult DeleteNote([FromBody]  int id)
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

        /// <summary>
        /// Archives the note by specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>200 status if success otherwise 400</returns>
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

        /// <summary>
        /// Archiveds the notes.
        /// </summary>
        /// <returns>All archived notes of user</returns>
        [HttpGet]
        [Route("api/Notes/ArchivedNotes")]
        public IActionResult ArchivedNotes()
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                var note = this.manager.ArchivedNoteList(useremail);
                {
                    return this.Ok(note);
                }
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Pins the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>200 status if success otherwise 400</returns>
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

        /// <summary>
        /// Pinneds the notes.
        /// </summary>
        /// <returns>200 status if success otherwise 400</returns>
        [HttpGet]
        [Route("api/Notes/PinnedNotes")]
        public IActionResult PinnedNotes()
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                var note = this.manager.PinnedNoteList(useremail);
                {
                    return this.Ok(note);
                }
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Restores the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>200 status if success otherwise 400</returns>
        [HttpPut]
        [Route("api/Notes/Restore")]
        public IActionResult Restore([FromBody] int id)
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                if (this.manager.Restore(useremail,id))
                {
                    return this.Ok("Note Restored");
                }
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Trashes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>200 status if success otherwise 400</returns>
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

        /// <summary>
        /// Trashed notes.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Notes/TrashedNotes")]
        public IActionResult TrashedNotes()
        {
           string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                var notes = manager.TrashNoteList(useremail);
                {
                    return this.Ok(notes);
                }
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Searches the specified searchquery.
        /// </summary>
        /// <param name="searchquery">The searchquery.</param>
        /// <returns>searche notes</returns>
        [HttpGet]
        [Route("api/Notes/Search")]
        public IActionResult Search([FromBody] string searchquery)
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                var searchitem = manager.SearchNotes(useremail, searchquery);
                {
                    return this.Ok(searchitem);
                }
            }

            return this.BadRequest();
        }
    }
}