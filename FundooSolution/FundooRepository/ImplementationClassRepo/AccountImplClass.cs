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
    using Common.UserModel;
    using Experimental.System.Messaging;
    using FundooRepository.Context;
    using FundooRepository.InterfaceRepo;
    using Microsoft.AspNetCore.Identity;

    /// <summary>
    /// implementation class of IAccount
    /// </summary>
    /// <seealso cref="FundooRepository.InterfaceRepo.IAccount" />
    public class AccountImplClass : IAccount
    {
        private readonly UserDBContext dbcontext;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountImplClass"/> class.
        /// </summary>
        /// <param name="dbcontext">The dbcontext.</param>
        public AccountImplClass(UserDBContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        /// <summary>
        /// implementation method for login.
        /// </summary>
        /// <param name="loginmodel">The loginmodel.</param>
        /// <returns>
        /// the user
        /// </returns>
        public User DoLogin(LoginModel loginmodel)
        {
            var result = this.dbcontext.Users.FirstOrDefault(o => o.Email == loginmodel.Email);
            if (result != null)
            {
                return result;
            }

            return null;
        }

        /// <summary>
        /// Does the registration.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>
        /// new user
        /// </returns>
        public User DoRegistration(RegistrationModel model)
        {
            User createuser = new User
            {
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber
            };
            return createuser;
        }

        /// <summary>
        /// implementation method for Forgot password
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="url">The URL.</param>
        /// <returns>
        /// boolean value
        /// </returns>
        public bool ForgotPasswordUser(string email, string url)
        {
            //// for sending message in MSMQ
            try
            {
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
                message.Label = "url link";
                msgqueue.Send(message);

                //// for reading message from MSMQ
                MessageQueue receivequeue = new MessageQueue(@".\Private$\MyQueue");
                Message receivemsg = receivequeue.Receive();
                receivemsg.Formatter = new BinaryMessageFormatter();

                string linktobesend = receivemsg.Body.ToString();

                //// for sending a link to user from SMTP server
                MailMessage mailmessage = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                mailmessage.From = new MailAddress("guptanikhil20007@gmail.com");
                mailmessage.To.Add(new MailAddress(email));
                mailmessage.Subject = "Link to reset your passord";
                mailmessage.IsBodyHtml = false;
                mailmessage.Body = linktobesend;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("guptanikhil20007@gmail.com", "nikhil20007");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(mailmessage);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
