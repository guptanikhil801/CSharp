using BookStoreModal.Modals;
using System.Collections.Generic;

namespace BookStoreRepository.InterfacesRepo
{
    public interface IWishListRepo
    {
        bool AddBookToWishList(string Email, int BookId);
        bool DeleteBookFromWishList(int WishListId);
        IEnumerable<WishList> GetallWishLists(string Email);
    }
}
