using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.GameStates
{
    using StateMachines;

    internal class LevelUpState(GameStateContext context) : State
    {
        public override void Start()
        {
            context.player!.exp -= context.player.ExpForNextLevel;
            context.player!.level++;
            Console.WriteLine($"You have achieved level {context.player!.level}");
            Console.WriteLine("Select stat to upgrade");

            int statNum = -1;

            while (statNum < 0 || statNum > 2)
            {
                Console.WriteLine("0 - +10 Max health");
                Console.WriteLine("1 - +5 Strength");
                Console.WriteLine("2 - +3 Critical chance");
                Console.Write("Input stat: ");
                string input = Console.ReadLine()!;
                Console.WriteLine();

                if (int.TryParse(input, out int inputNum)) statNum = inputNum;
            }

            switch (statNum)
            {
                case 0: context.player.stats.MaxHealth += 10; context.player.Health += 10; break;
                case 1: context.player.stats.Strength += 5; break;
                case 2: context.player.stats.CriticalChance += 3; break;
            }

            Console.WriteLine(context.player!.stats.ToString());
            Console.WriteLine();
            stateMachine!.ChangeState<EnemyEncounterState>();
        }
    }
}
