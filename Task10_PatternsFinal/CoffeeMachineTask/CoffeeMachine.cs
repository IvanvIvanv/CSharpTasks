using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineTask
{
    internal class CoffeeMachine
    {
        private readonly CoffeeMachineStateMachine stateMachine = new();

        public void InsertCoin()
        {
            if (stateMachine.CurrentState is AwaitingCoin)
                stateMachine.Next();
            else throw new InvalidOperationException($"Current state is {stateMachine.CurrentState}");
        }

        public void SelectDrink()
        {
            if (stateMachine.CurrentState is DrinkSelection)
                stateMachine.Next();
            else throw new InvalidOperationException($"Current state is {stateMachine.CurrentState}");
        }

        public void DispenseDrink()
        {
            if (stateMachine.CurrentState is DrinkDispension)
                stateMachine.Next();
            else throw new InvalidOperationException($"Current state is {stateMachine.CurrentState}");
        }
    }
}
