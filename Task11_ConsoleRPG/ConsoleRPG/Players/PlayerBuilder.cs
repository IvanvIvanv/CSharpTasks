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
        private PlayerStats? stats;

        public string Name => name;
        public PlayerStats? Stats => stats;

        public void WithName(string name)
        {
            this.name = name;
        }

        public void WithStats(PlayerStats stats)
        {
            this.stats = stats;
        }

        public Player Build()
        {
            return new Player(stats!, name!);
        }
    }
}
