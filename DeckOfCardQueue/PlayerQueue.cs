using System;
using System.Collections.Generic;
using System.Text;
using OopsPrograms.DeckOfCards;

namespace OopsPrograms.DeckOfCardQueue
{
    public class Player
    {
        public Queue<string> cards;
        public Queue<string> sortedcards;
    }
    public class CardsPlayersInQueue
    {
        public static string[] CardsToString()
        {
            DeckOfCard dc = new DeckOfCard();
            dc.Shuffle();                               //// to shuffle cards before storing
            Card[] cardarr = new Card[9];           //// to store 9 cards
            string[] strarr = new string[9];
            for (int j = 0; j < cardarr.Length; j++)
            {
                cardarr[j] = dc.DistributeCard();            //// storing cards to array
                string strc = cardarr[j].ToString();
                strarr[j] = strc;                           //// in string
            }
            return strarr;
        }
    }
}
