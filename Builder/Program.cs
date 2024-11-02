namespace BuilderTask
{
    internal class Program
    {
        private static readonly Random rnd = new();

        static void Main()
        {
            ColorfulBrickStructureBuilder builder = new("My colorful structure");

            for (int i = 0; i < 10; i++)
            {
                int brickType = rnd.Next(3);

                switch(brickType)
                {
                    case 0: builder.AddRedBrick(); break;
                    case 1: builder.AddGreenBrick(); break;
                    case 2: builder.AddBlueBrick(); break;
                }
            }

            Console.WriteLine(builder.Result);
        }
    }
}
