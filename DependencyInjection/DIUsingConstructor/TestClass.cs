
namespace DesignPattern.DependencyInjection.DIUsingConstructor
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class TestClass
    {
        public static void DriverMethod()
        {
            Service1 s1 = new Service1();     //// creating object of dependecy 
            Client c1 = new Client(s1);        /// passing dependency
            Service2 s2 = new Service2();
            Client c2 = new Client(s2);
        }
    }
}
