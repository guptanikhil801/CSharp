namespace DesignPattern.Structural.Proxy
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Cash : ITransaction
    {
        public void Deposit()
        {
            Console.WriteLine("Enter amount to deposit");
            int dep = int.Parse(Console.ReadLine());
            Console.WriteLine(dep+"  deposited ");
        }

        public void PinChange()
        {
            Console.WriteLine("Enter New pin ");
            int pin = int.Parse(Console.ReadLine());
            Console.WriteLine("pin changed to "+pin);
        }

        public void Statement()
        {
            Console.WriteLine("Statement :");
            Console.WriteLine("5000 debited at 10-03-2020");
            Console.WriteLine("8000 credited at 20-03-2020");
            Console.WriteLine("current balance : 12500");
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter amount to withdraw");
            int wid = int.Parse(Console.ReadLine());
            Console.WriteLine(wid + "  withdrawl from your account ");
        }
    }
}
