using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.StateMachines
{
    internal abstract class State : IDisposable
    {
        public StateMachine? stateMachine;

        public virtual void Start()
        {
            //Optionally overriden
        }

        public virtual void Dispose()
        {
            //Optionally overriden
        }
    }
}
