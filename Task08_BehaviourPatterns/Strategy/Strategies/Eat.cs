using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    internal class Eat : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("I eat");
        }
    }
}
