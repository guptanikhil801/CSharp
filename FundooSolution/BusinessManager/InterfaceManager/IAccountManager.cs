using Common.UserModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManager.InterfaceManager
{
   public interface IAccountManager
    {
        User DoLogin(LoginModel manager);
        User DoRegistration(RegistrationModel manager);
        bool ForgotPasswordUser(string email, string url);
       // ResetPassword ResetPasswordUser(ResetPassword manager);
    }
}
