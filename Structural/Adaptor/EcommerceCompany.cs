namespace DesignPattern.Structural.Adaptor
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class EcommerceCompany
    {
        public static void DriverMethod()
        {
            IWebsite web = new SellerAdaptor();
            Console.WriteLine("Product List");
            foreach(string product in web.GetProducts())
            {
                Console.WriteLine(product);
            }
            Console.WriteLine();
        }
    }
}
