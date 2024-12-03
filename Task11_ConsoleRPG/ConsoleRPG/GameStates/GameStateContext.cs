using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.GameStates
{
    using Players;
    using Enemies;

    internal class GameStateContext
    {
        public readonly PlayerBuilder playerBuilder = new();
        public Player? player;
        public Enemy? currentEnemy;
    }
}
