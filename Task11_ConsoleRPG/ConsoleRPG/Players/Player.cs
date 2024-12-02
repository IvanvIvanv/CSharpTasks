using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Units;

namespace ConsoleRPG.Players
{
    internal class Player(UnitStats stats, string name) : Unit(stats)
    {
        public readonly string name = name;
        public int exp = 0;
    }
}
