using BookStoreModal.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreRepository.InterfacesRepo
{
    public interface ICartRepo
    {
        bool AddBookCart(string Email, int BookId);
        bool UpdateCart(int CartId, int BookQuantity);
        bool DeleteBookFromCart(int CartId);
        IEnumerable<Cart> GetallBooksOfCart(string Email);
    }
}
