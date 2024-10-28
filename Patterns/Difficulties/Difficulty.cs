using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Enemies;

namespace Patterns.Difficulties
{
    internal abstract class Difficulty
    {
        public abstract Enemy[] EnemyTypes { get; }
        public abstract int MinEnemyCount { get; }
        public abstract int MaxEnemyCount { get; }

        public static class Factory
        {
            public static Difficulty Create(int difficulty)
            {
                return difficulty switch
                {
                    1 => new Easy(),
                    2 => new Medium(),
                    3 => new Hard(),
                };
            }
        }
    }
}
