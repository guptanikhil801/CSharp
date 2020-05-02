namespace FundooApi.Controllers
{
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

    [ApiController]
    [Authorize]
    public class LabelController : ControllerBase
    {
        private readonly UserManager<User> userManager;
        private readonly UserDBContext dbcontext;
        private readonly ILabelManager manager;
        private ILabelManager @object;

        public LabelController(UserManager<User> userManager, UserDBContext dbcontext, ILabelManager manager)
        {
            this.userManager = userManager;
            this.dbcontext = dbcontext;
            this.manager = manager;
        }

        public LabelController(ILabelManager @object)
        {
            this.@object = @object;
        }

        [HttpPost]
        [Route("api/Labels/AddLabel")]
        public IActionResult AddLabel([FromBody]  string details, string useremail)
        {
            // string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                // if (manager.AddLabel(useremail, details))
                if (this.@object.AddLabel(useremail, details))
                {
                    return this.Ok("Label created");
                }
            }

            return this.BadRequest();
        }

        [HttpDelete]
        [Route("api/Labels/DeleteLabel")]
        public IActionResult DeleteLabel([FromBody] int id)
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                if (this.manager.DeleteLabel(useremail, id))
                {
                    return this.Ok("Label deleted Successfully");
                }
            }

            return this.BadRequest();
        }

        [HttpGet]
        [Route("api/Labels/GetLabel")]
        public IActionResult GetLabel([FromBody] int id)
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                var label = manager.GetLabel(useremail, id);
                {
                    return this.Ok(label);
                }
            }

            return this.BadRequest();
        }

        [HttpGet]
        [Route("api/Labels/GetAllLabels")]
        public IActionResult GetAllLabelss()
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                var alllabels = manager.GetAllLabels(useremail);
                {
                    return this.Ok(alllabels);
                }
            }

            return this.BadRequest();
        }

        [HttpPut]
        [Route("api/Labels/UpdateLabel")]
        public IActionResult UpdateLabel([FromBody] String newdetail, int id)
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                if (this.manager.UpdateLabel(useremail, id, newdetail))
                {
                    return this.Ok("label has been updated successfully");
                }
            }

            return this.BadRequest();
        }
    }
}
