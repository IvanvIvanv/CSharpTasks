using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Difficulties;
using Patterns.Enemies;

namespace Patterns
{
    internal class Wave
    {
        private readonly Random rnd = new();
        private readonly Enemy[] enemies;

        public Wave(Difficulty difficulty)
        {
            int enemyCount = rnd.Next(difficulty.MinEnemyCount, difficulty.MaxEnemyCount + 1);
            enemies = new Enemy[enemyCount];

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = difficulty.EnemyTypes[rnd.Next(0, difficulty.EnemyTypes.Length)].Clone();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Enemy count: {enemies.Length}");
            sb.AppendLine();

            for (int i = 0; i < enemies.Length; i++)
            {
                sb.AppendLine($"Enemy {i + 1}: {enemies[i].GetType().Name}");
            }

            return sb.ToString();
        }
    }
}
