namespace AbstractionsTask
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<ITetragon> tetragons = [new Quadrilateral(), new Square(), new Rhombus()];

            foreach (var tetragon in tetragons)
            {
                Console.WriteLine(tetragon.Area);
            }
        }
    }
}