using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Units;

namespace ConsoleRPG.Players
{
    internal class MageStats : PlayerStats
    {
        public override int MaxHealth { get; set; } = 80;
        public override int Strength { get; set; } = 20;
        public override int CriticalChance { get; set; } = 40;
        public override string Name => "Mage";
    }
}
