using BookStoreModal.Modals;
using System.Collections.Generic;

namespace BookStoreManager.InterfaceManager
{
    public interface IWishListMgr
    {
        bool AddBookToWishList(string Email, int BookId);
        bool DeleteBookFromWishList(int WishListId);
        IEnumerable<WishList> GetallWishLists(string Email);
    }
}
