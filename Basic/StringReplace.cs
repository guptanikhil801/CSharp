namespace Basic
{
    using System;
    using System.Text;

    /// <summary>
    /// This class contains code to change "user name" by the user entered data.
    /// </summary>
    public class StringReplace
    {
        /// <summary>
        /// Drivers the method to take input and replace string.
        /// </summary>
        public static void DriverMethodreplaceString()
        {
            Console.WriteLine("Enter your name ");
            string str = Console.ReadLine();
            Console.WriteLine("Hello " + str + ", How are you.");
        }
    }
}
