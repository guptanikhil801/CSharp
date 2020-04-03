// -------------------------------------------------------------------------------------------------------
// <copyright file="LoginController.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeManagementSystem.Manager;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Login controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        /// <summary>
        /// login manager instance variable 
        /// </summary>
        private IEmployeeManager loginmanager;

        /// <summary>
        /// constructor initialization
        /// </summary>
        /// <param name="loginmanager">the instance variable</param>
        public LoginController(IEmployeeManager loginmanager)
        {
            this.loginmanager = loginmanager;
        }

        /// <summary>
        /// method for login authentication
        /// </summary>
        /// <param name="email">email of employee</param>
        /// <param name="password">email of password</param>
        /// <returns>true or false</returns>
        [HttpGet]
        public  IActionResult Get(string email, string password)
        {
            var checklogin = this.loginmanager.Login(email, password);
            if(checklogin)
            {
                return this.Ok();
            }
            else
            {
                return this.BadRequest();
            }
        }
    }
}
