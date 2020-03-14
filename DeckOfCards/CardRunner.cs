
namespace OopsPrograms.DeckOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CardRunner
    {
        private static Card[,] StoreCardTo2DArray()
        {
            DeckOfCard dc = new DeckOfCard();
            dc.Shuffle();
            Card[,] cardarr = new Card[9, 4];
            for (int i = 0; i < cardarr.GetLength(0); i++)
            {
                for (int j = 0; j < cardarr.GetLength(1); j++)
                {
                    cardarr[i, j] = dc.DistributeCard();
                }
            }
            return cardarr;
        }
        CardRunner cr = new CardRunner();
        Card[,] cardarrfin = StoreCardTo2DArray();
        public static void DisplayCardin2D()
        {
            string[] player = { "player 1", "player 2", "player 3", "player 4" };
            Console.Write(string.Format("\t{0}\t{1}\t{2}\t{3}", player[0], player[1], player[2], player[3]));
            Console.WriteLine();
            Card[,] crr = StoreCardTo2DArray();
            for (int i = 0; i < crr.GetLength(0); i++)
            {
                for (int j = 0; j < crr.GetLength(1); j++)
                {
                    string cardstr = crr[i, j].ToString();
                    Console.Write(string.Format("\t{0}", cardstr));
                }
                Console.WriteLine();
            }
        }
    }
}
