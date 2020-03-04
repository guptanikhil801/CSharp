namespace DataStructure.DS_Programmes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class PalindromeChecker
    {
        public static bool IsPalindrome(string str)
        {
            ////Adding elements to queue
            Dequeue<char> dq = new Dequeue<char>();
            for (int i = 0; i < str.Length; i++)
            {
                dq.AddRear(str[i]);
            }
            while(!dq.IsEmpty())
            {
                if(dq.Size()==1)
                {
                    break;
                }
                if(!(dq.RemoveFront().Equals(dq.RemoveRear())))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
