using ConsoleRPG.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Enemies
{
    internal class EnemyStats : UnitStats
    {
        private readonly static Random RND = new();

        public override int MaxHealth { get; set; }
        public override int Strength { get; set; }
        public override int CriticalChance { get; set; }

        public EnemyStats()
        {
            MaxHealth = RND.Next(25, 125);
            Strength = RND.Next(10, 60);
            CriticalChance = RND.Next(5, 35);
        }
    }
}
