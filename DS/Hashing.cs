﻿namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Hashing
    {
        public const int Size = 10;
        public class Node<T>
        {
            public T Data;
            public Node<T> Next;
        }

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
    }
}
