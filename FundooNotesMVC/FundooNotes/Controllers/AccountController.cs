using Common.UserModel;
using FundooManager.ImplementationClassManager;
using FundooManager.InterfaceManager;
using FundooRepository.ImplementationClassRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FundooNotes.Controllers
{
    public class AccountController : Controller
    {
        private AccountImplClass manager = new AccountImplClass();

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            var checklogin = this.manager.Login(model);
            if (checklogin)
            {
                return Json(HttpStatusCode.OK);
            }
            return Json(HttpStatusCode.BadRequest);
        }

        [HttpPost]
        public ActionResult Register(RegistrationModel  newuser)
        {
                this.manager.Registration(newuser);
                return Json(HttpStatusCode.OK);
        }

        [HttpPut]
        public ActionResult ResetPassword(ResetPasswordModel model)
        {
            this.manager.ResetPassword(model);
            return Json(HttpStatusCode.OK);
        }

        [HttpPost]
        [Route("api/Account/ForgotPassword")]
        public ActionResult ForgotPassword(ForgotPassword model)
        {
                var resetlink = Url.Action("ResetPassword", "Account", new { email = model.Email });
                if (this.manager.ForgotPasswordUser(model, resetlink))
                {
                    return Json("A link has been sent to your email to reset your password");
                }
            return Json(HttpStatusCode.BadRequest);
        }
    }
}
