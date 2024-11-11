using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    internal class Move : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine($"I move");
        }
    }
}