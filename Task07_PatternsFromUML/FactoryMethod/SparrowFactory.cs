using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTask
{
    internal class SparrowFactory : BirdFactory
    {
        private static readonly Random rnd = new();

        public override Bird Create()
        {
            return new Sparrow(
                rnd.Next(3_000, 4_000),
                rnd.Next(24, 40) / 1000,
                rnd.Next(40, 50));
        }
    }
}
