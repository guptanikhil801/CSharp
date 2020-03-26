using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DependencyInjection.DIUsingConstructor
{
    public class Service2 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service2 called");
        }
    }
}
