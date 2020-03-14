using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms.DeckOfCards
{
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
}
