using BookStoreModal.Modals;
using BookStoreRepository.InterfacesRepo;
using BookStoreRepository.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BookStoreRepository.ImplementationRepo
{
    public class AdminRepo : IAdminRepo
    {
        private string connectionString = ConnectionString.CName;

        public bool AddBookByAdmin(Book book)
        {
            if (book.Description != null && book.Author != null && book.Name != null)
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmdn = new SqlCommand("spAddBookByAdmin", con);
                    cmdn.CommandType = CommandType.StoredProcedure;
                    cmdn.Parameters.AddWithValue("@Name", book.Name);
                    cmdn.Parameters.AddWithValue("@Author", book.Author);
                    cmdn.Parameters.AddWithValue("@Description", book.Description);
                    cmdn.Parameters.AddWithValue("@Image", book.Image);
                    cmdn.Parameters.AddWithValue("@Price", book.Price);
                    cmdn.Parameters.AddWithValue("@AvailableStock", book.AvailableStock);
                    cmdn.Parameters.AddWithValue("@Rating", book.Rating);
                    con.Open();
                    cmdn.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }

            return false;
        }
        public bool AdminLogin(string Email, string Password)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAdminLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Password", Password);
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    if (sdr.HasRows)
                    {
                        con.Close();
                        return true;
                    }
                }
                con.Close();
                return false;
            }
        }

        public bool AdminRegistration(string Email, string Password)
        {
            if (Email != null && Password != null)
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spAddAdmin", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }
            return false;
        }

        public bool DeleteBookByAdmin(int BookId)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmdn = new SqlCommand("spDeleteBookByAdmin", con);
                cmdn.CommandType = CommandType.StoredProcedure;
                cmdn.Parameters.AddWithValue("@BookId", BookId);
                con.Open();
                cmdn.ExecuteNonQuery();
                con.Close();
            }

            return true;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            List<Book> lstBook = new List<Book>();
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllBooks", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Book Book = new Book();
                    Book.BookId = Convert.ToInt32(rdr["BookId"]);
                    Book.Name = rdr["Name"].ToString();
                    Book.Author = rdr["Author"].ToString();
                    Book.Description = rdr["Description"].ToString();
                    Book.Image = rdr["Image"].ToString();
                    Book.Price = Convert.ToDouble(rdr["Price"]);
                    Book.AvailableStock = Convert.ToInt32(rdr["AvailableStock"]);
                    Book.Rating = Convert.ToDouble(rdr["Rating"]);
                    Book.Review = rdr["Review"].ToString();
                    lstBook.Add(Book);
                }
                con.Close();
            }

            return lstBook;
        }

        public bool UpdateAvailableStock(int BookId, int PurchaseQuantity)
        {
            if (BookId > 0)
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmdn = new SqlCommand("spUpdateAvailableStock", con);
                    cmdn.CommandType = CommandType.StoredProcedure;
                    cmdn.Parameters.AddWithValue("@BookId", BookId);
                    cmdn.Parameters.AddWithValue("@PurchaseQuantity", PurchaseQuantity);
                    con.Open();
                    cmdn.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }

            return false;
        }

        public bool UpdateBookByAdmin(Book book)
        {
            if (book.Description != null && book.Author != null && book.Name != null && book.Description != null)
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmdn = new SqlCommand("spUpdateBookByAdmin", con);
                    cmdn.CommandType = CommandType.StoredProcedure;
                    cmdn.Parameters.AddWithValue("@BookId", book.BookId);
                    cmdn.Parameters.AddWithValue("@Name", book.Name);
                    cmdn.Parameters.AddWithValue("@Author", book.Author);
                    cmdn.Parameters.AddWithValue("@Description", book.Description);
                    cmdn.Parameters.AddWithValue("@Image", book.Image);
                    cmdn.Parameters.AddWithValue("@Price", book.Price);
                    cmdn.Parameters.AddWithValue("@AvailableStock", book.AvailableStock);
                    cmdn.Parameters.AddWithValue("@Rating", book.Rating);
                    con.Open();
                    cmdn.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }

            return false;
        }
    }
}
