using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Units;

namespace ConsoleRPG.Players
{
    internal class WarrorStats : PlayerStats
    {
        public override int MaxHealth { get; set; } = 100;
        public override int Strength { get; set; } = 40;
        public override int CriticalChance { get; set; } = 10;
        public override string Name => "Warrior";
    }
}
