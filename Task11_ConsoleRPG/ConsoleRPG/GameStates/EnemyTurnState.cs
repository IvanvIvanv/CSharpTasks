using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.GameStates
{
    using StateMachines;

    internal class EnemyTurnState(GameStateContext context) : State
    {
        public override void Start()
        {
            Console.WriteLine("-----Enemy turn-----");
            var attackResults = context.currentEnemy!.Attack(context.player!);
            Console.WriteLine(attackResults);
            Console.WriteLine();
            if (context.player!.Health == 0) stateMachine!.ChangeState<GameOverState>();
            else stateMachine!.ChangeState<PlayerTurnState>();
        }
    }
}
