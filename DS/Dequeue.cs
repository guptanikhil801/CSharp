namespace DataStructure.DS_Programmes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Dequeue<T>
    {
        public class Node
        {
            public T Data;
            public Node Next;
        }
        public Node Head;
        public void AddRear(T data)
        {
            Node node = new Node();        //// create a new node
            node.Data = data;             //// set default values
            node.Next = null;            //// set default values

            //// check that is the list is empty or not, if empty then node will become Head
            if (this.Head == null)
            {
                this.Head = node;
            }
            ////   if list is not empty than insert it at last
            else
            {
                Node t = this.Head;           ////  assign Head to a temporary Node type variable
                ////  this loop will continue till second last node
                while (t.Next != null)
                {
                    t = t.Next;       //// the value of t will keep changing
                }

                t.Next = node;
            }
        }

        public void AddFront(T data)
        {
            Node node = new Node();
            node.Data = data;
            node.Next = null;
            this.Head = node;
        }

        public int Size()
        {
            int count = 0;
            Node t = Head;
            //// if Head is null then it will return size 0 
            if (Head == null)
            {
                return 0;
                throw new NullReferenceException();
            }
            else
            {
                //// the loop will continue till the second last node
                while (t.Next != null)
                {
                    count++;                             //// the value of size will increment after every iteration 
                    t = t.Next;
                }

                count = count + 1;                       //// count = count+1 because above loop will traverse till second last node
            }
            return count;
        }

        public T Remove(int pos)
        {
            if (this.Head == null)
            {
                return default;
            }

            Node t = this.Head, pre = null;
            for (int i = 1; i < pos; i++)
            {
                pre = t;
                t = t.Next;
            }

            T Data = t.Data;
            pre.Next = null;
            return Data;
        }

        public T RemoveFront()
        {
          T rd =  Remove(1);
            return rd;
        }
    }
}
