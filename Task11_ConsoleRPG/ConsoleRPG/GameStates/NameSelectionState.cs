using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.GameStates
{
    using StateMachines;

    internal class NameSelectionState(GameStateContext context) : State
    {
        public override void Start()
        {
            Console.Write("Input name of character: ");
            string input = Console.ReadLine()!;
            Console.WriteLine();
            context.playerBuilder.WithName(input);
            stateMachine!.ChangeState<ClassSelectionState>();
        }
    }
}
