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

        AccountManagerImpl(IAccount accountrepo)
        {
            this.accountrepo = accountrepo;
        }

        public LoginModel DoLogin(LoginModel manager)
        {
            return this.accountrepo.DoLogin(manager);
        }

        public User DoRegistration(RegistrationModel manager)
        {
            return this.accountrepo.DoRegistration(manager);
        }

        public ForgotPassword ForgotPasswordUser(ForgotPassword manager)
        {
            return this.accountrepo.ForgotPasswordUser(manager);
        }

        public ResetPassword ResetPasswordUser(ResetPassword manager)
        {
            return this.accountrepo.ResetPasswordUser(manager);
        }
    }
}
