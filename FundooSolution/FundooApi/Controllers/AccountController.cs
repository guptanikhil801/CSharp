using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessManager.InterfaceManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Common.UserModel;

namespace FundooApi.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountManager manager;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AccountController(IAccountManager manager, UserManager<User> userManager
            , SignInManager<User> signInManager)
        {
            this.manager = manager;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        // POST: api/Account
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

        [HttpPost]
        [Route("api/Account/Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            //var currentuser =  userManager.Users.FirstOrDefault(x => x.Email == model.Email);
          // User currentuser = await this.userManager.FindByEmailAsync(model.Email);
            var currentuser = this.manager.DoLogin(model);
            if (currentuser != null)
            {
                var result = await this.signInManager.PasswordSignInAsync(currentuser, model.Password, isPersistent:false, false);
                if (result.Succeeded)
                {
                    return this.Ok();
                }

                return this.BadRequest();
            }
            else
            {
                return this.BadRequest();
            }
        }

        [HttpPost]
        [Route("api/Account/ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPassword model)
        {
            var currentuser = await userManager.FindByEmailAsync(model.Email);
            if (currentuser == null)
            {
                return this.BadRequest();
            }
            var Code = await userManager.GeneratePasswordResetTokenAsync(currentuser);
            model.Code = Code;
            var result = await userManager.ResetPasswordAsync(currentuser, model.Code, model.NewPassword);
            if (result.Succeeded)
            {
                return this.Ok();
            }
            else
            {
                return this.BadRequest();
            }
        }

        [HttpPost]
        [Route("api/Account/ForgotPassword")]
        public async Task<IActionResult> ForgotPassword([FromBody] string uemail) //, string url)
        {
            var currentuser = await userManager.FindByEmailAsync(uemail);
            if(currentuser != null && await userManager.IsEmailConfirmedAsync(currentuser))
            {
                var _token = await userManager.GeneratePasswordResetTokenAsync(currentuser);
                var resetlink = Url.Action("ResetPassword", "AccountController",
                    new { email = uemail, token = _token }, Request.Scheme);
               if(manager.ForgotPasswordUser(uemail, resetlink))
                {
                    return this.Ok();
                }
            }
            return this.BadRequest();
        }
    }
}
