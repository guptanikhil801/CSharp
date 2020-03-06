namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class contains stack implementation required for Anagram number storing 
    /// </summary>
    public class Stackll
    {
        /// <summary>
        /// class for making Node data type
        /// </summary>
        public class Node
        {
            public int Data;
            public Node Next;
        }

        public Node Top;

        /// <summary>
        /// This method adds data to stack
        /// </summary>
        /// <param name="data">the data to be added</param>
        public void Push(int data)
        {
            Node node = new Node();
            node.Next = null;
            if (node == null)
            {
                Console.WriteLine(" stack Overflow");
                return;
            }

            node.Data = data;
            node.Next = this.Top;
            this.Top = node;
        }

        /// <summary>
        /// this method displays stacks
        /// </summary>
        public void Display()
        {
            if (this.Top == null)
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            else
            {
                Node temp = this.Top;
                while (temp != null)
                {
                    Console.Write(temp.Data + " ");
                    temp = temp.Next;
                }
            }
        }
    }

    /// <summary>
    /// This class contains code to print prime anagram number in reverse order using stack
    /// </summary>
    public class AnagramStack
    {
        /// <summary>
        /// main driver method 
        /// </summary>
        public static void DriverAngramStack()
        {
            Stackll sl = new Stackll();
            Console.WriteLine("Prime as well as Anagrams Numbers from 0 to 1000 using Stack in reverse order");

            for (int i = 0; i < 1000; i++)
            {
                if (Anagram2DArray.CheckPrime(i))
                {
                    for (int j = i + 1; j < 1001; j++)
                    {
                        if (Anagram2DArray.CheckPrime(j) && Anagram2DArray.CheckAnagramInteger(i, j))
                        {
                            sl.Push(i);
                            sl.Push(j);
                            break;
                        }
                    }
                }
            }

            sl.Display();
        }
    }
}
