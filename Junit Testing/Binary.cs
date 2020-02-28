namespace JUnitTesting
{
    using System;
    using System.Text;

    /// <summary>
    /// This class contains code to convert a decimal into binary, and also after that swap its nibbles and check that resultant number is power of 2 or not.
    /// </summary>
    public class Binary
    {
        /// <summary>
        /// This method Converts a decimal to binary.
        /// </summary>
        /// <param name="dec">The decimal.</param>
        /// <returns>the binary</returns>
        public static string ToBinary(int dec)      // program-6(junit)
        {
            string stnum = "";
            while (dec > 0)
            {
                stnum = stnum + dec % 2;
                dec /= 2;
            }

            string binary = "";
            for (int i = stnum.Length - 1; i >= 0; i--)
            {
                binary = binary + stnum[i];
            }

            return binary;
        }

        /// <summary>
        /// This methods a  Converts into decimal.
        /// </summary>
        /// <param name="bin">The bin.</param>
        /// <returns>the decimal</returns>
        public static int ToDecimal(string bin)
        {
            int a = int.Parse(bin);
            int n = 0, p = 1;
            while (a > 0)
            {
                int d = a % 10;
                n += d * p;
                p *= 2;
                a = a / 10;
            }

            return n;
        }

        /// <summary>
        ///This method Checks a number is power of 2 or not.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>bool value true or false</returns>
        public static bool CheckPowerOf2(int n)
        {
            int i = 1;
            int t = n / 2;
            while (t > i)
            {
                if (Math.Pow(2, i) == n)
                {
                    return true;
                }

                i++;
            }

            return false;
        }

        /// <summary>
        /// driver method to take data from user .
        /// </summary>
        public static void BinaryDriverMethod()      // programme-7(Junit)
        {
            Console.WriteLine("Enter Number to swap nibbles and check resultant number is the number is a power of 2 ");
            int deci = int.Parse(Console.ReadLine());
            string binrep = ToBinary(deci);
            if (binrep.Length == 8)
            {
                string na = binrep.Substring(0, 4);
                string nb = binrep.Substring(4, 4);
                string swapnib = nb + na;
                Console.WriteLine(" after swapping nibbles : " + swapnib);

                int cp = ToDecimal(swapnib);
                Console.WriteLine("Resultant number : " + cp);
                if (CheckPowerOf2(cp))
                {
                    Console.WriteLine("resultant number is power of 2 ");
                }
                else
                {
                    Console.WriteLine("resultant is not power of 2 ");
                }
            }
            else
            {
                Console.WriteLine("nibbles cannot be swapped");
            }
        }
    }
}
