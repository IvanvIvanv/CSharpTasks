using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Players
{
    using Units;

    internal class Player(UnitStats stats, string name) : Unit(stats)
    {
        public readonly string name = name;
        public int exp = 0;
        public int level = 1;
        public int enemiesDefeated = 0;

        public override string Name => name;
        public int ExpForNextLevel => (int)Math.Pow(level * 10, 2);
    }
}
