
namespace DesignPattern.DependencyInjection.AutoFac
{
    using Autofac;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Client
    {
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
