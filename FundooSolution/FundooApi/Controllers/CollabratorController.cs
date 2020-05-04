// -------------------------------------------------------------------------------------------------------
// <copyright file="CollabratorController.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------

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
    /// <summary>
    /// Collabrator controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController] [Authorize]
    public class CollabratorController : ControllerBase
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
        private readonly ICollabratorManager manager;
        private ICollabratorManager @object;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollabratorController"/> class.
        /// </summary>
        /// <param name="object">The object.</param>
        public CollabratorController(ICollabratorManager @object)
        {
            this.@object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollabratorController"/> class.
        /// </summary>
        /// <param name="userManager">The user manager.</param>
        /// <param name="dbcontext">The dbcontext.</param>
        /// <param name="manager">The manager.</param>
        public CollabratorController(UserManager<User> userManager, UserDBContext dbcontext, ICollabratorManager manager)
        {
            this.userManager = userManager;
            this.dbcontext = dbcontext;
            this.manager = manager;
        }

        /// <summary>
        /// Adds the collabrator.
        /// </summary>
        /// <param name="collabemail">The collabemail.</param>
        /// <param name="noteid">The noteid.</param>
        /// <returns>200 status if success otherwise 400 status</returns>
        [HttpPost]
        [Route("api/Collabrators/AddCollabrator")]
        public IActionResult AddCollabrator(string collabemail, int noteid)
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                 if (manager.AddCollabrator(useremail, collabemail, noteid))
                {
                    return this.Ok("Collabrator Added");
                }
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Gets all collabrators.
        /// </summary>
        /// <returns>all Collabrators</returns>
        [HttpGet]
        [Route("api/Collabrators/GetAllCollabrators")]
        public IActionResult GetAllCollabrators()
        {
            string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                var allcollabrator = manager.GetAllCollabrator(useremail);
                {
                    return this.Ok(allcollabrator);
                }
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Removes the collabrator.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>200 status if success otherwise 400 status</returns>
        [HttpDelete]
        [Route("api/Collabrators/RemoveCollabrator")]
        public IActionResult RemoveCollabrator([FromBody] int id)
        {
           string useremail = this.User.Identity.Name;
            if (useremail != null)
            {
                 if (this.manager.RemoveCollabrator(id))
                {
                    return this.Ok("Collabrator Removed Successfully");
                }
            }

            return this.BadRequest();
        }
    }
}
