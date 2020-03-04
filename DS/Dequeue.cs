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

        
    }
}
