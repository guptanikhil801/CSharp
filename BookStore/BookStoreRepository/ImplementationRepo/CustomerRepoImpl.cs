using BookStoreModal.Modals;
using BookStoreRepository.InterfacesRepo;
using BookStoreRepository.Utility;
using System.Data;
using System.Data.SqlClient;

namespace BookStoreRepository.ImplementationRepo
{
    public class CustomerRepoImpl : ICustomerRepo
    {
        private string connectionString = ConnectionString.CName;

        public bool Login(LoginModal login)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("spLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", login.Email);
                cmd.Parameters.AddWithValue("@Password", login.Password);
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

        public bool Registration(RegistrationModal modal)
        {
            if (modal.Email != null && modal.Password != null)
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spAddCustomer", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PhoneNumber", modal.PhoneNumber);
                    cmd.Parameters.AddWithValue("@FirstName", modal.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", modal.LastName);
                    cmd.Parameters.AddWithValue("@Email", modal.Email);
                    cmd.Parameters.AddWithValue("@Password", modal.Password);
                    cmd.Parameters.AddWithValue("@ProfilePicture", "");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }
            return false;
        }

        public bool ResetPassword(string Email, string Password)
        {
            if (Email != null && Password != null)
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spResetPassword", con);
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
    }
}
