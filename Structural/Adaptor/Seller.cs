namespace DesignPattern.Structural.Adaptor
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Seller
    {
        public List<string> GetListOfproducts()
        {
            List<string> products = new List<string>();
            products.Add("Television");
            products.Add("Mobile");
            products.Add("Shirts");
            products.Add("Spare parts");
            products.Add("sunglass");
            return products;
        }
    }
}
