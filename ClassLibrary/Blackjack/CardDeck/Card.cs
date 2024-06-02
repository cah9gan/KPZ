using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Blackjack.CardDeck
{
    public class Card
    {
        public CardSuitInfo Suit { get; }
        public CardName Name { get; }

        public Card(CardSuitInfo suit, CardName name)
        {
            this.Suit = suit;
            this.Name = name;
        }
    }
}
