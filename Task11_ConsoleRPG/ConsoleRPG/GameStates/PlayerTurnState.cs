using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.GameStates
{
    using StateMachines;

    internal class PlayerTurnState(GameStateContext context) : State
    {
        public override void Start()
        {
            Console.WriteLine("-----Player turn-----");

            int actionNum = -1;

            Console.WriteLine("0 - Attack");
            Console.WriteLine("1 - Heal 25%");

            while (actionNum < 0 || actionNum > 1)
            {
                Console.Write("Input action: ");
                string input = Console.ReadLine()!;
                Console.WriteLine();

                if (int.TryParse(input, out int inputNum)) actionNum = inputNum;
            }

            switch(actionNum)
            {
                case 0: AttackAction(); break;
                case 1: HealAction(); break;
            }
        }

        private void AttackAction()
        {
            Console.WriteLine(context.player!.Attack(context.currentEnemy!));
            Console.WriteLine();
            if (context.currentEnemy!.Health == 0) stateMachine!.ChangeState<ExpGainState>();
            else stateMachine!.ChangeState<EnemyTurnState>();
        }

        private void HealAction()
        {
            int heal = context.player!.stats.MaxHealth / 4;
            context.player.Health += heal;

            StringBuilder builder = new();
            builder.AppendLine("-----Heal results-----");
            builder.AppendLine($"{context.player.Name} received {heal} heal");
            builder.Append($"Health: {context.player.Health}/{context.player.stats.MaxHealth}");

            Console.WriteLine(builder.ToString());
            Console.WriteLine();
            stateMachine!.ChangeState<EnemyTurnState>();
        }
    }
}
