// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Card.cs" company="Bridgelabz">
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
    /// this is to card data type
    /// </summary>
    public class Card
    {
        /// <summary>
        /// for suit
        /// </summary>
        private string Suit;
        
        /// <summary>
        /// for Rank
        /// </summary>
        private string Rank;
        
        /// <summary>
        /// Initializes a new instance of card class
        /// </summary>
        /// <param name="cardsuit">suit of card</param>
        /// <param name="cardrank">rank of card</param>
        public Card(string cardsuit, string cardrank)
        {
            this.Suit = cardsuit;
            this.Rank = cardrank;
        }
        
        /// <summary>
        /// to override object
        /// </summary>
        /// <returns>the string</returns>
        public override string ToString()
        {
            return this.Rank + " Of " + this.Suit;
        }
    }
}
