namespace DesignPattern.Structural.Adaptor
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class SellerAdaptor : Website
    {
        public List<string> GetProducts()
        {
            Seller sp = new Seller();
            return sp.GetListOfproducts();
        }
    }
}
