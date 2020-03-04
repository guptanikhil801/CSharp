namespace DataStructure.DS_Programmes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class has code to print prime number 0 to 1000 in 2D Array
    /// </summary>
    public class Prime2dimensional
    {
        /// <summary>
        /// it checks whether a number is prime or not
        /// </summary>
        /// <param name="num">the number</param>
        /// <returns>true or false</returns>
        public static bool CheckPrime(int num)
        {
            int m = num / 2;
            //// the loop will continue till half of number
            for (int i = 2; i <= m; i++)
            {
                //// if number is divisible by i value then returns false
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;       //// otherwise if not divisible then true
        }

        /// <summary>
        /// This method stores prime number to 2d array
        /// </summary>
        /// <param name="prarr">the array</param>
        /// <returns>after storing prime numbers it returns 2d array</returns>
        public static int[,] StorePrimeToArray(int[,] prarr)
        {
            int m = 0, n = 100;                //// because range is 100 
            for (int i = 0; i < prarr.GetLength(0) && n < 1001; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = m, k = 0; j < n; j++)
                    {
                        //// checkingg if number is prime or not
                        if (CheckPrime(j))
                        {
                            prarr[i, k++] = j;           //// if it is prime the number will be stored
                        }
                    }

                    m = n;                   //// to change range
                    n = n + 100;
                }
                else
                {
                    prarr[i, 0] = m;            //// it will print on first column
                    prarr[i, 1] = n;            //// it will print on second column
                }
            }

            return prarr;
        }

        /// <summary>
        /// it displays the 2D Array
        /// </summary>
        /// <param name="arr">2d array</param>
        public static void DisplayArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(arr[i, 0] + "-" + arr[i, 1]);  //// this will print Range
                }
                else
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] != 0)
                        {
                            Console.Write(arr[i, j] + " ");         //// for printing value
                        }
                    }
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// this method prints the result by calling methods
        /// </summary>
        public static void DriverPrime2D()
        {
            int[,] primear = new int[20, 27];     //// there will be 20(10 for range and 10 for value) rows and 
                                                  //// 27 column because in a range of 100 there is maximum 27 numbers(0-100)
            DisplayArray(StorePrimeToArray(primear));
        }
    }
}
