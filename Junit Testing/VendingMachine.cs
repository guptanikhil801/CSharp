namespace JUnitTesting
{
    using System;
    using System.Text;

    /// <summary>
    /// This class contains code to give possible minimum number of notes 
    /// </summary>
    public class VendingMachine
    {
        /// <summary>
        /// This method Dispenses change.
        /// </summary>
        /// <param name="amount">The amount.</param>
        public static void DispenseChange(int amount)
        {
            int totalchange = 0, thousand = 0, five500 = 0, hundred = 0, fifty = 0, ten = 0, five = 0, two = 0, one = 0;

            while (amount >= 1000)
            {
                totalchange++;
                thousand++;
                amount = amount - 1000;
            }

            while (amount >= 500)
            {
                totalchange++;
                five500++;
                amount = amount - 500;
            }

            while (amount >= 100)
            {
                totalchange++;
                hundred++;
                amount = amount - 100;
            }

            while (amount >= 50)
            {
                totalchange++;
                fifty++;
                amount = amount - 50;
            }

            while (amount >= 10)
            {
                totalchange++;
                ten++;
                amount = amount - 10;
            }

            while (amount >= 5)
            {
                totalchange++;
                five++;
                amount = amount - 5;
            }

            while (amount >= 2)
            {
                totalchange++;
                two++;
                amount = amount - 2;
            }

            while (amount >= 1)
            {
                totalchange++;
                one++;
                amount = amount - 1;
            }

            Console.WriteLine("Minimum " + totalchange + " Notes needed to give change.");
            Console.WriteLine("List Of Notes ");
            if (thousand != 0)
            {
                Console.WriteLine(thousand + " Notes of 1000 ");
            }

            if (five500 != 0)
            {
                Console.WriteLine(five500 + " Notes of 500 ");
            }

            if (hundred != 0)
            {
                Console.WriteLine(hundred + " Notes of 100 ");
            }

            if (fifty != 0)
            {
                Console.WriteLine(fifty + " Notes of 50 ");
            }

            if (ten != 0)
            {
                Console.WriteLine(ten + " Notes of 10 ");
            }

            if (five != 0)
            {
                Console.WriteLine(five + " Notes of 5 ");
            }

            if (two != 0)
            {
                Console.WriteLine(two + " Notes of 2 ");
            }

            if (one != 0)
            {
                Console.WriteLine(one + " Notes of 1 ");
            }
        }

        /// <summary>
        /// Driver method to take amount and give change by calling above method.
        /// </summary>
        public static void DriverMethodVendingM()
        {
            Console.WriteLine("Enter amount");
            int amt = int.Parse(Console.ReadLine());
            DispenseChange(amt);
        }
    }
}
