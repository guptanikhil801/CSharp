namespace DesignPattern.Behavioral.Observor;
{
using System;
using System.Collections.Generic;
using System.Text;
public class Customer
{
    private string name;
    private int contactnumber;
    //private MakeMyTrip mmt = new MakeMyTrip();

    public Customer(string name, int mobile)
    {
        this.name = name;
        this.contactnumber = mobile;
    }
    public void PriceNotification()
    {
        Console.WriteLine("Hey " + name+" Price Dropped for flight");
    }
    public void OfferNotification()
    {
        Console.WriteLine("Hey " + name + " 35% off for your next Hotel Building");
    }

}
}
