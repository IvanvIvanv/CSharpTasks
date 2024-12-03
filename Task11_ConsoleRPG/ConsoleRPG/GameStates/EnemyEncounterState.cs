using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.GameStates
{
    using StateMachines;
    using Enemies;

    internal class EnemyEncounterState(GameStateContext context) : State
    {
        public override void Start()
        {
            EnemyStats enemyStats = new();
            Console.WriteLine("You have encountered an enemy");
            Console.WriteLine(enemyStats.ToString());
            context.currentEnemy = new Enemy(enemyStats);
        }
    }
}
