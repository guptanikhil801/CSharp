using BookStoreModal.Modals;
using System.Collections.Generic;

namespace BookStoreRepository.InterfacesRepo
{
    public interface IAdminRepo
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
        /// <param name="modal">The Email, Password</param>
        /// <returns>new user</returns>
        bool AdminRegistration(string Email, string Password);

        /// <summary>
        /// Adds the book by admin.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns></returns>
        bool AddBookByAdmin(Book book);

        /// <summary>
        /// Deletes a book
        /// </summary>
        /// <param name="BookId"></param>
        /// <returns></returns>
        bool DeleteBookByAdmin(int BookId);

        IEnumerable<Book> GetAllBooks();

        bool UpdateBookByAdmin(Book book);

        bool UpdateAvailableStock(int BookId, int PurchaseQuantity);
    }
}
