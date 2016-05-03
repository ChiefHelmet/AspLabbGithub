using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_21.Models
{
    public class TwentyOne
    {
        public int Sum { get; set; }

        public Player ActivePlayer { get; set; }

        public List<Player> Players { get; set; }

        public TwentyOne(List<Player> players)
        {
            Players = players;

            var random = new Random();

            ActivePlayer = Players[random.Next(0,Players.Count - 1)];
        }

        public bool GameOn(int number)
        {
            Sum += number;

            ActivePlayer.Moves++;

            if (Sum >= 21)
            {
                return false;
            }

            var playerIndex = Players.IndexOf(ActivePlayer);

            if (playerIndex >= Players.Count - 1)
            {
                ActivePlayer = Players[0];
            }
            else
            {
                ActivePlayer = Players[playerIndex + 1];
            }

            return true;
        }
    }
}
