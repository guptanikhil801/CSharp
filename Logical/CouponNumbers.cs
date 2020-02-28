namespace Logical
{
    using System;
    using System.Text;

    /// <summary>
    /// This class has code to generate random coupon numbers
    /// </summary>
    public class CouponNumbers
    {
        /// <summary>
        /// This method Generates n coupon by the help of random class.
        /// </summary>
        /// <param name="n">The n.</param>
        public static void GenerateCoupon(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int[] arr = new int[4];
                arr[0] = new Random().Next(1, 10);
                arr[1] = new Random().Next(50, 100);
                arr[2] = new Random().Next(100, 200);
                arr[3] = new Random().Next(201, 299);
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(arr[j]);
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Drivers method to take data from user and generate coupon according to user need.
        /// </summary>
        public static void DriverCoupon()
        {
            Console.WriteLine("How many coupon you want ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("your coupons are ");
            GenerateCoupon(n);
        }
    }
}
