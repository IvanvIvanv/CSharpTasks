using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineTask
{
    internal abstract class State : IDisposable
    {
        public abstract State Next();

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
