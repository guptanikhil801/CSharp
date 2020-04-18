using Common.UserModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManager.InterfaceManager
{
   public interface IAccountManager
    {
        LoginModel DoLogin(LoginModel manager);
        User DoRegistration(RegistrationModel manager);
        ForgotPassword ForgotPasswordUser(ForgotPassword manager);
        ResetPassword ResetPasswordUser(ResetPassword manager);
    }
}
