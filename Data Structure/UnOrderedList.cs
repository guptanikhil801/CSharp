namespace DataStructure.DS_Programmes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// List class created to use generics
    /// </summary>
    /// <typeparam name="T">t type </typeparam>
   public class List <T>
    {

        /// <summary>
        /// Node class for making Node data type
        /// </summary>
       public class Node
        {
           public T data;
           public Node next;
        }

        public Node head;      //// Node type head created which refers to first Node

        /// <summary>
        /// This method inserts data into list.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Add(T data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node t = head;
                while(t.next!=null)
                {
                    t = t.next;
                }

                t.next = node;
            }
        }
    }
}
