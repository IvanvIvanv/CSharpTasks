namespace ConsoleRPG
{
    using StateMachines;
    using GameStates;

    internal class Program
    {
        static void Main()
        {
            StateMachine gameStateMachine = new([
                new NameSelectionState(),
                new ClassSelectionState(),
                new EnemyEncounterState(),
            ]);

            gameStateMachine.ChangeState<NameSelectionState>();
        }
    }
}
