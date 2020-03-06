 namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class for creating Node data type
    /// </summary>
    public class Node
    {
        public int Data;
        public Node Next;
    }
 
    /// <summary>
    /// implementing queue using linked list
    /// </summary>
    public class Queuell
    {
        public Node Front, rear;
       
        /// <summary>
        /// this method adds the data into queue
        /// </summary>
        /// <param name="data">the data</param>
        public void Enqueue(int data)
        {
            Node node = new Node();
            node.Data = data;
            node.Next = null;
            if (this.rear == null)
            {
                this.Front = this.rear = node;
                return;
            }

            this.rear.Next = node;
            this.rear = node;
        }

        /// <summary>
        /// it displays the data of queue
        /// </summary>
        public void Display()
        {
            Node node = new Node();
            node = this.Front;
            //// this loop will continue till the second last node
            while (node.Next != null)
            {
                Console.Write(node.Data + " ");       //// printing datas
                node = node.Next;                   //// node value will keep changing
            }

            Console.Write(node.Data);           //// manually print last node
        }
    }
    
    /// <summary>
    /// main class for storing Anagram into queue  
    /// </summary>
    public class AnagramQueue
    {
        /// <summary>
        /// main driver method 
        /// </summary>
        public static void Driver()
        {
            Queuell qi = new Queuell();
            Console.WriteLine("Prime and Anagrams Numbers from 0 to 1000 using queue");

            for (int i = 0; i < 1000; i++)
            {
                if (Anagram2DArray.CheckPrime(i))
                {
                    for (int j = i +1; j <1001; j++)
                    {
                        if (Anagram2DArray.CheckPrime(j) && Anagram2DArray.CheckAnagramInteger(i, j))
                        {
                            qi.Enqueue(i);
                            qi.Enqueue(j);
                            break;
                        }
                    }
                }
            }

            qi.Display();
        }
    }
}
