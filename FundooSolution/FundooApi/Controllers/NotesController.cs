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
        public  IActionResult AddNote([FromBody]  NewNote notemodel, IFormFile file)
        {
            string useremail = this.User.Identity.Name;
            if(useremail!=null)
            {
                if(manager.AddNote(useremail,notemodel,file))
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
    }
}
