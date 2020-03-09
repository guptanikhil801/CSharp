namespace Algorithm
{
    using System;
    using System.Text;

    /// <summary>
    /// This class contains code to sorting of integer by using merge sort algorithm.
    /// </summary>
    public class MergeSortAlgorithm
    {
        /// <summary>
        /// This method merges the 
        /// </summary>
        /// <param name="arr">The array.</param>
        /// <param name="l">The l.</param>
        /// <param name="m">The m.</param>
        /// <param name="r">The r.</param>
        public static void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] left = new int[n1];
            int[] right = new int[n2];

            for (int f = 0; f < n1; ++f)
            {
                left[f] = arr[l + f];
            }

            for (int d = 0; d < n2; ++d)
            {
                right[d] = arr[m + 1 + d];
            }

            int i = 0, j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }

        /// <summary>
        /// It Sorts the specified arr.
        /// </summary>
        /// <param name="arr"> array.</param>
        /// <param name="l">The l.</param>
        /// <param name="r">The r.</param>
        public static void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;

                Sort(arr, l, m);
                Sort(arr, m + 1, r);

                Merge(arr, l, m, r);
            }
        }

        /// <summary>
        /// it Prints the array after sorting.
        /// </summary>
        /// <param name="arr">the array .</param>
        public static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Drivers  method to do merge sort and display sorted arrays.
        /// </summary>
        public static void DriverMethodMergeSort()
        {
            int[] arr = { 98, 101, 43, 15, 89, 71 };          
            Console.WriteLine("Given Array is");
            PrintArray(arr);
            Sort(arr, 0, arr.Length - 1);
            Console.WriteLine("After Sorting array is : ");
            PrintArray(arr);
        }
    }
}
