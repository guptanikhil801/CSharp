// -------------------------------------------------------------------------------------------------------
// <copyright file="Customer.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace DesignPattern.Behavioral.Observor
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class MakeMyTrip:Subject
    {
        private List<Customer> customer = new List<Customer>();

        public void CustomerDatabase(Customer cus)
        {
            customer.Add(cus);
        }
       
    }
}
