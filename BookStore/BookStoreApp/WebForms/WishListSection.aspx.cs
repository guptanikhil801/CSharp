using BookStoreManager.ImplManager;
using BookStoreModal.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookStoreApp.WebForms
{
    public partial class WishListSection : System.Web.UI.Page
    {
        private WishListMgr WishListMgr = new WishListMgr();
        private AdminMgr mgr = new AdminMgr();

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<script language=javascript>$('#showbtn').click();</script>");
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
             "<div class='wlmaindiv mb-1'>" +
                "<img src = ' " + image + " ' width='45' height='55' />" +
                "<p class='text-primary mt10'>" + name + "</p>" +
                   "<div class='wlmaindiv mt10'>" +
                        "<p style = 'margin-right: 8px' > Author : </ p >" +
                        "<p class='text-dark'>" + author + "</p>" +
                   "</div>" +
                   "<div class='wlmaindiv mt10'>" +
                     "<img src = 'https://png.pngtree.com/png-clipart/20190614/original/pngtree-star-vector-icon-png-image_3725282.jpg' alt='' height='22' width='22' title='Rating' />" +
                       "<p class='ml-2'>" + rating + "</p>" +
                    "</div>" +
                    "<div class='wlmaindiv mt10'>" +
                      "<p>₹</p>" +
                       "<p class='text-dark ml-1'>" + price + "</p>" +
                    "</div>" +
                 "<img class='mt-2' src='Assets/addtocartbtn.png' alt='' onclick='AddToCartfun(" + bookid + ")' height='36' width='95' title='Add to cart' />" +
                 "<img class='mt-3' src='Assets/deleteforever.png' alt='' onclick='deletewishlistfun(" + wishlistid + ")' height='26' width='26' title='Delete From WishList' />" +
             "</div>";
                allwishlistsstring = allwishlistsstring + singlewishlist;
            }

            return allwishlistsstring;
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