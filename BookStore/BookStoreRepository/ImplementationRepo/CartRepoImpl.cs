using BookStoreModal.Modals;
using BookStoreRepository.InterfacesRepo;
using BookStoreRepository.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BookStoreRepository.ImplementationRepo
{
    public class CartRepoImpl : ICartRepo
    {
        private string connectionString = ConnectionString.CName;

        public bool AddBookCart(string Email, int BookId)
        {
            if (Email != null)
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmdn = new SqlCommand("spAddBookToCart", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmdn.Parameters.AddWithValue("@Email", Email);
                    cmdn.Parameters.AddWithValue("@BookId", BookId);
                    con.Open();
                    cmdn.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }

            return false;
        }

        public bool DeleteBookFromCart(int CartId)
        {
            if (CartId != 0)
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmdn = new SqlCommand("spDeleteBookFromCart", con);
                    cmdn.CommandType = CommandType.StoredProcedure;
                    cmdn.Parameters.AddWithValue("@CartId", CartId);
                    con.Open();
                    cmdn.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }

            return false;
        }

        public bool DeleteCartRecord(string Email)
        {
            if (Email != null)
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmdn = new SqlCommand("spDeleteCartRecord", con);
                    cmdn.CommandType = CommandType.StoredProcedure;
                    cmdn.Parameters.AddWithValue("@Email", Email);
                    con.Open();
                    cmdn.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }

            return false;
        }

        public IEnumerable<BookInCart> GetallBooksOfCart(string Email)
        {
            List<BookInCart> lstCart = new List<BookInCart>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetallCarts", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Email", Email);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    BookInCart cart = new BookInCart
                    {
                        BookId = Convert.ToInt32(rdr["BookId"]),
                        CartId = Convert.ToInt32(rdr["CartId"]),
                        Name = rdr["Name"].ToString(),
                        Author = rdr["Author"].ToString(),
                        BookQuantity = Convert.ToInt32(rdr["BookQuantity"]),
                        Price = Convert.ToDouble(rdr["Price"]),
                        Image = rdr["Image"].ToString()
                    };
                    lstCart.Add(cart);
                }
                con.Close();
            }

            return lstCart;
        }

        public bool UpdateCart(int CartId, int BookQuantity)
        {
            if (BookQuantity != 0 && CartId != 0)
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmdn = new SqlCommand("spUpdateCart", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmdn.Parameters.AddWithValue("@CartId", CartId);
                    cmdn.Parameters.AddWithValue("@BookQuantity", BookQuantity);
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
