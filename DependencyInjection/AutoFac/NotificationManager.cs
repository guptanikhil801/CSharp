// -----------------------------------------------------------------------------------------------------------
// <copyright file="NotificationManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------------------------------------
namespace DesignPattern.DependencyInjection.AutoFac
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class has dependency on IMobile and IEmail
    /// </summary>
    public class NotificationManager
    {
        private IMessage msgobj = null;
        private IEmail mailobj = null;

        /// <summary>
        /// Injecting msgobj using constructor.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public NotificationManager(IMessage msg)
        {
            this.msgobj = msg;
        }

        /// <summary>
        /// Injecting mailobj using property.
        /// </summary>
        /// <value>
        /// The set email.
        /// </value>
        public IEmail SetEmail
        {
            set
            {
                this.mailobj = value;
            }

        }
        public void SendNotification()
        {
            this.msgobj.Execute();
            this.mailobj.Execute();
        }
    }
}
