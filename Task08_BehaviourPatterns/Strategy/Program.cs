namespace Strategy
{
    using Strategies;

    internal class Program
    {
        static void Main()
        {
            Context context = new(new Sleep());
            context.ExecuteAlgorithm();

            context.strategy = new Move();
            context.ExecuteAlgorithm();

            context.strategy = new Eat();
            context.ExecuteAlgorithm();
        }
    }
}
