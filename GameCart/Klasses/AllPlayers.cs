using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCart.Klasses
{
    class AllPlayers: IEnumerable<Player>
    {
        public List<Player> Players { get; private set; }
        public AllPlayers(int numOfPlayer)
        {
            Players = new List<Player>();
            for (int i = 0; i < numOfPlayer; i++)
            {
                Players.Add(new Player());
            }
        }

        public IEnumerator<Player> GetEnumerator()
        {
            return Players.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Players.GetEnumerator();
        }
        public void Distributions(DeskOfCards deskOfCards)
        {
            for (int i = 0; i < 6; i++)
            {
                foreach (Player item in Players)
                {
                    item.TakeCard(deskOfCards.GetCard());
                }
            }
        }

    }
}
