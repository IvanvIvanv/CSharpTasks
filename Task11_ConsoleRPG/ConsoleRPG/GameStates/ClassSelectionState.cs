using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.GameStates
{
    using ConsoleRPG.Players;
    using StateMachines;

    internal class ClassSelectionState : State
    {
        private static readonly PlayerStats[] PLAYER_CLASSES =
            [
                new WarrorStats(),
                new MageStats(),
                new ArcherStats(),
            ];

        private PlayerBuilder? playerBuilder;

        public void Construct(PlayerBuilder playerBuilder)
        {
            this.playerBuilder = playerBuilder;
        }

        public override void Start()
        {
            int characterClassNum = -1;

            while (characterClassNum < 0 || characterClassNum >= PLAYER_CLASSES.Length)
            {
                for (int i = 0; i < PLAYER_CLASSES.Length; i++)
                {
                    Console.WriteLine("{0} - {1}", i, PLAYER_CLASSES[i].Name);
                }

                Console.Write("Input class of character: ");
                string input = Console.ReadLine()!;
                Console.WriteLine();

                if (!int.TryParse(input, out characterClassNum)) continue;
            }

            playerBuilder?.WithStats(PLAYER_CLASSES[characterClassNum]);
            var enemyEncounterState = stateMachine!.GetCachedState<EnemyEncounterState>();
            stateMachine!.ChangeState(enemyEncounterState);
        }
    }
}