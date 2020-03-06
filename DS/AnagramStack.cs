namespace DataStructure
{

    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// This class contains code to print prime anagram number in reverse order using stack
    /// </summary>
    public class AnagramStack
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
            node.Next = Top;
            Top = node;
        }

        public void Display()
        {
            if(Top==null)
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            else
            {
                Node temp = Top;
                while(temp!=null)
                {
                    Console.Write(temp.Data + " ");
                    temp = temp.Next;
                }
            }
        }
    }
}
