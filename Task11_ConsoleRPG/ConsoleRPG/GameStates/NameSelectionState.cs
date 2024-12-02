using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.GameStates
{
    using ConsoleRPG.Players;
    using StateMachines;

    internal class NameSelectionState : State
    {
        private readonly PlayerBuilder playerBuilder = new();

        public override void Start()
        {
            Console.Write("Input name of character: ");
            string input = Console.ReadLine()!;
            Console.WriteLine();
            playerBuilder.WithName(input);
            var classSelectionState = stateMachine!.GetCachedState<ClassSelectionState>();
            classSelectionState.Construct(playerBuilder);
            stateMachine!.ChangeState(classSelectionState);
        }
    }
}
