using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb2_21.Models;

namespace Labb2TicTacToe.Models
{
    public class TicTacToe
    {
        public Player ActivePlayer { get; set; }

        public List<Player> Players { get; set; }

        public List<Move> Moves { get; set; } = new List<Move>();

        public bool Tie { get; set; } = false;



        public TicTacToe(List<Player> players )
        {
            Players = players;
            
            ActivePlayer = Players[new Random().Next(0, Players.Count)];
        }

        internal bool GameOn(int input)
        {
            Moves.Add(new Move(ActivePlayer.Symbol, input)); // Lägg till spelarens drag i moves-listan

            ActivePlayer.Moves++;                           // Räknar hur många drag spelaren har gjort

            //TODO: Implementera vinst-koll.



            if (Moves.Count >= 9)
            {
                Tie = true;

                return false;
            }

            ActivePlayer =
                Players[Players.IndexOf(ActivePlayer) + 1 >= Players.Count ? 0 : Players.IndexOf(ActivePlayer) + 1];    // Tar nästa spelare i listan, om aktiv spelare är sist, ta första.

            //var playerIndex = Players.IndexOf(ActivePlayer);

            //var lastPlayer = playerIndex >= Players.Count - 1;

            //var newPlayerIndex = 0;

            //if (!lastPlayer)
            //{
            //    newPlayerIndex = playerIndex + 1;
            //}

            //ActivePlayer = Players[newPlayerIndex];

            return true;
        }
    }
}
