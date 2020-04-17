namespace FundooRepository.InterfaceRepo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Common;
   public interface IAccount
    {
        bool DoLogin();
        bool DoRegistration();
        bool ForgotPasswordUser();
        bool ResetPasswordUser();
    }
}
