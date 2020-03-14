namespace OopsPrograms.DeckOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    ///main class of cards 
    /// </summary>
    public class DeckOfCards
    {
        private Card[] deck;
        private int currentcard;
        private readonly int TotalCards = 52;
        private Random randomNum;
        public DeckOfCards()
        {
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            deck = new Card[TotalCards];
            currentcard = 0;
            randomNum = new Random();
            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = new Card(ranks[i % 13], suits[i / 13]);
            }
        }
        public void Shuffle()
        {
            currentcard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = randomNum.Next(52);
                Card temp = deck[first];
                deck[first] = deck[second];
            }
        }
        public Card DistributeCard()
        {
            if (currentcard < TotalCards)
            {
                return deck[currentcard++];
            }
            else
            {
                return null;
            }
        }

    }
}
