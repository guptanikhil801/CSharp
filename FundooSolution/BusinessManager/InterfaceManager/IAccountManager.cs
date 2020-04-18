using Common.UserModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManager.InterfaceManager
{
   public interface IAccountManager
    {
        LoginModel DoLogin(LoginModel loginmodel);
        User DoRegistration(RegistrationModel model);
        ForgotPassword ForgotPasswordUser(ForgotPassword forgotmodel);
        ResetPassword ResetPasswordUser(ResetPassword resetmodel);
    }
}
