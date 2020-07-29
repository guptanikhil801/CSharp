using BookStoreManager.InterfaceManager;
using BookStoreModal.Modals;
using BookStoreRepository.ImplementationRepo;
using System.Collections.Generic;

namespace BookStoreManager.ImplManager
{
    public class CartMgr : ICartMgr
    {
        private CartRepoImpl repo = new CartRepoImpl();
        public bool AddBookToCart(string Email, int BookId)
        {
            return repo.AddBookCart(Email, BookId);
        }

        public bool DeleteBookFromCart(int CartId)
        {
            return repo.DeleteBookFromCart(CartId);
        }

        public bool DeleteCartRecord(string Email)
        {
            return repo.DeleteCartRecord(Email);
        }

        public IEnumerable<BookInCart> GetallBooksOfCart(string Email)
        {
            return repo.GetallBooksOfCart(Email);
        }

        public bool UpdateCart(int CartId, int BookQuantity)
        {
            return repo.UpdateCart(CartId, BookQuantity);
        }
    }
}
