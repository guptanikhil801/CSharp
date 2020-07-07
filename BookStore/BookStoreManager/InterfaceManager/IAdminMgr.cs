using BookStoreModal.Modals;
using System.Collections.Generic;

namespace BookStoreManager.InterfaceManager
{
    public interface IAdminMgr
    {
        /// <summary>
        /// method for login.
        /// </summary>
        /// <param name="loginmodel">The Email, Password.</param>
        /// <returns>the user</returns>
        bool AdminLogin(string Email, string Password);

        /// <summary>
        /// Does the registration.
        /// </summary>
        /// <param name="modal">The Email, Password.</param>
        /// <returns>new user</returns>
        bool AdminRegistration(string Email, string Password);

        bool AddBookByAdmin(Book book);
        bool DeleteBookByAdmin(int BookId);
        IEnumerable<Book> GetAllBooks();
    }
}
