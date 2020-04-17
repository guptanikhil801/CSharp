namespace FundooRepository.InterfaceRepo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Common.UserModel;
   public interface IAccount
    {
        bool DoLogin(Login loginmodel);
        void DoRegistration(User usermodel);
        string ForgotPasswordUser(ForgotPassword forgotmodel);
        bool ResetPasswordUser(string email,ResetPassword resetmodel);
    }
}
