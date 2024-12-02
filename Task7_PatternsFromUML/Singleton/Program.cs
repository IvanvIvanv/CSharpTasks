namespace SingletonTask
{
    internal class Program
    {
        static void Main()
        {
            Space.Instance.volume = 100;
            Console.WriteLine(Space.Instance.volume);
        }
    }
}
