using BookStoreModal.Modals;
using System.Collections.Generic;

namespace BookStoreManager.InterfaceManager
{
    public interface ICartMgr
    {
        bool AddBookToCart(string Email, int BookId);
        bool UpdateCart(int CartId, int BookQuantity);
        bool DeleteBookFromCart(int CartId);
        bool DeleteCartRecord(string Email);
        IEnumerable<BookInCart> GetallBooksOfCart(string Email);
    }
}
