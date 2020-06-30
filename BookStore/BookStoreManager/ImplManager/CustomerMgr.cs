﻿using BookStoreModal.Modals;
using BookStoreRepository.ImplementationRepo;

namespace BookStoreManager.ImplManager
{
    public class CustomerMgr
    {
        private CustomerRepoImpl repo = new CustomerRepoImpl();

        public bool Login(LoginModal login)
        {
            return this.repo.Login(login);
        }

        public bool Registration(RegistrationModal modal)
        {
            return this.repo.Registration(modal);
        }

        public bool ResetPassword(string Email, string Password)
        {
            return ResetPassword(Email, Password);
        }
    }
}
