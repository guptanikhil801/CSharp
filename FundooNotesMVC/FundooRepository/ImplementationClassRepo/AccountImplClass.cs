// -------------------------------------------------------------------------------------------------------
// <copyright file="AccountImplClass.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------

namespace FundooRepository.ImplementationClassRepo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Mail;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using System.Data.SqlClient;
    using Common.UserModel;
    using FundooRepository.Utility;

    // using Experimental.System.Messaging;
    //  using FundooRepository.Context;
    using FundooRepository.InterfaceRepo;
    using Experimental.System.Messaging;

    /// <summary>
    /// implementation class of IAccount
    /// </summary>
    /// <seealso cref="FundooRepository.InterfaceRepo.IAccount" />
    public class AccountImplClass : IAccount
    {
        private string connectionString = ConnectionString.CName;

        /// <summary>
        /// implementation method for login.
        /// </summary>
        /// <param name="loginmodel">The loginmodel.</param>
        /// <returns>
        /// the user
        /// </returns>
        public bool Login(LoginModel loginmodel)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("spLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", loginmodel.Email);
                cmd.Parameters.AddWithValue("@Password", loginmodel.Password);
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
        /// <summary>
        /// Does the registration.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>
        /// new user
        /// </returns>
        public void Registration(RegistrationModel model)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
                cmd.Parameters.AddWithValue("@LastName", model.LastName);
                cmd.Parameters.AddWithValue("@Email", model.Email);
                cmd.Parameters.AddWithValue("@Password", model.Password);
                cmd.Parameters.AddWithValue("@ProfilePicture", "hhfghfgy");
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void ResetPassword(ResetPasswordModel model)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("spResetPassword", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", model.Email);
                cmd.Parameters.AddWithValue("@Password", model.Password);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        /// <summary>
        /// implementation method for Forgot password
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="url">The URL.</param>
        /// <returns>
        /// boolean value
        /// </returns>
         public bool ForgotPasswordUser(ForgotPassword model, string url)
          {
            string email = model.Email;
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
              if (Sendmail(email, linktobesend))
              {
                  return true;
              }
              return false;
          }

          private bool Sendmail(string email, string message)
          {
           
              MailMessage mailmessage = new MailMessage();
              SmtpClient smtp = new SmtpClient();
              mailmessage.From = new MailAddress("guptanikhil20007@gmail.com");
              mailmessage.To.Add(new MailAddress(email));
              mailmessage.Subject = "Link to reset your passord for FundooNotes MVC Application";
              mailmessage.IsBodyHtml = true;
              mailmessage.Body = message;
              smtp.Port = 587;
              smtp.Host = "smtp.gmail.com";
              smtp.EnableSsl = true;
              smtp.Credentials = new NetworkCredential("guptanikhil20007@gmail.com", "nikhil20007");
              smtp.Send(mailmessage);
              return true;
          }




    }
}
