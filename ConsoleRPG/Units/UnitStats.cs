using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Units
{
    internal abstract class UnitStats
    {
        public abstract int MaxHealth { get; set; }
        public abstract int Strength { get; set; }
        public abstract int CriticalChance { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new();
            stringBuilder.AppendLine("-----Stats-----");
            stringBuilder.AppendLine($"Max health: {MaxHealth}");
            stringBuilder.AppendLine($"Strength: {Strength}");
            stringBuilder.AppendLine($"CriticalChance: {CriticalChance}");
            return stringBuilder.ToString();
        }
    }
}
