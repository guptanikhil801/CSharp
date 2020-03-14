// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CardRunner.cs" company="Bridgelabz">
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
    /// Runner class of Deck of card
    /// </summary>
    public class CardRunner
    {
        /// <summary>
        /// to stores card to array
        /// </summary>
        /// <returns>card type 2d array</returns>
        private static Card[,] StoreCardTo2DArray()
        {
            DeckOfCard dc = new DeckOfCard();
            dc.Shuffle();                               //// to shuffle cards before storing
            Card[,] cardarr = new Card[9, 4];           //// 9 rows for cards and 4 columns for player
            for (int i = 0; i < cardarr.GetLength(0); i++)
            {
                for (int j = 0; j < cardarr.GetLength(1); j++)
                {
                    cardarr[i, j] = dc.DistributeCard();             //// storing cards to array
                }
            }

            return cardarr;
        }

        /// <summary>
        /// to display 9 cards of 4 players in 2D Array
        /// </summary>
        public static void DisplayCardin2D()
        {
            string[] player = { "player 1", "player 2", "player 3", "player 4" };         //// to print players name
            Console.Write(string.Format("\t{0}\t{1}\t{2}\t{3}", player[0], player[1], player[2], player[3]));
            Console.WriteLine();
            Card[,] crr = StoreCardTo2DArray();
            for (int i = 0; i < crr.GetLength(0); i++)
            {
                for (int j = 0; j < crr.GetLength(1); j++)
                {
                    string cardstr = crr[i, j].ToString();             //// converting card data types to string
                    Console.Write(string.Format("\t{0}", cardstr));
                }

                Console.WriteLine();
            }
        }
    }
}
