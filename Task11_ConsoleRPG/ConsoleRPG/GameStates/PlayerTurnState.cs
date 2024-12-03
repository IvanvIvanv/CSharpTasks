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
        //TODO: Add this state to StateMachine in program and add name to unit
        public override void Start()
        {
            Console.WriteLine("-----Player turn-----");

            int actionNum = -1;

            while (actionNum < 0 || actionNum > 1)
            {
                Console.WriteLine("0 - Attack");
                Console.WriteLine("1 - Heal 25%");
                Console.Write("Input action: ");
                string input = Console.ReadLine()!;
                Console.WriteLine();

                if (!int.TryParse(input, out actionNum)) continue;
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
        }

        private void HealAction()
        {
            int heal = context.player!.stats.MaxHealth / 4;
            context.player.Health += heal;

            StringBuilder builder = new();
            builder.AppendLine("-----Heal results-----");
            builder.AppendLine($"Target received {heal} heal");
            builder.Append($"Health: {context.player.Health}/{context.player.stats.MaxHealth}");

            Console.WriteLine(builder.ToString());
        }
    }
}
