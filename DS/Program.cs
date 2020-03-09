namespace DataStructure
{

    using System;
    /// <summary>
    /// main class of DataStructure
    /// </summary>
    public class Program
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"> the string[] array</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice : ");
            Console.WriteLine("1-UnOrderedList       2-BalancedParantheses      3-CashCounter      4-PalindromeChecker     5-Hashing");
            Console.WriteLine("6-Prime2DArray       7-Anagram2dArray      8-AnagramStack      9-AnagramQueue     10-Calandar");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    DriverClassUnOrdered.DriverMethod();
                    break;
                case 2:
                    BalancedParanthesis.DriverBalanced();
                    break;
                case 3:
                    CashCounter.Count();
                    break;
                case 4:
                    PalindromeChecker.DriverPalinChecker();
                    break;
                case 5:
                    Hashing.HashingDriver();
                    break;
                case 6:
                    Prime2dimensionalcs.DriverPrime2D();
                    break;
                case 7:
                    Anagram2DArray.DriverPrime2D();
                    break;
                case 8:
                    AnagramStack.DriverAngramStack();
                    break;
                case 9:
                    AnagramQueue.Driver();
                    break;
                case 10:
                    Calender.DriverCalender();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
/*
 *  

         
 */
