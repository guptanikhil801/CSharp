using BookStoreManager.ImplManager;
using BookStoreModal.Modals;
using System;
using System.Collections.Generic;

namespace BookStoreApp.WebForms
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected AdminMgr mgr = new AdminMgr();
        protected WishListMgr WishListMgr = new WishListMgr();

        protected void Page_Load(object sender, EventArgs e)
        {
            IEnumerable<Book> allbooks = mgr.GetAllBooks();
            List<Book>.Enumerator allbookdata = (List<Book>.Enumerator)allbooks.GetEnumerator();
            string bdata = "";
            int i = 0;
            while (allbookdata.MoveNext())
            {
                i++;
                var bookid = allbookdata.Current.BookId;
                var name = allbookdata.Current.Name;
                var author = allbookdata.Current.Author;
                var description = allbookdata.Current.Description;
                var price = allbookdata.Current.Price;
                var image = allbookdata.Current.Image;
                var rating = allbookdata.Current.Rating;
                var availablestock = allbookdata.Current.AvailableStock;
                var review = allbookdata.Current.Review;

                string cartwishdiv = string.Empty;
                string outofstockdisp = string.Empty;
                if (availablestock == 0)
                {
                    cartwishdiv = "<img src='Assets/wishlistbtnlg.png' alt='' onclick='wlfun(" + bookid + ")' title='Add to wishlist'  />";
                    outofstockdisp = "<p class='card' style='margin-top: 30%; text-align: center; font-size: 24px; position: absolute; width: 100%' >out of stock</p>";
                }
                else
                {
                    cartwishdiv = "<img src='Assets/addtocartbtn.png' alt=''  title='Add to cart'  />" +
                 "<img src='Assets/wishlistbtnsm.png' alt='' onclick='wlfun(" + bookid + ")' title='Add to wishlist'  />";
                    outofstockdisp = string.Empty;
                }
                if (i > 0 && i < 13)
                {
                    string data =
         "<div class='card' title='" + description + "' style='width: 16rem; margin-right: 8px; margin-bottom: 15px; border-color: #dc3545'>" + outofstockdisp +
            "<img src='" + image + "' style='width: 125px; height: 155px; margin-left: 27%; margin-top: 10px;' class='card-img-top' alt='' />" +
            "<div class='card-body'>" +
                "<p class='text-primary'>" + name + "</p>" +
                 "<p class='authorp'>" + author + "</p>" +
               "<div class='ratingdiv'>" +
                  "<img src='https://png.pngtree.com/png-clipart/20190614/original/pngtree-star-vector-icon-png-image_3725282.jpg' alt='' height='22' width='22' title='Rating' />" +
                   "<p style='margin-left: 10px'>" + rating + "</p>" +
                "</div>" +
                "<div class='pricediv'>" +
                    "₹" +
                    "<p style='margin-left: 5px'>" + price + "</p>" +
                 "</div>" +
                 "<div class='cartwishlistdiv'>" +
                   cartwishdiv +
                 "</div>" +
             "</div>" +
         "</div>";
                    bdata = bdata + data;
                }
            }

            allbookrow.InnerHtml = bdata;
        }

        protected void Page_2_Btn(object sender, EventArgs e)
        {
            pagetitle.Text = "Page 2";
            IEnumerable<Book> allbooks = mgr.GetAllBooks();
            List<Book>.Enumerator allbookdata = (List<Book>.Enumerator)allbooks.GetEnumerator();
            string bdata = "";
            int i = 0;
            while (allbookdata.MoveNext())
            {
                i++;
                var bookid = allbookdata.Current.BookId;
                var name = allbookdata.Current.Name;
                var author = allbookdata.Current.Author;
                var description = allbookdata.Current.Description;
                var price = allbookdata.Current.Price;
                var image = allbookdata.Current.Image;
                var rating = allbookdata.Current.Rating;
                var availablestock = allbookdata.Current.AvailableStock;
                var review = allbookdata.Current.Review;

                string cartwishdiv = string.Empty;
                string outofstockdisp = string.Empty;
                if (availablestock == 0)
                {
                    cartwishdiv = "<img src='Assets/wishlistbtnlg.png' alt='' onclick='wlfun(" + bookid + ")' title='Add to wishlist'  />";
                    outofstockdisp = "<p class='card' style='margin-top: 30%; text-align: center; font-size: 24px; position: absolute; width: 100%' >out of stock</p>";
                }
                else
                {
                    cartwishdiv = "<img src='Assets/addtocartbtn.png' alt=''  title='Add to cart'  />" +
                 "<img src='Assets/wishlistbtnsm.png' alt='' onclick='wlfun(" + bookid + ")' title='Add to wishlist'  />";
                    outofstockdisp = string.Empty;
                }
                if (i > 12 && i < 25)
                {
                    string data =
         "<div class='card' title='" + description + "' style='width: 16rem; margin-right: 8px; margin-bottom: 15px; border-color: #dc3545'>" + outofstockdisp +
            "<img src='" + image + "' style='width: 125px; height: 155px; margin-left: 27%; margin-top: 10px;' class='card-img-top' alt='' />" +
            "<div class='card-body'>" +
                "<p class='text-primary'>" + name + "</p>" +
                 "<p class='authorp'>" + author + "</p>" +
               "<div class='ratingdiv'>" +
                  "<img src='https://png.pngtree.com/png-clipart/20190614/original/pngtree-star-vector-icon-png-image_3725282.jpg' alt='' height='22' width='22' title='Rating' />" +
                   "<p style='margin-left: 10px'>" + rating + "</p>" +
                "</div>" +
                "<div class='pricediv'>" +
                    "₹" +
                    "<p style='margin-left: 5px'>" + price + "</p>" +
                 "</div>" +
                 "<div class='cartwishlistdiv'>" +
                   cartwishdiv +
                 "</div>" +
             "</div>" +
         "</div>";
                    bdata = bdata + data;
                }
            }

            allbookrow.InnerHtml = bdata;
        }

        protected void Page_3_Btn(object sender, EventArgs e)
        {
            pagetitle.Text = "Page 3";
            IEnumerable<Book> allbooks = mgr.GetAllBooks();
            List<Book>.Enumerator allbookdata = (List<Book>.Enumerator)allbooks.GetEnumerator();
            string bdata = "";
            int i = 0;
            while (allbookdata.MoveNext())
            {
                i++;
                var bookid = allbookdata.Current.BookId;
                var name = allbookdata.Current.Name;
                var author = allbookdata.Current.Author;
                var description = allbookdata.Current.Description;
                var price = allbookdata.Current.Price;
                var image = allbookdata.Current.Image;
                var rating = allbookdata.Current.Rating;
                var availablestock = allbookdata.Current.AvailableStock;
                var review = allbookdata.Current.Review;

                string cartwishdiv = string.Empty;
                string outofstockdisp = string.Empty;
                if (availablestock == 0)
                {
                    cartwishdiv = "<img src='Assets/wishlistbtnlg.png' alt='' onclick='wlfun(" + bookid + ")' title='Add to wishlist'  />";
                    outofstockdisp = "<p class='card' style='margin-top: 30%; text-align: center; font-size: 24px; position: absolute; width: 100%' >out of stock</p>";
                }
                else
                {
                    cartwishdiv = "<img src='Assets/addtocartbtn.png' alt=''  title='Add to cart'  />" +
                 "<img src='Assets/wishlistbtnsm.png' alt='' onclick='wlfun(" + bookid + ")' title='Add to wishlist'  />";
                    outofstockdisp = string.Empty;
                }
                if (i > 24)
                {
                    string data =
         "<div class='card' title='" + description + "' style='width: 16rem; margin-right: 8px; margin-bottom: 15px; border-color: #dc3545'>" + outofstockdisp +
            "<img src='" + image + "' style='width: 125px; height: 155px; margin-left: 27%; margin-top: 10px;' class='card-img-top' alt='' />" +
            "<div class='card-body'>" +
                "<p class='text-primary'>" + name + "</p>" +
                 "<p class='authorp'>" + author + "</p>" +
               "<div class='ratingdiv'>" +
                  "<img src='https://png.pngtree.com/png-clipart/20190614/original/pngtree-star-vector-icon-png-image_3725282.jpg' alt='' height='22' width='22' title='Rating' />" +
                   "<p style='margin-left: 10px'>" + rating + "</p>" +
                "</div>" +
                "<div class='pricediv'>" +
                    "₹" +
                    "<p style='margin-left: 5px'>" + price + "</p>" +
                 "</div>" +
                 "<div class='cartwishlistdiv'>" +
                   cartwishdiv +
                 "</div>" +
             "</div>" +
         "</div>";
                    bdata = bdata + data;
                }
            }

            allbookrow.InnerHtml = bdata;
        }

        protected void Search_Button_Click(object sender, EventArgs e)
        {
            string si = searchbar.Text.ToString();
            pagetitle.Text = "Search Result";
            IEnumerable<Book> allbooks = mgr.GetAllBooks();
            List<Book>.Enumerator allbookdata = (List<Book>.Enumerator)allbooks.GetEnumerator();
            string bdata = "";
            while (allbookdata.MoveNext())
            {
                var bookid = allbookdata.Current.BookId;
                var name = allbookdata.Current.Name;
                var author = allbookdata.Current.Author;
                var description = allbookdata.Current.Description;
                var price = allbookdata.Current.Price;
                var image = allbookdata.Current.Image;
                var rating = allbookdata.Current.Rating;
                var availablestock = allbookdata.Current.AvailableStock;
                var review = allbookdata.Current.Review;

                string cartwishdiv = string.Empty;
                string outofstockdisp = string.Empty;
                if (availablestock == 0)
                {
                    cartwishdiv = "<img src='Assets/wishlistbtnlg.png' alt='' onclick='wlfun(" + bookid + ")' title='Add to wishlist'  />";
                    outofstockdisp = "<p class='card' style='margin-top: 30%; text-align: center; font-size: 24px; position: absolute; width: 100%' >out of stock</p>";
                }
                else
                {
                    cartwishdiv = "<img src='Assets/addtocartbtn.png' alt=''  title='Add to cart'  />" +
                 "<img src='Assets/wishlistbtnsm.png' alt='' onclick='wlfun(" + bookid + ")' title='Add to wishlist'  />";
                    outofstockdisp = string.Empty;
                }
                if (name.Contains(si) || author.Contains(si))
                {
                    string data =
         "<div class='card' title='" + description + "' style='width: 16rem; margin-right: 8px; margin-bottom: 15px; border-color: #dc3545'>" + outofstockdisp +
            "<img src='" + image + "' style='width: 125px; height: 155px; margin-left: 27%; margin-top: 10px;' class='card-img-top' alt='' />" +
            "<div class='card-body'>" +
                "<p class='text-primary'>" + name + "</p>" +
                 "<p class='authorp'>" + author + "</p>" +
               "<div class='ratingdiv'>" +
                  "<img src='https://png.pngtree.com/png-clipart/20190614/original/pngtree-star-vector-icon-png-image_3725282.jpg' alt='' height='22' width='22' title='Rating' />" +
                   "<p style='margin-left: 10px'>" + rating + "</p>" +
                "</div>" +
                "<div class='pricediv'>" +
                    "₹" +
                    "<p style='margin-left: 5px'>" + price + "</p>" +
                 "</div>" +
                 "<div class='cartwishlistdiv'>" +
                   cartwishdiv +
                 "</div>" +
             "</div>" +
         "</div>";
                    bdata = bdata + data;
                }
            }

            allbookrow.InnerHtml = bdata;
        }

        protected void Add_To_WishList(object sender, EventArgs e)
        {
            int bid = Convert.ToInt32(bookid.Value.ToString());
            string email = emailid.Value.ToString();
            if (WishListMgr.AddBookToWishList(email, bid))
            {
                ResponseLabel.Text = "Book added to wishlist";
            }
            else
            {
                ResponseLabel.Text = "something went wrong";
            }
        }

        protected void wishlistdisplay(object sender, EventArgs e)
        {
            var email = emailid.Value.ToString();
            string loginorregister =
        "<div style='margin-top:60px'>" +
            "<h1 class='text-primary text-center font-italic'>Login or Register to See your wishlists</h1>" +
            "<a href='Login.aspx'>" +
                "<p class='text-black-50  text-lg-center' style='font-size: 22px'>Login Here</p>" +
            "</a>" +
            "<a href = 'Registration.aspx'>" +
                 "<p class='text-black-50  text-lg-center' style='font-size: 22px'>Register Here</p>" +
            "</a>" +
        "</div>";

            if (email == null || email == string.Empty)
            {
                bookdisplaydiv.InnerHtml = loginorregister;
                paginationsection.InnerHtml = string.Empty;
            }
        }
    }
}