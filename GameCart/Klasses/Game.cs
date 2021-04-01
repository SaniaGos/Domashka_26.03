using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCart.Klasses
{
    class Game
    {
        public AllPlayers Players { get; private set; }
        public Recoil Recoil { get; set; }
        public Card Trump { get; private set; }
        public DeskOfCards DeskOfCards { get; set; }
        public Game(int numOfPlayer)
        {
            DeskOfCards = new DeskOfCards();
            Recoil = new Recoil();
            Players = new AllPlayers(numOfPlayer);
        }
        public void StartGame()
        {
            Players.Distributions(DeskOfCards); // роздаєм карти
            Trump = DeskOfCards.GetCard();      // берем козир
        }
    }
}
