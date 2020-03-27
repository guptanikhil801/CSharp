using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice ");
            Console.WriteLine("AutoMapping  - am,         Mediator -    mb,        Observor  -  or,           visitor  -  vt");
            Console.WriteLine("FactoryPattern   -  fp,    prototype  -   pt,       Logger  -  lg");
            Console.WriteLine("AutoFac  -  af,            DependencyInjection(Through Property)   -  dip,   DependencyInjection(Through constructor)   -dic,");
            Console.WriteLine("DependencyInjection(Through method)  -  dim,            Adaptor  -   at,               Facade  - fd,             proxy -  px");
            string choice = Console.ReadLine().ToLower();
            Console.WriteLine();
            switch (choice)
            {
                case "am": Automapping.TestAutoMapping.DriverMethod();
                    break;
                case "mb": Behavioral.Mediator.ChatClient.DriverMethodMediator();
                    break;
                case "or": Behavioral.Observor.ObservorDpTest.ObservorDpDriverMethod();
                    break;
                case "vt": Behavioral.Visitor.ShoppingCartClient.DriverMethodVisitor();
                    break;
                case "fp": Creational.FactoryPattern.Runnerclass.DriverMethod();
                    break;
                case "pt": Creational.ProtoType.ProtoTypeRunnerClass.DriverMethod();
                    break;
                case "lg": Logger.LogTest.DriverMethod();
                    break;
                case "af": DependencyInjection.AutoFac.Client.DriverMethod();
                    break;
                case "dip": DependencyInjection.DIThroughProperty.Testpro.DriverMethod();
                    break;
                case "dic": DependencyInjection.DIUsingConstructor.TestClass.DriverMethod();
                    break;
                case "dim": DependencyInjection.DIUsingMethod.DITest.DriverMethod();
                    break;
                case "at": Structural.Adaptor.EcommerceCompany.DriverMethod();
                    break;
                case "fd": Structural.Facade.FacadeTest.FacadeDriverMethod();
                    break;
                case "px": Structural.Proxy.ProxyTestCustomer.DriverProxydp();
                    break;
                default: Console.WriteLine("Invalid choice");
                    break;

            }
        }
    }
}
