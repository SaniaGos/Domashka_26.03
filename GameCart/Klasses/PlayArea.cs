using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCart.Klasses
{
    class PlayArea
    {
        public List<Card> Cards { get; set; }
        public PlayArea()
        {
            Cards = new List<Card>();
        }
        public void PutCard(Card card)
        {
            Cards.Add(card);
        }
    }
}
