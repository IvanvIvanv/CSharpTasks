using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.GameStates
{
    using StateMachines;
    using Players;
    using ConsoleRPG.Enemies;

    internal class EnemyEncounterState : State
    {
        private Player? player;

        public void Construct(Player player)
        {
            this.player = player;
        }

        public override void Start()
        {
            EnemyStats enemyStats = new();

            Console.WriteLine("You have encountered an enemy");
            Console.WriteLine(enemyStats.ToString());
        }
    }
}
