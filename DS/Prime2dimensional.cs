using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.DS_Programmes
{
    class Prime2dimensional
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

        public static int CountPrime()
        {
            int range1 = 0;
            int range2 = 100;
            int count = 0;
            for (int i = range1; i < range2; i++)
            {
                if (CheckPrime(i))
                {
                    count++;
                }
            }

            return count;
        }

        public int[,] StorePrimeToArray()
        {
            int[,] pArray = new int[20, 30];
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

    }
}
