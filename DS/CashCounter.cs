namespace DataStructure.DS_Programmes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class CashCounter
    {
        public static void Count()
        {
            Console.WriteLine("How many people are in the queue");
            int people = int.Parse(Console.ReadLine());
            Queue<string> q = new Queue<string>(people);
            int amount = 100000;                              //// initial amount in bank
            
            while(q.Size()<people)
            {
                Console.WriteLine("enter customer name ");                  //// Taking customer one by one
                q.Enqueue(Console.ReadLine());
            }
            Console.WriteLine("Current available balance in bank : " + amount);
            while(!q.IsEmpty())
            {
                Console.WriteLine(q.Dequeue() + " enter 'W' to withdraw money or 'D' to deposit money");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Enter amount : ");
                int entered = int.Parse(Console.ReadLine());
                if(ch=='D'|| ch=='d')
                {
                    amount = amount + entered;                    //// if amount is deposited
                    Console.WriteLine("deposit Succesfull");
                }
                else if(ch=='W'||ch=='w')
                {
                    //// if entered amount is greater than amount, then withdrawl not possible
                    if(entered>amount)
                    {
                        Console.WriteLine("amount exceeds the available balance in Bank ");
                    }
                    else
                    {
                        Console.WriteLine("succesfully amount withdrawn");
                        amount = amount - entered;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
                Console.WriteLine("Available Bank Balance : " + amount);

            }
            Console.WriteLine("Queue ended ");

        }
    }
}
