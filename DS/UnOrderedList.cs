namespace DataStructure.DS_Programmes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// List class created to use generics
    /// </summary>
    /// <typeparam name="T">t type </typeparam>
    public class List<T>
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
            Node node = new Node();        //// create a new node
            node.data = data;             //// set default values
            node.next = null;            //// set default values

            //// check that is the list is empty or not, if empty then node will become head
            if (head == null)
            {
                head = node;
            }
            ////   if list is not empty than insert it at last
            else
            {
                Node t = head;           ////  assign head to a temporary Node type variable
                ////  this loop will continue till second last node
                while (t.next != null)
                {
                    t = t.next;       //// the value of t will keep changing
                }

                t.next = node;
            }
        }

        /// <summary>
        /// It Removes the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Remove(T data)
        {
            //// check if list is already empty
            if (head == null)
            {
                throw new NullReferenceException("list empty");
            }
            if (head.next == null)
            {
                head = null;
            }
            Node pre = null;     //// declare a variable which will point the previous node of the node the user want to delete
            Node t = head;

            while (t.next != null)
            {
                //// checking if data of temporary variable is equal to the data the user want to delete
                if (t.data.Equals(data))
                {
                    pre.next = t.next;       //// assign t next address to prev next 
                }

                pre = t;
                t = t.next;
            }

        }

        /// <summary>
        /// to Displays instance.
        /// </summary>
        public void Display()
        {
            Node node = head;
            //// this loop will continue till the second last node
            while (node.next != null)
            {
                Console.WriteLine(node.data);       //// printing datas
                node = node.next;                   //// node value will keep changing
            }
            Console.WriteLine(node.data);           //// manually print last node
        }

        /// <summary>
        /// Searches the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>true or false</returns>
        public bool Search(T data)
        {
            Node t = head;
            while (t.next != null)
            {
                if (t.data.Equals(data))
                {
                    return true;
                }
                t = t.next;
            }
            return false;
        }

        /// <summary>
        /// This method returns size of list
        /// </summary>
        /// <returns>the size</returns>
        public int Size()
        {
            int count = 0;
            Node t = head;
            if (head == null)          //// if head is null then it will return size 0 
            {
                return 0;
                throw new NullReferenceException();
            }
            else
            {
                //// the loop will continue till the second last node
                while (t.next != null)
                {
                    count++;                             //// the value of size will increment after every iteration 
                    t = t.next;
                }
                count = count + 1;                       //// count = count+1 because above loop will traverse till second last node
            }
            return count;
        }

        /// <summary>
        /// it returns whether the list is empty or not
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            //// will call size() method if it returns 0 then it means list is empty and returns true
            if (Size() == 0)     
            {
                return true;
            }
            else
            {
                return false;                           //// otherwise false
            }
        }

        /// <summary>
        /// it inserts list at last
        /// </summary>
        /// <param name="data"></param>
        public void Append(T data)
        {
            Add(data);              //// will simply call Add(data) method beacause by default inserts data at last
        }

        public int index(T data)
        {
            Node t = head;
            int count = 0;
            int size = Size();
            //// traverse a loop till last node
            for (int i = 1; i <= size; i++)
            {
                count++;
                //// if the given data matches then the loop will break
                if (t.data.Equals(data))
                {
                    break;
                }
                t = t.next;
            }

            return count;
        }

       /// <summary>
       /// this method removes and returns the last index
       /// </summary>
       /// <returns></returns>
        public T Pop()
        {
            if (head == null)
             return default;
            Node t = head, pre = null;
           
            while (t.next != null)
            {
                pre = t;
                t = t.next;
            }

            T data = t.data;
            pre.next = null;
            return data;
        }

        /// <summary>
        /// Adds data in specified position.
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <param name="data">The data.</param>
        public void Insert(int pos, T data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            if(pos==1)
            {
                head = node;
            }
            else
            {
                Node t = head;
             for(int i =1;i<pos-1;i++)
                {
                    t = t.next;
                }

                node.next = t.next;
                t.next = node;
            }
        }
        /// <summary>
        /// overloaded method of Pop()
        /// </summary>
        /// <param name="pos">The position.</param>
        /// <returns>removes and returns specified position</returns>
        public T Pop(int pos)
        {
            if (head == null)
            {
                return default;
            }
            Node t = head, pre = null;
            for (int i = 1; i < pos; i++)
            {
                pre = t;
                t = t.next;
            }
            T data = t.data;
            pre.next = null;
            return data;
        }
    }
}
