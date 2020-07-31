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

        /// <summary>
        /// Adds the book by admin.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns></returns>
        bool AddBookByAdmin(Book book);

        /// <summary>
        /// Deletes the book by admin.
        /// </summary>
        /// <param name="BookId">The book identifier.</param>
        /// <returns></returns>
        bool DeleteBookByAdmin(int BookId);

        bool UpdateBookByAdmin(Book book);
        /// <summary>
        /// Gets all books.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Book> GetAllBooks();

        bool UpdateAvailableStock(int BookId, int PurchaseQuantity);
    }
}
