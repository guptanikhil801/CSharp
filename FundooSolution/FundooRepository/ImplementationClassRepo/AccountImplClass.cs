namespace FundooRepository.ImplementationClassRepo
{
    using Common.UserModel;
    using Experimental.System.Messaging;
    using FundooRepository.Context;
    using FundooRepository.InterfaceRepo;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;

    public class AccountImplClass : IAccount
    {

        public User DoLogin(LoginModel loginmodel)
        {
            return new User { Email = loginmodel.Email, PasswordHash = loginmodel.Password };   
        }

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

        public bool ForgotPasswordUser(ForgotPassword forgotmodel, string url)
        {
            MessageQueue msgqueue;
            if(MessageQueue.Exists(@".\Private$\MyQueue"))
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
           
        }

        /* public ResetPassword ResetPasswordUser(ResetPassword resetmodel)
         {
             return new ResetPassword
             {
                 Email = resetmodel.Email,
                 NewPassword = resetmodel.NewPassword,
                 ConfirmPassword = resetmodel.ConfirmPassword,
                 Code = resetmodel.Code
             };
         }*/


    }
}
