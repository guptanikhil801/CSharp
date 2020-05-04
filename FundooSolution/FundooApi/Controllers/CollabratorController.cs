using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessManager.InterfaceManager;
using Common.UserModel;
using FundooRepository.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FundooApi.Controllers
{
    [ApiController] [Authorize]
    public class CollabratorController : ControllerBase
    {
        private readonly UserManager<User> userManager;
        private readonly UserDBContext dbcontext;
        private readonly ICollabratorManager manager;
        private ICollabratorManager @object;

        public CollabratorController(ICollabratorManager @object)
        {
            this.@object = @object;
        }

        public CollabratorController(UserManager<User> userManager, UserDBContext dbcontext, ICollabratorManager manager)
        {
            this.userManager = userManager;
            this.dbcontext = dbcontext;
            this.manager = manager;
        }

        [HttpPost]
        [Route("api/Collabrators/AddCollabrator")]
        public IActionResult AddCollabrator(string useremail, string collabemail, int noteid)
        {
            //string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                //  if (manager.AddCollabrator(useremail, collabemail, noteid))
                if (@object.AddCollabrator(useremail, collabemail, noteid))
                {
                    return this.Ok("Collabrator Added");
                }
            }

            return this.BadRequest();
        }

        [HttpGet]
        [Route("api/Collabrators/GetAllCollabrators")]
        public IActionResult GetAllCollabrators(string useremail)
        {
            //string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
               // var alllabels = manager.GetAllCollabrator(useremail);
                var alllabels = @object.GetAllCollabrator(useremail);
                {
                    return this.Ok(alllabels);
                }
            }

            return this.BadRequest();
        }

        [HttpDelete]
        [Route("api/Collabrators/RemoveCollabrator")]
        public IActionResult RemoveCollabrator([FromBody] string useremail, int id)
        {
           // string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                //  if (this.manager.RemoveCollabrator(id))
                if (this.@object.RemoveCollabrator(id))
                {
                    return this.Ok("Collabrator Removed Successfully");
                }
            }

            return this.BadRequest();
        }
    }
}
