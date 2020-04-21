using BusinessManager.InterfaceManager;
using Common.UserModel;
using FundooRepository.InterfaceRepo;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManager.ImplementationClassManager
{
    public class AccountManagerImpl : IAccountManager
    {
        private readonly IAccount accountrepo;

      public  AccountManagerImpl(IAccount accountrepo)
        {
            this.accountrepo = accountrepo;
        }

        public User DoLogin(LoginModel manager)
        {
            return this.accountrepo.DoLogin(manager);
        }

        public User DoRegistration(RegistrationModel manager)
        {
            return this.accountrepo.DoRegistration(manager);
        }

        public bool ForgotPasswordUser(string email, string url)
        {
            return this.accountrepo.ForgotPasswordUser(email,url);
        }

       /* public ResetPassword ResetPasswordUser(ResetPassword manager)
        {
            return this.accountrepo.ResetPasswordUser(manager);
        }*/
    }
}
