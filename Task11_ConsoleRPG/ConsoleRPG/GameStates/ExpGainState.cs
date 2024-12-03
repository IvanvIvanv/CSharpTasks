using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.GameStates
{
    using StateMachines;

    internal class ExpGainState(GameStateContext context) : State
    {
        public override void Start()
        {
            var enemyStats = context.currentEnemy!.stats;
            int expGain = enemyStats.MaxHealth + enemyStats.Strength + enemyStats.CriticalChance;

            Console.WriteLine("Enemy defeated");
            Console.WriteLine($"You have received {expGain} experience");
            context.player!.exp += expGain;
            Console.WriteLine($"Current exp: {context.player!.exp}/{context.player!.ExpForNextLevel}");
            context.player!.enemiesDefeated++;
            Console.WriteLine($"Enemies defeated: {context.player!.enemiesDefeated}/15");
            Console.WriteLine();
            if (context.player!.enemiesDefeated >= 15) stateMachine!.ChangeState<WinState>();
            else if (context.player!.exp >= context.player!.ExpForNextLevel) stateMachine!.ChangeState<LevelUpState>();
            else stateMachine!.ChangeState<EnemyEncounterState>();
        }
    }
}
