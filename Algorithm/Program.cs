namespace Algorithm
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice : ");
            Console.WriteLine("1-AnagramDetection         2-BinarySearchWord       3-BubbleSort        4-InsertionSortString ");
            Console.WriteLine("5-MergeSortAlgorithm       6-Prime0To1000        7-RegexPattern         8-StringPermutation");
           int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1: AnagramDetection.DriverMethodAnagramString();
                    break;
                case 2: BinarySearchWord.DriverMethodBinarySearch();
                    break;
                case 3: BubbleSort.DriverBubbleSort();
                    break;
                case 4: InsertionSortString.DriverMethodInsertion();
                    break;
                case 5: MergeSortAlgorithm.DriverMethodMergeSort();
                    break;
                case 6: Prime0To1000.DriverMethodPrimeWithinRange();
                    break;
                case 7: RegexPatternMatch.CheckPattern();
                    break;
                case 8: StringPermutationRecursion.DriverMethodPermutation();
                    break;
                default: Console.WriteLine("invalid choice");
                    break;
            }

        }
    }
}
