using BookStoreModal.Modals;

namespace BookStoreManager.InterfaceManager
{
    public interface ICustomerMgr
    {
        /// <summary>
        /// method for login.
        /// </summary>
        /// <param name="loginmodel">The loginmodel.</param>
        /// <returns>the user</returns>
        bool Login(LoginModal login);

        /// <summary>
        /// Does the registration.
        /// </summary>
        /// <param name="modal">The modal.</param>
        /// <returns>new user</returns>
        bool Registration(RegistrationModal modal);

        bool ResetPassword(string Email, string Password);
    }
}
