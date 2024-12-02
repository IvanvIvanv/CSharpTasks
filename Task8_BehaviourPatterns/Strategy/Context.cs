using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    using Strategies;

    internal class Context(IStrategy strategy)
    {
        public IStrategy strategy = strategy;

        public void ExecuteAlgorithm()
        {
            strategy.Algorithm();
        }
    }
}
