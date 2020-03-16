// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayerQueue.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OopsPrograms.DeckOfCardQueue
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using OopsPrograms.DeckOfCards;

    /// <summary>
    /// to define player type
    /// </summary>
    public class Player
    {
        public Queue<string> cards;
        public Queue<string> sortedcards;
    }
    /// <summary>
    /// contains implementation of players
    /// </summary>
    public class CardsPlayersInQueue
    {
        private static string[] RandomCards()
        {
            DeckOfCard dc = new DeckOfCard();
            dc.Shuffle();                               //// to shuffle cards before storing
            Card[] cardarr = new Card[9];           //// to store 9 cards
            string[] strarr = new string[9];
            for (int j = 0; j < cardarr.Length; j++)
            {
                cardarr[j] = dc.DistributeCard();            
                string strc = cardarr[j].ToString();
                strarr[j] = strc;                           //// storing cards in string array
            }
            return strarr;
        }
        private static string[] SortedCardRanking()
        {
            string[] aftersort = new string[9];

            string[] sortcards = { "Clubs Of Ace", "Diamonds Of Ace", "Hearts Of Ace", "Spades Of Ace" , "Clubs of king",
                                 "Diamonds Of king","Hearts Of king","Spades Of king","Clubs Of queen","Diamonds Of queen", "Hearts Of queen",
                                   "Spades Of queen","Clubs Of jack","Diamonds Of jack","Hearts Of jack","Spades Of jack",
                            "Clubs Of 10","Diamonds Of 10","Hearts Of 10","Spades Of 10","Clubs Of 9","Diamonds Of 9","Hearts Of 9","Spades Of 9",
                            "Clubs Of 8","Diamonds Of 8","Hearts Of 8","Spades Of 8","Clubs Of 7","Diamonds Of 7","Hearts Of 7","Spades Of 7",
                            "Clubs Of 6","Diamonds Of 6","Hearts Of 6","Spades Of 6","Clubs Of 5","Diamonds Of 5","Hearts Of 5","Spades Of 5","Clubs Of 4",
          "Diamonds Of 4","Hearts Of 4","Spades Of 4","Clubs Of 3","Diamonds Of 3","Hearts Of 3","Spades Of 3","Clubs Of 2","Diamonds Of 2","Hearts Of 2","Spades Of 2"};
            string[] cts = RandomCards();
            int l = 0;
            for (int i = 0; i < sortcards.Length; i++)
            {
                for (int j = 0; j < cts.Length; j++)
                {
                    string s = sortcards[i].ToString();
                    string c = cts[j].ToString();
                    if (s.Equals(c) && (s != null) && (c != null))
                    {
                        aftersort[l] = c;
                        l++;
                    }
                }
            }
            return aftersort;
        }
        public static void DriverMethodsCardsQueue()
        {
            Queue<Player> playerlist = new Queue<Player>();
            for (int j = 0; j < 4; j++)
            {
                Player p = new Player();
                Queue<string> ls = new Queue<string>();
                string[] cardpp = RandomCards();
                for (int i = 0; i < cardpp.Length; i++)
                {
                    ls.Enqueue(cardpp[i].ToString());
                    //  p.cards.Enqueue(cardpp[0]);
                }
                p.cards = ls;
                Queue<string> so = new Queue<string>();
                string[] cardso = SortedCardRanking();

                for (int k = 0; k < cardso.Length; k++)
                {
                    so.Enqueue(cardso[k].ToString());
                }
                p.sortedcards = so;
                playerlist.Enqueue(p);
            }

            for (int i = 1; i <= 4; i++)
            {
                Player pa = playerlist.Dequeue();
                Console.WriteLine();
                Console.WriteLine("   Player " + i + " Cards in Random order");
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(string.Format("\t{0}", pa.cards.Dequeue()));
                }
                Console.WriteLine();
                Console.WriteLine("   Player " + i + " Cards in sorted order");
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(string.Format("\t{0}", pa.sortedcards.Dequeue()));
                }
            }
        }
    }
}
