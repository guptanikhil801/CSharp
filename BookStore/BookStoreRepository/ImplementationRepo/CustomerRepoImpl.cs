using BookStoreModal.Modals;
using BookStoreRepository.InterfacesRepo;
using BookStoreRepository.Utility;
using Experimental.System.Messaging;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace BookStoreRepository.ImplementationRepo
{
    public class CustomerRepoImpl : ICustomerRepo
    {
        private string connectionString = ConnectionString.CName;

        public bool ForgotPassword(string Email)
        {
            string url = "https://localhost:44334/WebForms/ResetPassword.aspx";
            //// for sending message in MSMQ
            MessageQueue msgqueue;
            if (MessageQueue.Exists(@".\Private$\MyQueue"))
            {
                msgqueue = new MessageQueue(@".\Private$\MyQueue");
            }
            else
            {
                msgqueue = MessageQueue.Create(@".\Private$\MyQueue");
            }

            Message message = new Message();

            message.Formatter = new BinaryMessageFormatter();
            message.Body = url;
            msgqueue.Label = "url link";
            msgqueue.Send(message);

            //// for reading message from MSMQ
            var receivequeue = new MessageQueue(@".\Private$\MyQueue");
            var receivemsg = receivequeue.Receive();
            receivemsg.Formatter = new BinaryMessageFormatter();

            string linktobesend = receivemsg.Body.ToString();
            if (Sendmail(Email, linktobesend))
            {
                return true;
            }
            return false;
        }

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

        private bool Sendmail(string email, string message)
        {

            MailMessage mailmessage = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            mailmessage.From = new MailAddress("guptanikhil20007@gmail.com");
            mailmessage.To.Add(new MailAddress(email));
            mailmessage.Subject = "Link to reset your passord for BookStore Account";
            mailmessage.IsBodyHtml = true;
            mailmessage.Body = message;
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new NetworkCredential("guptanikhil20007@gmail.com", "nikhil20007");
            smtp.EnableSsl = true;
            smtp.Send(mailmessage);
            return true;
        }
    }
}
