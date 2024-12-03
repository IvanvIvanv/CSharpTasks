using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Units
{
    internal struct AttackResults
    {
        public bool wasCritical;
        public int damageDealt;
        public int targetMaxHealth;
        public int targetCurrentHealth;
        public string targetName;

        public override string ToString()
        {
            StringBuilder builder = new();
            builder.AppendLine("-----Attack results-----");
            if (wasCritical) builder.AppendLine("Critical hit!");
            builder.AppendLine($"{targetName} received {damageDealt} damage");
            builder.Append($"Health: {targetCurrentHealth}/{targetMaxHealth}");
            return builder.ToString();
        }
    }
}
