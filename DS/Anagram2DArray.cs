namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Anagram2DArray
    {
        public static bool CheckPrime(int num)
        {
            int m = num / 2;
            for (int i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool AnagramDetectionString(string str1, string str2)
        {
            //// check the length of both string
            if (str1.Length != str2.Length)
            {
                return false;                       //// if length is not same return false
            }

            //// convert both string into character array and sort array using Array.sort method
            char[] chstr1 = str1.ToCharArray();
            char[] chstr2 = str2.ToCharArray();
            Array.Sort(chstr1);
            Array.Sort(chstr2);

            //// After sorting check the value at both array index is same or not 
            for (int i = 0; i < chstr1.Length; i++)
            {
                if (chstr1[i] != chstr2[i])
                {
                    return false;                   //// if value is not same return false
                }
            }

            return true;                            //// if value is same return true
        }

        public static bool CheckAnagramInteger(int a, int b)
        {
            string str1 = a.ToString();
            string str2 = b.ToString();
            if (AnagramDetectionString(str1, str2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int[,] StoreAnagramToArray()
        {

            int[] pr = new int[168];
            int j = 0;

            for (int i = 2; i < 1000; i++)
            {
                if (CheckPrime(i))
                {
                    pr[j] = i;
                    j++;
                }
            }

            int[] anapr = new int[422];
            int a = 0;
            for (int i = 0; i < pr.Length - 1; i++)
            {
                for (int k = i + 1; k < pr.Length; k++)
                {
                    if (CheckAnagramInteger(pr[i], pr[k]))
                    {
                        anapr[a] = pr[i];
                        a++;
                        anapr[a] = pr[k];
                        a++;
                        break;
                    }
                }
            }
            int x = 0;
            int[,] anagram2d = new int[20, 20];

            for (int e = 0; e < anagram2d.GetLength(0); e++)
            {
                for (int f = 0; f < anagram2d.GetLength(1); f++)  // int f = 0; 
                {
                    anagram2d[e, f] = anapr[x];

                    x++;
                }
            }

            return anagram2d;
        }

        private static void DisplayArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] != 0)
                    {
                        Console.Write(arr[i, j] + " ");         //// for printing value
                    }
                }

                Console.WriteLine();
            }
        }

        public static void DriverPrime2D()
        {
            Console.WriteLine("These are prime as well as Anagram numbers Stored in a two D Array: ");
            int[,] da = StoreAnagramToArray();
            DisplayArray(da);

        }

    }
}
