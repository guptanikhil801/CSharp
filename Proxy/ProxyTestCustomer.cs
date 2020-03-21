namespace DesignPattern.Structural.Proxy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

   public class ProxyTestCustomer
    {
        
       public static void DriverProxydp()
        {
            ProxyCardClass test = new ProxyCardClass();
            Console.WriteLine("Enter Card Type");
            string ct = Console.ReadLine();
            test.StartTransaction(ct);
        }
    }
}
