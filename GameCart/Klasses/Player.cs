using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCart.Klasses
{
    class Player
    {
        public List<Card> Cards { get; set; }
        public Player()
        {
            Cards = new List<Card>();
        }
        public void TakeCard(Card card)
        {
            Cards.Add(card);
        }
        public Card GetMinimalTrump(Suit suit)
        {
            Card tmp = new Card(SizeCard.Ase, suit);
            foreach (Card item in Cards)
            {
                if (item.Suit == suit)
                {
                    if (item < tmp) tmp = item;
                }
            }
            return tmp;
        }
    }
}
