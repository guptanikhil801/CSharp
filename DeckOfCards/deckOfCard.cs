namespace OopsPrograms.DeckOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Text;

   public class Card
    {
        private string Suit;
        private string Rank;
        public Card(string cardsuit, string cardrank)
        {
            this.Suit = cardsuit;
            this.Rank = cardrank;
        }
        public override string ToString()
        {
            return Rank + " Of " + Suit;
        }
    }

   public class DeckOfCard
    {

    }
}
