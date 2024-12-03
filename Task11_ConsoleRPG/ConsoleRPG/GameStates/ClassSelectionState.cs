using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.GameStates
{
    using ConsoleRPG.Players;
    using StateMachines;
    using System.Diagnostics;

    internal class ClassSelectionState(GameStateContext context) : State
    {
        private static readonly PlayerStats[] PLAYER_CLASSES =
            [
                new WarrorStats(),
                new MageStats(),
                new ArcherStats(),
            ];

        public override void Start()
        {
            int characterClassNum = -1;

            while (characterClassNum < 0 || characterClassNum >= PLAYER_CLASSES.Length)
            {
                for (int i = 0; i < PLAYER_CLASSES.Length; i++)
                {
                    Console.WriteLine("{0} - {1}", i, PLAYER_CLASSES[i].Name);
                }

                Console.Write("Input class of character to view it's stats: ");
                string input = Console.ReadLine()!;
                Console.WriteLine();

                if (int.TryParse(input, out int inputNum)) characterClassNum = inputNum;
            }

            context.playerBuilder!.WithStats(PLAYER_CLASSES[characterClassNum]);
            context.player = context!.playerBuilder!.Build();
            stateMachine!.ChangeState<ClassConfirmationState>();
        }
    }
}