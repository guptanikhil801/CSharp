using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessManager.InterfaceManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Common.UserModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace FundooApi.Controllers
{
    [ApiController]//[Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountManager manager;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IConfiguration configuration;

        public AccountController(IAccountManager manager, UserManager<User> userManager
            , SignInManager<User> signInManager, IConfiguration configuration)
        {
            this.manager = manager;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.configuration = configuration;
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
            var currentuser = await userManager.FindByEmailAsync(model.Email);
            if (currentuser != null && await userManager.CheckPasswordAsync(currentuser, model.Password))
            {
                var claim = new [] { new Claim(JwtRegisteredClaimNames.Sub, currentuser.UserName) };
                var signkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Signingkey"]));
                int expiryminutes = Convert.ToInt32(configuration["Jwt:ExpiryInMinutes"]);
                var token = new JwtSecurityToken(
                    issuer: configuration["Jwt:Site"],
                    audience: configuration["Jwt:Site"],
                    expires: DateTime.UtcNow.AddMinutes(expiryminutes),
                    signingCredentials: new SigningCredentials(signkey,SecurityAlgorithms.HmacSha256)
                    );
                return Ok(
                    new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                    });
            }
            return this.Unauthorized();
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
        public async Task<IActionResult> ForgotPassword([FromBody]string uemail)
        {
            var currentuser = await userManager.FindByEmailAsync(uemail);
            if (currentuser != null && await userManager.IsEmailConfirmedAsync(currentuser))
            {
                var _token = await userManager.GeneratePasswordResetTokenAsync(currentuser);
                var resetlink = Url.Action("ResetPassword", "AccountController",
                    new { email = uemail, token = _token }, Request.Scheme);
               if(manager.ForgotPasswordUser(uemail, resetlink))
                {
                    return this.Ok("A link has been sent to your email to reset your password");
                }
            }
            return this.BadRequest();
        }
    }
}
