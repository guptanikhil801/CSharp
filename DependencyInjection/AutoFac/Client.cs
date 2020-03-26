// -----------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------------------------------------
namespace DesignPattern.DependencyInjection.AutoFac
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Autofac;

    /// <summary>
    /// main class of DI Through Autofac
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Driver method.
        /// </summary>
        public static void DriverMethod()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MessageService>().As<IMessage>();
            builder.RegisterType<EmailService>().As<IEmail>();
            var container = builder.Build();
            container.Resolve<IMessage>().Execute();
            container.Resolve<IEmail>().Execute();
        }
    }
}
