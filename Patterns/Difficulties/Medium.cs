using Patterns.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Difficulties
{
    internal class Medium : Difficulty
    {
        public override Enemy[] EnemyTypes =>
        [
            new Bee(),
            new Wolf(),
        ];

        public override int MinEnemyCount => 10;
        public override int MaxEnemyCount => 14;
    }
}
