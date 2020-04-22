// -------------------------------------------------------------------------------------------------------
// <copyright file="AccountController.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace FundooApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;
    using BusinessManager.InterfaceManager;
    using Common.UserModel;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;

    /// <summary>
    /// This is Account Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    public class AccountController : ControllerBase
    {
        /// <summary>
        /// dependency of IAccountManager
        /// </summary>
        private readonly IAccountManager manager;

        /// <summary>
        /// dependency of userManager
        /// </summary>
        private readonly UserManager<User> userManager;

        /// <summary>
        /// dependency of The signInmanager
        /// </summary>
        private readonly SignInManager<User> signinmanager;

        /// <summary>
        /// Dependency of IConfiguration
        /// </summary>
        private readonly IConfiguration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        /// <param name="userManager">The user manager.</param>
        /// <param name="signinmanager">The sign in manager.</param>
        /// <param name="configuration">The configuration.</param>
        public AccountController(IAccountManager manager, UserManager<User> userManager, SignInManager<User> signinmanager, IConfiguration configuration)
        {
            this.manager = manager;
            this.userManager = userManager;
            this.signinmanager = signinmanager;
            this.configuration = configuration;
        }

        /// <summary>
        /// Registers the specified New User.
        /// </summary>
        /// <param name="model">The model class of Register.</param>
        /// <returns>200 ok message if registration succeeded, else 400 Bad request</returns>
        [HttpPost]
        [Route("api/Account/Register")]
        public async Task<IActionResult> Register([FromBody] RegistrationModel model)
        {
            var result = await this.userManager.CreateAsync(this.manager.DoRegistration(model), model.Password);
            if (result.Succeeded)
            {
                return this.Ok();
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Logins the specified User
        /// </summary>
        /// <param name="model">The model class of login.</param>
        /// <returns>A jwt token and 200 ok message if suceeded otherwise 401 message</returns>
        [HttpPost]
        [Route("api/Account/Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var currentuser = await this.userManager.FindByEmailAsync(model.Email);
            if (currentuser != null && await this.userManager.CheckPasswordAsync(currentuser, model.Password))
            {
                var claim = new[] { new Claim(JwtRegisteredClaimNames.Sub, currentuser.UserName) };
                var signkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["Jwt:Signingkey"]));
                int expiryminutes = Convert.ToInt32(this.configuration["Jwt:ExpiryInMinutes"]);
                var token = new JwtSecurityToken(
                    issuer: this.configuration["Jwt:Site"],
                    audience: this.configuration["Jwt:Site"],
                    expires: DateTime.UtcNow.AddMinutes(expiryminutes),
                    signingCredentials: new SigningCredentials(signkey, SecurityAlgorithms.HmacSha256));
                return this.Ok(
                    new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                    });
            }

            return this.Unauthorized();
        }

        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="model">The model class of reset password.</param>
        /// <returns>200 ok message if succeeded else 400 bad request</returns>
        [HttpPost]
        [Route("api/Account/ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPassword model)
        {
            var currentuser = await this.userManager.FindByEmailAsync(model.Email);
            if (currentuser == null)
            {
                return this.BadRequest();
            }

            var Code = await this.userManager.GeneratePasswordResetTokenAsync(currentuser);
            model.Code = Code;
            var result = await this.userManager.ResetPasswordAsync(currentuser, model.Code, model.NewPassword);
            if (result.Succeeded)
            {
                return this.Ok();
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// action for Forgot password.
        /// </summary>
        /// <param name="uemail">The email.</param>
        /// <returns>200 ok message if succeeded else 400 bad request</returns>
        [HttpPost]
        [Route("api/Account/ForgotPassword")]
        public async Task<IActionResult> ForgotPassword([FromBody]string uemail)
        {
            var currentuser = await this.userManager.FindByEmailAsync(uemail);
            if (currentuser != null && await this.userManager.IsEmailConfirmedAsync(currentuser))
            {
                var _token = await this.userManager.GeneratePasswordResetTokenAsync(currentuser);
                var resetlink = Url.Action("ResetPassword", "AccountController", new { email = uemail, token = _token }, Request.Scheme);
                if (this.manager.ForgotPasswordUser(uemail, resetlink))
                {
                    return this.Ok("A link has been sent to your email to reset your password");
                }
            }

            return this.BadRequest();
        }
    }
}
