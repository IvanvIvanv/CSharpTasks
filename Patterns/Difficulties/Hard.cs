using Patterns.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Difficulties
{
    internal class Hard : Difficulty
    {
        public override Enemy[] EnemyTypes =>
        [
            new Bee(),
            new Wolf(),
            new Bear(),
        ];

        public override int MinEnemyCount => 20;
        public override int MaxEnemyCount => 28;
    }
}
