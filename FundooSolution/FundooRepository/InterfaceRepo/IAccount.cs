namespace FundooRepository.InterfaceRepo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Common.UserModel;
    public interface IAccount
    {
        User DoLogin(LoginModel loginmodel);
        User DoRegistration(RegistrationModel model);
        bool ForgotPasswordUser(string email,string url);
       // ResetPassword ResetPasswordUser(ResetPassword resetmodel);
    }
}
