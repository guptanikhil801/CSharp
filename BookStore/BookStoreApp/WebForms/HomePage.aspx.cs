using BookStoreManager.ImplManager;
using BookStoreModal.Modals;
using System;
using System.Collections.Generic;

namespace BookStoreApp.WebForms
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected AdminMgr mgr = new AdminMgr();

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
                    cartwishdiv = "<button type='button' class='btn btn-danger btn-block'>Add to WishList</button>";
                    outofstockdisp = "<p class='card' style='margin-top: 30%; text-align: center; font-size: 24px; position: absolute; width: 100%' >out of stock</p>";
                }
                else
                {
                    cartwishdiv = "<button type='button' class='btn-sm btn-danger'>Add To Cart</button>" +
                 "<button type = 'button' class='btn-sm btn-danger'>WishList</button>";
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
                    cartwishdiv = "<button type='button' class='btn btn-danger btn-block'>Add to WishList</button>";
                    outofstockdisp = "<p class='card' style='margin-top: 30%; text-align: center; font-size: 24px; position: absolute; width: 100%' >out of stock</p>";
                }
                else
                {
                    cartwishdiv = "<button type='button' class='btn-sm btn-danger'>Add To Cart</button>" +
                 "<button type = 'button' class='btn-sm btn-danger'>WishList</button>";
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
                    cartwishdiv = "<button type='button' class='btn btn-danger btn-block'>Add to WishList</button>";
                    outofstockdisp = "<p class='card' style='margin-top: 30%; text-align: center; font-size: 24px; position: absolute; width: 100%' >out of stock</p>";
                }
                else
                {
                    cartwishdiv = "<button type='button' class='btn-sm btn-danger'>Add To Cart</button>" +
                 "<button type = 'button' class='btn-sm btn-danger'>WishList</button>";
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
    }
}