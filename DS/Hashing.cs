namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;

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
        /// This method adds data to hashtable
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
                while(t.Next!=null)
                {
                    if(node.Data<head.Data)
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

                if(t.Next == null && head.Data<node.Data)
                {
                    head.Next = node;
                }
                else if (t.Next == null && head.Data>node.Data)
                {
                    node.Next = prev;
                    hashTable[temp] = node;
                }
            }
        }

        private static void Remove(int item, Node<int>[] hashTable)
        {
            int key = item % (Size + 1);
            if(hashTable[key].Data==item && hashTable[key].Next==null)
            {
                hashTable[key] = null;
            }
            else
            {
                Node<int> head = hashTable[key];
                Node<int> prev = hashTable[key];
                while(head.Data!=item)
                {
                    prev = head;
                    head = head.Next;
                }
                if(head.Data==item && head == hashTable[key])
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
    }
}
