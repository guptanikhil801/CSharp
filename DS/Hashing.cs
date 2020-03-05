namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;

    /// <summary>
    /// This class has code for hash based search
    /// </summary>
    class Hashing
    {
        public const int Size = 10;
        public class Node<T>
        {
            public T Data;
            public Node<T> Next;
        }

        /// <summary>
        /// This method adds data to hashtable if data entered by user not found in list
        /// </summary>
        /// <param name="hashTable">The hashtable</param>
        /// <param name="item">the data</param>
        private static void AddData(Node<int>[] hashTable, int item)
        {
            Node<int> node = new Node<int>();
            node.Data = item;
            node.Next = null;
            int temp = item % (Size + 1);
            if (hashTable[temp] == null)
            {
                hashTable[temp] = node;
            }
            else
            {
                Node<int> head = hashTable[temp];
                Node<int> prev = hashTable[temp];
                Node<int> t = hashTable[temp];
                while (t.Next != null)
                {
                    if (node.Data < head.Data)
                    {
                        node.Next = head;
                        hashTable[temp] = node;
                        break;
                    }
                    else
                    {
                        prev = head;
                        head = head.Next;
                    }

                    t = t.Next;
                }

                if (t.Next == null && head.Data < node.Data)
                {
                    head.Next = node;
                }
                else if (t.Next == null && head.Data > node.Data)
                {
                    node.Next = prev;
                    hashTable[temp] = node;
                }
            }
        }

        /// <summary>
        /// This method removes the searched data if found in hashtable
        /// </summary>
        /// <param name="item"></param>
        /// <param name="hashTable"></param>
        private static void Remove(int item, Node<int>[] hashTable)
        {
            int key = item % (Size + 1);
            if (hashTable[key].Data == item && hashTable[key].Next == null)
            {
                hashTable[key] = null;
            }
            else
            {
                Node<int> head = hashTable[key];
                Node<int> prev = hashTable[key];
                while (head.Data != item)
                {
                    prev = head;
                    head = head.Next;
                }
                if (head.Data == item && head == hashTable[key])
                {
                    prev = head.Next;
                    hashTable[key] = prev;
                }
                else if (head.Data == item)
                {
                    prev.Next = head.Next;
                }
            }
        }

        /// <summary>
        /// this methode displays the hashtable
        /// </summary>
        /// <param name="hashTable">the hashtable</param>
        private static void Display(Node<int>[] hashTable)
        {
            foreach (Node<int> item in hashTable)
            {
                Node<int> items = item;
                if (items == null)
                {
                    Console.WriteLine(" ");
                }

                else
                {
                    while (items.Next != null)
                    {
                        Console.WriteLine(items.Data);
                        items = items.Next;
                    }

                    Console.WriteLine(items.Data);
                }
            }
        }
        /// <summary>
        /// this method searches the data
        /// </summary>
        /// <param name="hashTable">the hashtable</param>
        /// <param name="search">the item to be searched</param>
        private static void Searching(Node<int>[] hashTable, int search)
        {
            int key = search % (Size + 1);
            if (hashTable[key].Next == null)
            {
                if (hashTable[key].Data == search)
                {
                    Console.WriteLine("Item Found");
                    Remove(search, hashTable);
                }
                else
                {
                    Console.WriteLine(" Item Not Found");
                    AddData(hashTable, search);
                }
            }
            else
            {
                Node<int> head = hashTable[key];
                Node<int> prev = hashTable[key];
                Node<int> t = hashTable[key];

                while (head.Next != null)
                {
                    if (head.Data == search)
                    {
                        Console.WriteLine("Item Found");
                        Remove(search, hashTable);
                        break;
                    }

                    head = head.Next;
                }

                if (head.Next == null && head.Data == search)
                {
                    Console.WriteLine("Item Found");
                    Remove(search, hashTable);
                }
                else if (head.Next == null)
                {
                    Console.WriteLine(" Item Not Found");
                    AddData(hashTable, search);
                }
            }
            Console.WriteLine("After Searching the HashTable will be");
            Display(hashTable);
        }

        public static void HashingDriver()
        {
            string numbers = File.ReadAllText(@"C:\Users\yempc69\Desktop\HashNumbers.txt");
            string[] hashnum = numbers.Split(' ');
            int[] hnum = Array.ConvertAll(hashnum, int.Parse);
            Node<int>[] hashTable = new Node<int>[Size + 1];
            foreach (int item in hnum)
            {
                AddData(hashTable, item);
            }

            Display(hashTable);
            Console.WriteLine("Enter the number to search");
            int search = Convert.ToInt32(Console.ReadLine());
            Searching(hashTable, search);
        }
    }
}
