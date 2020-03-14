// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeckOfCard.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OopsPrograms.DeckOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// main class of cards 
    /// </summary>
    public class DeckOfCard
    {
        /// <summary>
        /// to store value of total cards
        /// </summary>
        private readonly int TotalCards = 52;
       
        /// <summary>
        /// card type deck array
        /// </summary>
        private Card[] deck;

        /// <summary>
        /// to refer current card
        /// </summary>
        private int currentcard;

        /// <summary>
        /// to create random numbers
        /// </summary>
        private Random randomNum;

        /// <summary>
        /// Initializes a new instance of the DeckOfCard class
        /// </summary>
        public DeckOfCard()
        {
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };             //// assigning all ranks to a array.
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };             //// assigning all suits to a array.
            this.deck = new Card[this.TotalCards];             //// initializing deck[] of type card
            this.currentcard = 0;             //// initializing value of current card
            this.randomNum = new Random();
            for (int i = 0; i < this.deck.Length; i++)
            {
                this.deck[i] = new Card(ranks[i % 13], suits[i / 13]);               ////  storing deck array with cards
            }
        }

        /// <summary>
        /// method to shuffle the cards 
        /// </summary>
        public void Shuffle()
        {
            this.currentcard = 0;
            for (int first = 0; first < this.deck.Length; first++)
            {
                int second = this.randomNum.Next(52);
                Card temp = this.deck[first];                          //// shuffling cardsby using random numbers
                this.deck[first] = this.deck[second];
            }
        }

        /// <summary>
        /// method to distribute cards
        /// </summary>
        /// <returns>the card</returns>
        public Card DistributeCard()
        {
            if (this.currentcard < this.TotalCards)
            {
                return this.deck[this.currentcard++];
            }
            else
            {
                return null;
            }
        }
    }
}
