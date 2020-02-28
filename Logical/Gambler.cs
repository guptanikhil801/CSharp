namespace Logical
{
    using System;
    using System.Text;

    /// <summary>
    /// This class contains code to play gambler
    /// </summary>
    public class Gambler
    {
        /// <summary>
        ///this method is to Plays the gambler.
        /// </summary>
        /// <param name="trial">The trial.</param>
        /// <param name="stake">The stake.</param>
        /// <param name="goal">The goal.</param>
        public static void PlayGambler(double trial, double stake, double goal)
        {
            double bet = 1;
            double countwin = 0;
            double countloss = 0;
            while ((stake > 0 && trial > 0) && (stake != goal || stake == 0))
            {
                double rand = new Random().NextDouble();
                trial++;
                if (rand > 0.5)
                {
                    stake = stake + bet;
                    countwin++;
                }
                else
                {
                    stake = stake - bet;
                    countloss++;
                }
                if (goal == stake || stake == 0)
                {
                    break;
                }
            }

            double winper = countwin / (countwin + countloss) * 100;
            double lossper = countloss / (countwin + countloss) * 100;
            Console.WriteLine("wining percentage is : " + winper);
            Console.WriteLine("Loss percentage is : " + lossper);
        }

        /// <summary>
        /// Drivers method to take trials, stake and goal as input to play gambler.
        /// </summary>
        public static void DriverMethodGambler()
        {
            Console.WriteLine("enter number of trials");
            double trial = double.Parse(Console.ReadLine());

            Console.WriteLine("enter stake");
            double stake = double.Parse(Console.ReadLine());

            Console.WriteLine("enter goal");
            double goal = double.Parse(Console.ReadLine());

            PlayGambler(trial, stake, goal);
        }
    }
}
