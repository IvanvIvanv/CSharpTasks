namespace PrototypeTask
{
    internal class Program
    {
        private static void Main()
        {
            Circle original = new(0, 8);
            CircleSplitter circleSplitter = new(original);
            Circle[] splitCircles = circleSplitter.Split();

            Console.WriteLine(original.ToString());
            Console.WriteLine(splitCircles[0].ToString());
            Console.WriteLine(splitCircles[1].ToString());
        }
    }
}