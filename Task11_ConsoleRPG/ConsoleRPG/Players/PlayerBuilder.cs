using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Players
{
    internal class PlayerBuilder
    {
        private string name = string.Empty;
        private PlayerStats? playerStats;

        public void WithName(string name)
        {
            this.name = name;
        }

        public void WithStats(PlayerStats playerStats)
        {
            this.playerStats = playerStats;
        }

        public Player Build()
        {
            return new Player(playerStats!, name!);
        }
    }
}
