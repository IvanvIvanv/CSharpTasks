using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.GameStates
{
    using StateMachines;

    internal class GameOverState : State
    {
        public override void Start()
        {
            Console.WriteLine("You lost!");

            bool? confirm = null;

            while (!confirm.HasValue)
            {
                Console.WriteLine("Restart? (y/n)");
                string input = Console.ReadLine()!;
                Console.WriteLine();
                if (input == "y") confirm = true;
                else if (input == "n") confirm = false;
            }

            if (confirm.Value) stateMachine!.ChangeState<NameSelectionState>();
        }
    }
}
