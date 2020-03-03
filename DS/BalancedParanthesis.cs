namespace DataStructure.DS_Programmes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class BalancedParanthesis
    {
        public static void DriverBalanced()
        {
            Console.WriteLine("Enter Arithmetic Equation: ");
            string aeq = Console.ReadLine();
            Console.WriteLine(CheckParenthesis(aeq));
        }

        public static bool CheckParenthesis(string str)
        {
            Stack<char> stack = new Stack<char>(str.Length);
            for(int i=0; i<str.Length; i++)
            {
                char ch = str[i];
                if(ch=='(')
                {
                    stack.Push(ch);
                }
                else if (ch==')')
                {
                    if(stack.IsEmpty())
                    {
                        return false;
                    }

                    if(ch==')'&& stack.Pop()!='(')
                    {
                        return false;
                    }
                }
            }
            return stack.IsEmpty();

        }
    }
}
