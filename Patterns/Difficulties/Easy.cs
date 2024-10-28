using Patterns.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Difficulties
{
    internal class Easy : Difficulty
    {
        public override Enemy[] EnemyTypes =>
        [
            new Bee(),
        ];

        public override int MinEnemyCount => 5;
        public override int MaxEnemyCount => 7;
    }
}
