using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DependencyInjection.DIUsingConstructor
{
    public class Service1 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service1 called");
        }
    }
}
