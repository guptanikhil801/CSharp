using BookStoreManager.ImplManager;
using BookStoreModal.Modals;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreApp.WebForms
{
    public partial class AdminDashBoard : System.Web.UI.Page
    {
        protected AdminMgr mgr = new AdminMgr();

        protected void Page_Load(object sender, EventArgs e)
        {
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

                string data =
     "<div class='card' title='" + description + "' style='width: 16rem; margin-right: 8px; margin-bottom: 15px; border-color: #dc3545'>" +
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
             "<div class='availablestockdiv'>" +
                "<p style='margin-right: 5px'>AvailableStock</p>" +
                 "<p>" + availablestock + "</p>" +
             "</div>" +
             "<div class='updatedeletediv'>" +
                "<img src='Assets/updatebtnimg.png' alt=''  title='Update This Book' onclick='updatefun(" + bookid + ")' />" +
                 "<img src='Assets/deleteforever.png' alt='' height='32' width='32' title='Delete This Book' onclick='deletefun(" + bookid + ")' />" +
             "</div>" +
         "</div>" +
     "</div>";
                bdata = bdata + data;
            }

            allbookrow.InnerHtml = bdata;
        }

        protected void Add_Book_By_Admin_Btn(object sender, EventArgs e)
        {

            Book book = new Book
            {
                Name = AddBookNameTextBox.Text.ToString(),
                Author = AddBookAuthorTextBox.Text.ToString(),
                Description = AddBookDescriptionTextBox.Text.ToString(),
                Image = AddBookImageTextBox.Text.ToString(),
                Price = Convert.ToDouble(AddBookPriceTextBox.Text.ToString()),
                AvailableStock = Convert.ToInt32(AddBookAvailableStockTextBox.Text.ToString()),
                Rating = Convert.ToDouble(AddBookRatingTextBox.Text.ToString())
            };
            if (this.mgr.AddBookByAdmin(book))
            {
                ResponseLabel.Text = "Book Added Successfully";
            }

            else
            {
                ResponseLabel.Text = "Something went wrong ";
            }

        }

        protected void Update_Book_By_Admin_Btn(object sender, EventArgs e)
        {

            Book book = new Book
            {
                BookId = Convert.ToInt32(bookid.Value.ToString()),
                Name = AddBookNameTextBox.Text.ToString(),
                Author = AddBookAuthorTextBox.Text.ToString(),
                Description = AddBookDescriptionTextBox.Text.ToString(),
                Image = AddBookImageTextBox.Text.ToString(),
                Price = Convert.ToDouble(AddBookPriceTextBox.Text.ToString()),
                AvailableStock = Convert.ToInt32(AddBookAvailableStockTextBox.Text.ToString()),
                Rating = Convert.ToDouble(AddBookRatingTextBox.Text.ToString())
            };
            if (this.mgr.UpdateBookByAdmin(book))
            {
                ResponseLabel.Text = "Book Updated Successfully";
            }

            else
            {
                ResponseLabel.Text = "Something went wrong ";
            }

        }

        protected void Delete_Book_By_Admin(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(bookid.Value.ToString());
            if (this.mgr.DeleteBookByAdmin(id))
            {
                ResponseLabel.Text = "Book Deleted Successfully";
            }

            else
            {
                ResponseLabel.Text = "Something went wrong ";
            }

        }

    }
}