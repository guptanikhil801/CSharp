namespace Basic
{
    using System;
    using System.Text;

    /// <summary>
    /// This class contains code to flip the coin and display percentage of head and tail.
    /// </summary>
    public class FlipCoin
    {
        /// <summary>
        /// This method will generate random number and calculate the head and tail percentage.
        /// </summary>
        /// <param name="flip">The flip.</param>
        public static void Flipping(double flip)
        {
            double tails = 0;         //// initializing tail with 0
            double heads = 0;         //// initializing head with 0

            //// take loop which will go till number of flips
           for (int i = 1; i <= flip; i++)
            {
                double rd = new Random().NextDouble();     // generate random number
                if (rd < 0.5)
                {
                    tails++;           //// if random number is less than 0.5 tail value will increase by 1.
                }
                else
                {                    //// else head value will increase by 1.
                    heads++;
                }
            }

            double headper = (heads / flip) * 100;              // calculate head percentage
            double tailper = (tails / flip) * 100;             // calculate tail percentage

            //// output the result
            Console.WriteLine("Head percentage : " + headper);
            Console.WriteLine("Tail percentage : " + tailper);
        }

        /// <summary>
        /// Drivers method to take input from user.
        /// </summary>
        public static void DriverMethodFlipCoin()
        {
            Console.WriteLine("enter number of times you want to flip ");
            double n = double.Parse(Console.ReadLine());
            Flipping(n);
        }
    }
}
