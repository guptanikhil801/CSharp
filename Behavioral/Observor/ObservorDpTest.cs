using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Observor
{
   public class ObservorDpTest
    {
        public static void ObservorDpDriverMethod()
        {
            MakeMyTrip test = new MakeMyTrip();
            Customer c1 = new Customer("Nikhil", 9031378339);
            Customer c2 = new Customer("Gupta", 8603020007);
            Customer c3 = new Customer("Krishna", 9877045632);
            test.CustomerDatabase(c1);
            test.CustomerDatabase(c2);
            test.CustomerDatabase(c3);
            c1.OfferNotification();
            c1.PriceNotification();
            c2.OfferNotification();
            c2.PriceNotification();
            c3.OfferNotification();
            c3.PriceNotification();
        }
    }
}
