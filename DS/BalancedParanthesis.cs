namespace DataStructure.DS_Programmes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class checks a equation has balanced parentheses or not
    /// </summary>
    public class BalancedParentheses
    {
        /// <summary>
        /// Drivers method to take data.
        /// </summary>
        public static void DriverBalanced()
        {
            Console.WriteLine("Enter Arithmetic Equation: ");
            string aeq = Console.ReadLine();
            Console.WriteLine(CheckParentheses(aeq));
        }

        /// <summary>
        /// Checks the parentheses.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>bool value</returns>
        public static bool CheckParentheses(string str)
        {
            Stack<char> stack = new Stack<char>(str.Length);
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    if (stack.IsEmpty())
                    {
                        return false;
                    }

                    if (ch == ')' && stack.Pop() != '(')
                    {
                        return false;
                    }
                }
            }
         
            return stack.IsEmpty();
        }
    }
}
