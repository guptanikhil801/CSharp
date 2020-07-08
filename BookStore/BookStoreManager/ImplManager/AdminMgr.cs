using BookStoreManager.InterfaceManager;
using BookStoreModal.Modals;
using BookStoreRepository.ImplementationRepo;
using System.Collections.Generic;

namespace BookStoreManager.ImplManager
{
    public class AdminMgr : IAdminMgr
    {
        private AdminRepo repo = new AdminRepo();

        public bool AddBookByAdmin(Book book)
        {
            return repo.AddBookByAdmin(book);
        }

        public bool AdminLogin(string Email, string Password)
        {
            return repo.AdminLogin(Email, Password);
        }

        public bool AdminRegistration(string Email, string Password)
        {
            return repo.AdminRegistration(Email, Password);
        }

        public bool DeleteBookByAdmin(int BookId)
        {
            return repo.DeleteBookByAdmin(BookId);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return repo.GetAllBooks();
        }

        public bool UpdateBookByAdmin(Book book)
        {
            return repo.UpdateBookByAdmin(book);
        }
    }
}
