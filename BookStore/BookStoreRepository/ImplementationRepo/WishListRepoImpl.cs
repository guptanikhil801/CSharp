using BookStoreModal.Modals;
using BookStoreRepository.InterfacesRepo;
using BookStoreRepository.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BookStoreRepository.ImplementationRepo
{
    public class WishListRepoImpl : IWishListRepo
    {
        private string connectionString = ConnectionString.CName;
        public bool AddBookToWishList(string Email, int BookId)
        {
            if (Email != null)
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmdn = new SqlCommand("spAddBookToWishList", con);
                    cmdn.CommandType = CommandType.StoredProcedure;
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

        public bool DeleteBookFromWishList(int WishListId)
        {
            if (WishListId != 0)
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmdn = new SqlCommand("spDeleteBookFromWishList", con);
                    cmdn.CommandType = CommandType.StoredProcedure;
                    cmdn.Parameters.AddWithValue("@WishlistId", WishListId);
                    con.Open();
                    cmdn.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }

            return false;
        }

        public IEnumerable<WishList> GetallWishLists(string Email)
        {
            List<WishList> lstwl = new List<WishList>();
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllBooksFromWishLists", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", Email);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    WishList wl = new WishList();
                    wl.BookId = Convert.ToInt32(rdr["BookId"]);
                    wl.WishListId = Convert.ToInt32(rdr["WishlistId"]);
                    wl.Email = rdr["Email"].ToString();
                    lstwl.Add(wl);
                }
                con.Close();
            }

            return lstwl;
        }
    }
}
