using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Units;

namespace ConsoleRPG.Players
{
    internal class ArcherStats : PlayerStats
    {
        public override int MaxHealth { get; set; } = 60;
        public override int Strength { get; set; } = 30;
        public override int CriticalChance { get; set; } = 20;
        public override string Name => "Archer";
    }
}
