using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Units;

namespace ConsoleRPG.Enemies
{
    internal class Enemy(UnitStats stats) : Unit(stats)
    {
        public override string Name => "Enemy";
    }
}
