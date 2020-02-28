namespace Week1.FunctionalProgrammes
{
    using System;
    using System.Text;

    /// <summary>
    /// This class contains code to make 2d array for user according to his need
    /// </summary>
    public class TwoDArray
    {
        /// <summary>
        /// This method is for Integers array.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="c">The c.</param>
        public static void IntegerArray(int r, int c)
        {
            int[,] intarr = new int[r, c];
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    intarr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Your Array Elements are ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(intarr[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// This method creates Doubles type array.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="c">The c.</param>
        public static void DoubleArray(int r, int c)
        {
            double[,] douarr = new double[r, c];
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    douarr[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Your Array Elements are ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(douarr[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// This method creates Bools type array.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="c">The c.</param>
        public static void BoolArray(int r, int c)
        {
            bool[,] boolarr = new bool[r, c];
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    boolarr[i, j] = bool.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Your Array Elements are ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(boolarr[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Driver method for 2d array which takes row and column size from user and type of array and creates array.
        /// </summary>
        public static void DriverMethod2DArray()
        {
            Console.WriteLine("Enter Row size");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter column size");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(" enter your choice i-integers, b-boolean, d-double");
            char choice = char.Parse(Console.ReadLine());
            switch (choice)
            {
                case 'i':
                    IntegerArray(m, n);
                    break;
                case 'd':
                    DoubleArray(m, n);
                    break;
                case 'b':
                    BoolArray(m, n);
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }
    }
}
