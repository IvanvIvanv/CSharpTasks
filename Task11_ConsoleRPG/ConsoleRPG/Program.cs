namespace ConsoleRPG
{
    using StateMachines;
    using GameStates;

    internal class Program
    {
        static void Main()
        {
            GameStateContext context = new();
            StateMachine gameStateMachine = new([
                new NameSelectionState(context),
                new ClassSelectionState(context),
                new ClassConfirmationState(context),
                new EnemyEncounterState(context),
                new PlayerTurnState(context),
                new EnemyTurnState(context),
                new WinState(),
                new GameOverState(),
                new ExpGainState(context),
                new LevelUpState(context),
            ]);

            gameStateMachine.ChangeState<NameSelectionState>();
        }
    }
}
