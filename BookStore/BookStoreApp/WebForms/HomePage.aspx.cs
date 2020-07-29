﻿using BookStoreManager.ImplManager;
using BookStoreModal.Modals;
using System;
using System.Collections.Generic;

namespace BookStoreApp.WebForms
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected AdminMgr mgr = new AdminMgr();
        protected WishListMgr WishListMgr = new WishListMgr();
        protected CartMgr CartMgr = new CartMgr();
        protected CustomerMgr customerManager = new CustomerMgr();

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
                    cartwishdiv = "<img src='Assets/addtocartbtn.png' alt='' onclick='AddToCartfun(" + bookid + ")'  title='Add to cart'  />" +
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
                    cartwishdiv = "<img src='Assets/addtocartbtn.png' alt='' onclick='AddToCartfun(" + bookid + ")' title='Add to cart'  />" +
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
                    cartwishdiv = "<img src='Assets/addtocartbtn.png' alt='' onclick='AddToCartfun(" + bookid + ")'  title='Add to cart'  />" +
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
                    cartwishdiv = "<img src='Assets/addtocartbtn.png' alt='' onclick='AddToCartfun(" + bookid + ")' title='Add to cart'  />" +
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
            paginationsection.InnerHtml = string.Empty;
            cartdiv.InnerHtml = string.Empty;
            // wildiv.InnerHtml = string.Empty;

        }

        protected void Add_To_WishList(object sender, EventArgs e)
        {
            string loginorregister =
"<div style='margin-top:100px'>" +
"<h1 class='text-primary text-center font-italic'>Login or Register to add book to wishlists</h1>" +
"<a href='Login.aspx'>" +
    "<p class='text-black-50  text-lg-center' style='font-size: 22px'>Login Here</p>" +
"</a>" +
"<a href = 'Registration.aspx'>" +
     "<p class='text-black-50  text-lg-center' style='font-size: 22px'>Register Here</p>" +
"</a>" +
"</div>";
            int bid = Convert.ToInt32(bookid.Value.ToString());
            string email = emailid.Value.ToString();
            if (email != null)
            {

                if (WishListMgr.AddBookToWishList(email, bid))
                {
                    ResponseLabel.Text = "Book added to wishlist";
                }
                else
                {
                    ResponseLabel.Text = "something went wrong";
                }
            }
            else
            {
                bookdisplaydiv.InnerHtml = loginorregister;
                paginationsection.InnerHtml = string.Empty;
            }
        }

        protected void wishlistdisplay(object sender, EventArgs e)
        {
            Server.Transfer("WishListSection.aspx");
            /*
            var email = emailid.Value.ToString();
            string loginorregister =
        "<div style='margin-top:100px'>" +
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
            else
            {
                bookdisplaydiv.InnerHtml = string.Empty;
                paginationsection.InnerHtml = string.Empty;
                MyCartDispDiv.InnerHtml = string.Empty;
                MYCartHeading.InnerText = string.Empty;
                string wishlists = wishliststring(email);
                yourwishlistsh1.InnerText = "Your WishLists";
                wishlistsection.InnerHtml = wishlists;

            }
            */
        }

        protected void Delete_Book_From_WishList(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(wishlistid.Value.ToString());
            if (WishListMgr.DeleteBookFromWishList(id))
            {
                ResponseLabel.Text = "Book Deleted From WishList";
            }

            else
            {
                ResponseLabel.Text = "Something went wrong ";
            }

        }

        protected void Add_To_Cart(object sender, EventArgs e)
        {
            string email = emailid.Value.ToString();
            int id = Convert.ToInt32(bookid.Value.ToString());
            string loginorregister =
    "<div style='margin-top:100px'>" +
      "<h1 class='text-primary text-center font-italic'>Login or Register to Add Book To Cart</h1>" +
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
            else if (CartMgr.AddBookToCart(email, id))
            {
                Response.Write("<script language=javascript> alert('Book Added to cart') ;</script>");
            }

            else
            {
                Response.Write("<script language=javascript> alert('Something went wrong');</script>");
            }

        }

        protected void Cartdisplay(object sender, EventArgs e)
        {
            var email = emailid.Value.ToString();
            string loginorregister =
        "<div style='margin-top:100px'>" +
            "<h1 class='text-primary text-center font-italic'>Login or Register to See your Cart</h1>" +
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
            else
            {
                bookdisplaydiv.InnerHtml = string.Empty;
                paginationsection.InnerHtml = string.Empty;
                // wildiv.InnerHtml = string.Empty;
                //wishlistsection.InnerHtml = string.Empty;
                // yourwishlistsh1.InnerText = string.Empty;
                string cartdata = AllCart(email);
                MYCartHeading.InnerText = "My Cart";
                MyCartDispDiv.InnerHtml = cartdata;
                TotalAmountCalc();
            }

        }

        protected void Cart_Delete(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cartid.Value.ToString());
            if (CartMgr.DeleteBookFromCart(id))
            {
                Response.Write("<script language=javascript>($('#cartbtn').click();</script>");
            }
            else
            {
                Response.Write("<script language=javascript> alert('Book cannot be removed');</script>");
            }
        }

        protected void Change_Quantity(object sender, EventArgs e)
        {
            int bid = Convert.ToInt32(bookid.Value.ToString());
            int id = Convert.ToInt32(cartid.Value.ToString());
            int bookquantity = Convert.ToInt32(changequantityinp.Text.ToString());
            if (CheckStock(bid, bookquantity))
            {
                if (CartMgr.UpdateCart(id, bookquantity))
                {
                    Response.Write("<script language=javascript>($('#cartbtn').click();</script>");
                }

                else
                {
                    Response.Write("<script language=javascript> alert('something went wrong');</script>");
                }
            }

            else
            {
                Response.Write("<script language=javascript> alert('That Much Stock Not Available, please order in less amount');</script>");
            }

        }

        protected void Go_To_Payment(object sender, EventArgs e)
        {
            Server.Transfer("PaymentPage.aspx");
        }


        //private string wishliststring(string email)
        //{

        //    IEnumerable<WishList> allwishlists = WishListMgr.GetallWishLists(email);
        //    List<WishList>.Enumerator allwishlistdata = (List<WishList>.Enumerator)allwishlists.GetEnumerator();
        //    var allwishlistsstring = "";
        //    while (allwishlistdata.MoveNext())
        //    {
        //        var wishlistid = allwishlistdata.Current.WishListId;
        //        var bookid = allwishlistdata.Current.BookId;
        //        var book = bookdetail(bookid);
        //        var name = book.Name;
        //        var author = book.Author;
        //        var price = book.Price;
        //        var rating = book.Rating;
        //        var image = book.Image;
        //        var singlewishlist =
        //     "<div class='wlmaindiv mb-1'>" +
        //        "<img src = ' " + image + " ' width='45' height='55' />" +
        //        "<p class='text-primary mt10'>" + name + "</p>" +
        //           "<div class='wlmaindiv mt10'>" +
        //                "<p style = 'margin-right: 8px' > Author : </ p >" +
        //                "<p class='text-dark'>" + author + "</p>" +
        //           "</div>" +
        //           "<div class='wlmaindiv mt10'>" +
        //             "<img src = 'https://png.pngtree.com/png-clipart/20190614/original/pngtree-star-vector-icon-png-image_3725282.jpg' alt='' height='22' width='22' title='Rating' />" +
        //               "<p class='ml-2'>" + rating + "</p>" +
        //            "</div>" +
        //            "<div class='wlmaindiv mt10'>" +
        //              "<p>₹</p>" +
        //               "<p class='text-dark ml-1'>" + price + "</p>" +
        //            "</div>" +
        //         "<img class='mt-2' src='Assets/addtocartbtn.png' alt='' height='36' width='95' title='Add to cart' />" +
        //         "<img class='mt-3' src='Assets/deleteforever.png' alt='' onclick='deletewishlistfun(" + wishlistid + ")' height='26' width='26' title='Delete From WishList' />" +
        //     "</div>";
        //        allwishlistsstring = allwishlistsstring + singlewishlist;
        //    }

        //    return allwishlistsstring;
        //}

        //private Book bookdetail(int bookid)
        //{
        //    Book book = new Book();
        //    IEnumerable<Book> allbooks = mgr.GetAllBooks();
        //    List<Book>.Enumerator allbookdata = (List<Book>.Enumerator)allbooks.GetEnumerator();
        //    while (allbookdata.MoveNext())
        //    {
        //        if (allbookdata.Current.BookId == bookid)
        //        {
        //            book.BookId = allbookdata.Current.BookId;
        //            book.Name = allbookdata.Current.Name;
        //            book.Author = allbookdata.Current.Author;
        //            book.Description = allbookdata.Current.Description;
        //            book.Price = allbookdata.Current.Price;
        //            book.Image = allbookdata.Current.Image;
        //            book.Rating = allbookdata.Current.Rating;
        //            book.AvailableStock = allbookdata.Current.AvailableStock;
        //            book.Review = allbookdata.Current.Review;
        //        }
        //    }

        //    return book;
        //}

        private string singlecart(BookInCart cart)
        {
            string cartstr =
        "<div class='card' style='display: flex; flex-direction: row;'>" +
        "<img src = '" + cart.Image + "' class='card-img-top cartbookimg' alt='' style='width: 72px; height: 90px; margin-left: 2%; margin-top: 10px;' />" +
              "<div style='display: flex; flex-direction: column'>" +
                     "<p class='text-primary cartbooknamest'>" + cart.Name + "</p>" +
                     "<p class='cartbookauthorst'>" + cart.Author + "</p>" +
                    "<div>" +
                        "<p class='cartrupeesignst'>₹</p>" +
                        "<p class='cartpricest'>" + cart.Price + "</p>" +
                        "<p class='cartquantitypst'>Quantity :</p>" +
                        "<p class='cartquantitydatast'>" + cart.BookQuantity + "</p>" +
                        "<p class='ChangeQuantitypst'>Change Quantity:</p>" +
                        "<input type = 'text' data-toggle='modal' data-target='#changequantitymodal'onclick='changequantityfun(" + cart.CartId + ",\"" + cart.BookId + "\")' class='cartinputst' />" +
                        "<img src = 'Assets/deleteforever.png' alt='' height='26' width='26' title='Delete From Cart' onclick='cartbookdelete( " + cart.CartId + ")' class='cartdeletest' />" +
                    "</div>" +
              "</div>" +
        "</div>";

            return cartstr;
        }

        private string AllCart(string email)
        {
            IEnumerable<BookInCart> allcarts = CartMgr.GetallBooksOfCart(email);
            List<BookInCart>.Enumerator allcartdata = (List<BookInCart>.Enumerator)allcarts.GetEnumerator();
            string allcartstr = "";
            while (allcartdata.MoveNext())
            {
                BookInCart cart = new BookInCart()
                {
                    Author = allcartdata.Current.Author,
                    BookId = allcartdata.Current.BookId,
                    BookQuantity = allcartdata.Current.BookQuantity,
                    CartId = allcartdata.Current.CartId,
                    Image = allcartdata.Current.Image,
                    Name = allcartdata.Current.Name,
                    Price = allcartdata.Current.Price

                };
                string singlecartstr = singlecart(cart);
                allcartstr = allcartstr + singlecartstr;
            }
            return allcartstr;
        }

        private void TotalAmountCalc()
        {
            string email = emailid.Value.ToString();
            double totalamountinrs = 0;
            if (email != null)
            {
                IEnumerable<BookInCart> allcarts = CartMgr.GetallBooksOfCart(email);
                List<BookInCart>.Enumerator allcartdata = (List<BookInCart>.Enumerator)allcarts.GetEnumerator();
                while (allcartdata.MoveNext())
                {
                    BookInCart cart = new BookInCart()
                    {
                        Author = allcartdata.Current.Author,
                        BookId = allcartdata.Current.BookId,
                        BookQuantity = allcartdata.Current.BookQuantity,
                        CartId = allcartdata.Current.CartId,
                        Image = allcartdata.Current.Image,
                        Name = allcartdata.Current.Name,
                        Price = allcartdata.Current.Price
                    };
                    double amount = allcartdata.Current.Price * allcartdata.Current.BookQuantity;
                    totalamountinrs = totalamountinrs + amount;

                }
                double amountwd = totalamountinrs + 50;
                Response.Write("<script language=javascript> function settotalamount(amount){ localStorage.setItem('totalamount',amount);} settotalamount('" + amountwd + "');</script>");
            }

        }

        private bool CheckStock(int bookid, int bq)
        {
            Book book = new Book();
            IEnumerable<Book> allbooks = mgr.GetAllBooks();
            List<Book>.Enumerator allbookdata = (List<Book>.Enumerator)allbooks.GetEnumerator();
            while (allbookdata.MoveNext())
            {
                if (allbookdata.Current.BookId == bookid)
                {
                    if (allbookdata.Current.AvailableStock < bq)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}