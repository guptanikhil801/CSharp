using BookStoreModal.Modals;
using System.Collections.Generic;

namespace BookStoreRepository.InterfacesRepo
{
    public interface ICartRepo
    {
        bool AddBookCart(string Email, int BookId);
        bool UpdateCart(int CartId, int BookQuantity);
        bool DeleteBookFromCart(int CartId);
        bool DeleteCartRecord(string Email);
        IEnumerable<BookInCart> GetallBooksOfCart(string Email);
    }
}
