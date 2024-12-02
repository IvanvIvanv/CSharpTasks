using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    internal class Sleep : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine($"I sleep");
        }
    }
}
