namespace DesignPattern.Behavioral.Observor;
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Customer
    {
    private string name;
    private int contactnumber;
    private MakeMyTrip mmt = new MakeMyTrip();

    public Customer(string name, int mobile)
    {
        this.name = name;
        this.contactnumber = mobile;
    }
    }
}
