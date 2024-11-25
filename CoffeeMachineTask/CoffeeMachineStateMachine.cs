using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineTask
{
    internal class CoffeeMachineStateMachine
    {
        private State? currentState = new AwaitingCoin();

        public State? CurrentState
        {
            get => currentState;
            set
            {
                currentState?.Dispose();
                currentState = value;
                currentState?.Start();
            }
        }

        public void Next()
        {
            CurrentState = CurrentState?.Next();
        }
    }
}
