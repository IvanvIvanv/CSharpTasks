using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.StateMachines
{
    internal class StateMachine(State[] stateCache)
    {
        public State[] stateCache = stateCache;

        private State? state;

        public State? State
        {
            get => state;
            set
            {
                state?.Dispose();
                state = value;
                if (state != null) state.stateMachine = this;
                state?.Start();
            }
        }

        public void ChangeState<TState>() where TState : State
        {
            State = GetCachedState<TState>();
        }

        public void ChangeState(State state)
        {
            State = state;
        }

        public TState GetCachedState<TState>() where TState : State
        {
            for (int i = 0; i < stateCache.Length; i++)
            {
                if (stateCache[i] is not TState) continue;
                return (TState)stateCache[i];
            }
            throw new NotImplementedException();
        }
    }
}
