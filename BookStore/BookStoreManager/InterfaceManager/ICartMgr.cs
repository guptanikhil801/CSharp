using BookStoreModal.Modals;
using System.Collections.Generic;

namespace BookStoreManager.InterfaceManager
{
    public interface ICartMgr
    {
        bool AddBookToCart(string Email, int BookId);
        bool UpdateCart(int CartId, int BookQuantity);
        bool DeleteBookFromCart(int CartId);
        IEnumerable<BookInCart> GetallBooksOfCart(string Email);
    }
}
