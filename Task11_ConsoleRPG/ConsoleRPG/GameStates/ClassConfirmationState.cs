using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.GameStates
{
    using StateMachines;

    internal class ClassConfirmationState(GameStateContext context) : State
    {
        public override void Start()
        {
            bool? confirm = null;

            Console.WriteLine(context.playerBuilder.Stats!.ToString());

            while (!confirm.HasValue)
            {
                Console.Write("Confirm? (y/n): ");
                string input = Console.ReadLine()!;
                Console.WriteLine();
                if (input == "y") confirm = true;
                else if (input == "n") confirm = false;
            }

            if (confirm.Value) stateMachine!.ChangeState<EnemyEncounterState>();
            else stateMachine!.ChangeState<ClassSelectionState>();
        }
    }
}
