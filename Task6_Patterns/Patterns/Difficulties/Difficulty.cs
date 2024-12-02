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
    }
}
