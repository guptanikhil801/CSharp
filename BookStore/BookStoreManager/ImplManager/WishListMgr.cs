using BookStoreManager.InterfaceManager;
using BookStoreModal.Modals;
using BookStoreRepository.ImplementationRepo;
using System.Collections.Generic;

namespace BookStoreManager.ImplManager
{
    public class WishListMgr : IWishListMgr
    {
        private WishListRepoImpl repo = new WishListRepoImpl();

        public bool AddBookToWishList(string Email, int BookId)
        {
            return repo.AddBookToWishList(Email, BookId);
        }

        public bool DeleteBookFromWishList(int WishListId)
        {
            return repo.DeleteBookFromWishList(WishListId);
        }

        public IEnumerable<WishList> GetallWishLists(string Email)
        {
            return repo.GetallWishLists(Email);
        }
    }
}
