namespace DataStructure
{
    using System;
    using System.Text;
    using System.IO;
    
    /// <summary>
    /// This is Driver class of UnOrderedList
    /// </summary>
   public class DriverClassUnOrdered
    {
        /// <summary>
        /// driver method
        /// </summary>
        public static void DriverMethod()
        {
            Console.Write("Enter your File Path : ");
            String filest = Path.GetFullPath(Console.ReadLine());
            String[] strarr = File.ReadAllText(filest).Split(" ");
            List<string> ls = new List<string>();
            for(int i=0;i<strarr.Length;i++)
            {
                string wd = strarr[i];
                ls.Append(wd);                             //// adding string array into list
            }
            string origfile = File.ReadAllText(filest);
           Console.WriteLine("Your original file");
           Console.WriteLine(origfile);

            Console.WriteLine("Enter word to be searched");
            string word = Console.ReadLine();

            if (ls.Search(word))
            {
                Console.WriteLine(word + " found so it will be removed from list");
                ls.Remove(word);
            }
            else
            {
                Console.WriteLine(word + " not found so it will be added to list");
                ls.Append(word);
            }

            Console.WriteLine("After processing final list is as below and your file is modified ");
            Console.WriteLine(ls.DisplayInString());
            string filecontent = ls.DisplayInString();
            File.WriteAllText(filest, filecontent);
        }
        }
    }

