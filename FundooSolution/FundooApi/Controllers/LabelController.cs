// -------------------------------------------------------------------------------------------------------
// <copyright file="LabelController.cs" company="Bridgelabz">
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
    using Common.UserModel;
    using FundooRepository.Context;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Label Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Authorize]
    public class LabelController : ControllerBase
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
        private readonly ILabelManager manager;

        /// <summary>
        /// The object
        /// </summary>
        private ILabelManager @object;

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelController"/> class.
        /// </summary>
        /// <param name="userManager">The user manager.</param>
        /// <param name="dbcontext">The dbcontext.</param>
        /// <param name="manager">The manager.</param>
        public LabelController(UserManager<User> userManager, UserDBContext dbcontext, ILabelManager manager)
        {
            this.userManager = userManager;
            this.dbcontext = dbcontext;
            this.manager = manager;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelController"/> class.
        /// </summary>
        /// <param name="object">The object.</param>
        public LabelController(ILabelManager @object)
        {
            this.@object = @object;
        }

        /// <summary>
        /// Adds the label.
        /// </summary>
        /// <param name="details">The details.</param>
        /// <returns>200 status if success otherwise 400 status</returns>
        [HttpPost]
        [Route("api/Labels/AddLabel")]
        public IActionResult AddLabel([FromBody]  string details)
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                 if (this.manager.AddLabel(useremail, details))
                {
                    return this.Ok("Label created");
                }
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>200 status if success otherwise 400 status</returns>
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

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>200 status if success otherwise 400 status</returns>
        [HttpGet]
        [Route("api/Labels/GetLabel")]
        public IActionResult GetLabel([FromBody] int id)
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                var label = this.manager.GetLabel(useremail, id);
                {
                    return this.Ok(label);
                }
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Gets all labels.
        /// </summary>
        /// <returns>200 status if success otherwise 400 status</returns>
        [HttpGet]
        [Route("api/Labels/GetAllLabels")]
        public IActionResult GetAllLabels()
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                 var alllabels = this.manager.GetAllLabels(useremail);
                {
                    return this.Ok(alllabels);
                }
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="newdetail">The newdetail.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>200 status if success otherwise 400 status</returns>
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
