using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.DS_Programmes
{
    /// <summary>
    /// This class has code to print prime number 0 to 1000 in 2D Array
    /// </summary>
   public class Prime2dimensional
    {
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
        /// <param name="pArray">the array</param>
        /// <returns>after storing prime numbers it returns 2d array</returns>
        public static int[,] StorePrimeToArray(int[,] pArray)
        {
            
            int m = 0, n = 100;
            for (int i = 0; i < pArray.GetLength(0) && n < 1001; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = m, k = 0; j < n; j++)
                    {
                        if (CheckPrime(j))
                        {
                            pArray[i, k++] = j;
                        }
                    }
                    m = n;
                    n = n + 100;
                }
                else
                {
                    pArray[i, 0] = m;
                    pArray[i, 1] = n;
                }
            }

            return pArray;
        }

        public static void DisplayArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(arr[i, 0] +"-" + arr[i, 1]);
                }
                else
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] != 0)
                        {
                            Console.Write(arr[i, j] + " ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        public static void DriverPrime2D()
        {
            int[,] pArray = new int[20, 27];  
            DisplayArray(StorePrimeToArray(pArray));
        }

    }
}
