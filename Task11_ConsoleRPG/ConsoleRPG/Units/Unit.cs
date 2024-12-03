using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Units
{
    internal abstract class Unit
    {
        private static readonly Random RND = new();

        public readonly UnitStats stats;

        private int health;

        public Unit(UnitStats stats)
        {
            this.stats = stats;
            Health = stats.MaxHealth;
        }

        public abstract string Name { get; }

        public int Health
        {
            get => health;
            set
            {
                health = value;
                if (health > stats.MaxHealth) health = stats.MaxHealth;
                else if (health < 0) health = 0;
            }
        }

        public virtual AttackResults Attack(Unit target)
        {
            bool isCritical = RND.Next(0, 101) < stats.CriticalChance;
            int damage = stats.Strength;
            if (isCritical) damage *= 3;
            target.Health -= damage;

            return new()
            {
                wasCritical = isCritical,
                damageDealt = damage,
                targetMaxHealth = target.stats.MaxHealth,
                targetCurrentHealth = target.Health,
                targetName = target.Name,
            };
        }
    }
}
