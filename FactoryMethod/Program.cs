namespace FactoryMethodTask
{
    internal class Program
    {
        private static void Main()
        {
            PenguinFactory penguinFactory = new();
            Penguin penguin = (Penguin)penguinFactory.Create();
            penguin.Slide();
            Console.WriteLine(penguin.featherCount);

            SparrowFactory sparrowFactory = new();
            Sparrow sparrow = (Sparrow)sparrowFactory.Create();
            sparrow.Fly();
        }
    }
}