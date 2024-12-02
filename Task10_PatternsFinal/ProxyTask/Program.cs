namespace ProxyTask
{
    internal class Program
    {
        static void Main()
        {
            ProxyService proxyService = new(new RealService());
            Console.WriteLine("ProxyServiceCreated");
            Task.Delay(1000).Wait();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Getting data from service");
                Console.WriteLine(proxyService.GetData());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Getting data from service every second");
                Console.WriteLine(proxyService.GetData());
                Console.WriteLine("Data recieved");
                Task.Delay(1000).Wait();
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Getting data from service every 6 seconds");
                Console.WriteLine(proxyService.GetData());
                Console.WriteLine("Data recieved");
                Task.Delay(6000).Wait();
            }
        }
    }
}
