﻿// -------------------------------------------------------------------------------------------------------
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
    using FundooRepository.Context;
    using Microsoft.AspNetCore.Authorization;
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
        private readonly UserDBContext dbcontext;
        private IAccountManager object1;
        private UserManager<User> object2;
        private SignInManager<User> object3;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        /// <param name="userManager">The user manager.</param>
        /// <param name="signinmanager">The sign in manager.</param>
        /// <param name="configuration">The configuration.</param>
        public AccountController(IAccountManager manager, UserManager<User> userManager, SignInManager<User> signinmanager, IConfiguration configuration, UserDBContext dbcontext)
        {
            this.manager = manager;
            this.userManager = userManager;
            this.signinmanager = signinmanager;
            this.configuration = configuration;
            this.dbcontext = dbcontext;
        }

        public AccountController(IAccountManager object1, UserManager<User> object2, SignInManager<User> object3)
        {
            this.object1 = object1;
            this.object2 = object2;
            this.object3 = object3;
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
                var claim = new[] { new Claim(JwtRegisteredClaimNames.UniqueName, currentuser.UserName) };
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
            var currentuser = this.dbcontext.Users.FirstOrDefault(o => o.Email == uemail);
            if (currentuser != null && await this.userManager.IsEmailConfirmedAsync(currentuser))
            {
                var _token = await this.userManager.GeneratePasswordResetTokenAsync(currentuser);
                var resetlink = Url.Action("ResetPassword", "Account", new { email = uemail, token = _token }, Request.Scheme);
                if (this.manager.ForgotPasswordUser(uemail, resetlink))
                {
                    return this.Ok("A link has been sent to your email to reset your password");
                }
            }

            return this.BadRequest();
        }

        /// <summary>
        /// action for adding/update Profile picture.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="imgfile">The image file.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/Account/ProfilePicture")]
        public IActionResult ProfilePicture(string email, IFormFile imgfile)
        {
            if (email != null)
            {
                if (this.manager.ProfilePicture(email, imgfile))
                {
                    return this.Ok("Profile picture Added or updated successfully");
                }
            }

            return this.BadRequest();
        }

        /// <summary>
        /// action for Social login.
        /// </summary>
        /// <param name="returnurl">The returnurl.</param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [Route("api/Account/SocialLogin")]
        public async Task<IActionResult> SocialLogin(string returnurl)
        {
            var providerlist = (await signinmanager.GetExternalAuthenticationSchemesAsync()).ToList();
            var redirecturl = Url.Action("SocialLoginCallBack", "Account",
                new { ReturnUrl = returnurl });
            var properties = signinmanager.ConfigureExternalAuthenticationProperties(providerlist[0].DisplayName, redirecturl);
            return new ChallengeResult(providerlist[0].DisplayName, properties);
        }

        /// <summary>
        /// Logouts this instance.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Account/Logout")]
        public async Task<IActionResult> Logout()
        {
          await  signinmanager.SignOutAsync();
            return RedirectToAction("Login");
        }

    }
}
