namespace SmartHomeTask
{
    internal class Program
    {
        static void Main()
        {
            SmartHome smartHome = new();

            smartHome.SetupHome(SmartHome.Mode.Morning);
            Console.WriteLine();
            smartHome.SetupHome(SmartHome.Mode.Day);
            Console.WriteLine();
            smartHome.SetupHome(SmartHome.Mode.Evening);
            Console.WriteLine();
            smartHome.SetupHome(SmartHome.Mode.Night);
        }
    }
}
