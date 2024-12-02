using ConsoleRPG.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Players
{
    internal abstract class PlayerStats : UnitStats
    {
        public abstract string Name { get; }
    }
}
