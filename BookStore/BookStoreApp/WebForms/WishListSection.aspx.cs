using BookStoreManager.ImplManager;
using BookStoreModal.Modals;
using System;
using System.Collections.Generic;

namespace BookStoreApp.WebForms
{
    public partial class WishListSection : System.Web.UI.Page
    {
        private WishListMgr WishListMgr = new WishListMgr();
        private AdminMgr mgr = new AdminMgr();
        private CartMgr cartmanager = new CartMgr();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Show_WishList(object sender, EventArgs e)
        {
            string wishlists = wishliststring();
            yourwishlistsh1.InnerText = "Your WishLists";
            wishlistsection.InnerHtml = wishlists;
        }

        private string wishliststring()
        {
            string email = emailhidden.Value.ToString();
            IEnumerable<WishList> allwishlists = WishListMgr.GetallWishLists(email);
            List<WishList>.Enumerator allwishlistdata = (List<WishList>.Enumerator)allwishlists.GetEnumerator();
            var allwishlistsstring = "";
            while (allwishlistdata.MoveNext())
            {
                var wishlistid = allwishlistdata.Current.WishListId;
                var bookid = allwishlistdata.Current.BookId;
                var book = bookdetail(bookid);
                var name = book.Name;
                var author = book.Author;
                var price = book.Price;
                var rating = book.Rating;
                var image = book.Image;
                var singlewishlist =
                        "<div class='card' style='width: 48%; margin-right: 1%'>" +
                                "<img src = '" + image + "' class='ml-2 mt-2' width='80' height='105' />" +
                                "<p class='text-primary' style='margin-top: -20%; margin-left: 18%'>" + name + "</p>" +
                                "<p class='authorp' style='margin-left: 18%'>By : </p>" +
                                "<p class='text-dark authorp' style='margin-left: 23%; margin-top: -34px'>" + author + "</p>" +
                                "<p style = 'margin-left: 18%; margin-top: -3%' >₹</p>" +
                                "<p class='text-dark' style='margin-left: 21%; margin-top: -7%'>" + price + "</p>" +
                                "<img src = 'https://png.pngtree.com/png-clipart/20190614/original/pngtree-star-vector-icon-png-image_3725282.jpg' alt='' height='22' width='22' style='margin-left: 80%; margin-top: -8%' />" +
                                "<p class='' style='margin-left: 87%; margin-top: -4%'>" + rating + "</p>" +
                                "<img class='' src='Assets/addtocartbtn.png' alt='' height='36' width='95' title='Add to cart' onclick='AddToCartfun(" + bookid + ")' style='margin-left: 20%; margin-top: -2%' />" +
                                "<img class='' src='Assets/deleteforever.png' alt='' height='26' width='26' title='Delete From WishList' onclick='deletewishlistfun(" + wishlistid + ")' style='margin-left: 80%; margin-top: -6%; margin-bottom: 3%' />" +
                         "</div>";

                allwishlistsstring = allwishlistsstring + singlewishlist;
            }

            return allwishlistsstring;
        }

        protected void Delete_Book_From_WishList(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(wishlistid.Value.ToString());
            WishListMgr.DeleteBookFromWishList(id);


        }

        protected void Add_To_Cart(object sender, EventArgs e)
        {
            string email = emailhidden.Value.ToString();
            int id = Convert.ToInt32(bookid.Value.ToString());
            cartmanager.AddBookToCart(email, id);
        }

        private Book bookdetail(int bookid)
        {
            Book book = new Book();
            IEnumerable<Book> allbooks = mgr.GetAllBooks();
            List<Book>.Enumerator allbookdata = (List<Book>.Enumerator)allbooks.GetEnumerator();
            while (allbookdata.MoveNext())
            {
                if (allbookdata.Current.BookId == bookid)
                {
                    book.BookId = allbookdata.Current.BookId;
                    book.Name = allbookdata.Current.Name;
                    book.Author = allbookdata.Current.Author;
                    book.Description = allbookdata.Current.Description;
                    book.Price = allbookdata.Current.Price;
                    book.Image = allbookdata.Current.Image;
                    book.Rating = allbookdata.Current.Rating;
                    book.AvailableStock = allbookdata.Current.AvailableStock;
                    book.Review = allbookdata.Current.Review;
                }
            }

            return book;
        }
    }
}