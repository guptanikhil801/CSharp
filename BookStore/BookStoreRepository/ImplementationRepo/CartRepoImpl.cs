using BookStoreModal.Modals;
using BookStoreRepository.InterfacesRepo;
using BookStoreRepository.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IEnumerable<Cart> GetallBooksOfCart(string Email)
        {
            List<Cart> lstCart = new List<Cart>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllBooksFromCarts", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Email", Email);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Cart cart = new Cart();
                    cart.BookId = Convert.ToInt32(rdr["BookId"]);
                    cart.CartId = Convert.ToInt32(rdr["CartId"]);
                    cart.Email = rdr["Email"].ToString();
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
