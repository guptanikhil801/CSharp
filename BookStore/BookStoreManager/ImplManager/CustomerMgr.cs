using BookStoreManager.InterfaceManager;
using BookStoreModal.Modals;
using BookStoreRepository.ImplementationRepo;

namespace BookStoreManager.ImplManager
{
    public class CustomerMgr : ICustomerMgr
    {
        private CustomerRepoImpl repo = new CustomerRepoImpl();

        public Customer CustomerDetails(string Email)
        {
            return repo.CustomerDeails(Email);
        }

        public bool ForgotPassword(string Email)
        {
            return this.repo.ForgotPassword(Email);
        }

        public bool Login(LoginModal login)
        {
            return repo.Login(login);
        }

        public bool Registration(RegistrationModal modal)
        {
            return repo.Registration(modal);
        }

        public bool ResetPassword(string Email, string Password)
        {
            return repo.ResetPassword(Email, Password);
        }



    }
}
