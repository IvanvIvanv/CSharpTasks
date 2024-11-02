using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTask
{
    public class PenguinFactory : BirdFactory
    {
        private static readonly Random rnd = new();

        public override Bird Create()
        {
            return new Penguin(
                rnd.Next(144_000, 180_000),
                rnd.Next(25, 40),
                rnd.Next(16, 24));
        }
    }
}
