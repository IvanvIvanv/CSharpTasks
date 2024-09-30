using System.Text;
using VinogradovIE_CatFramework;

namespace VinogradovIE_CatApplication
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter amount of cats to generate: ");
            uint amount = uint.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("Enter saving path: ");
            string path = Console.ReadLine()!;
            Console.WriteLine();

            Cat[] cats = GenerateRandomCats(amount);
            string catInfo = DisplayCatInfo(cats);

            File.WriteAllText(path, catInfo);
        }

        private static Cat[] GenerateRandomCats(uint amount)
        {
            Cat[] cats = new Cat[amount];

            Random rnd = new();

            for (int i = 0; i < cats.Length; i++)
            {
                int catchedTimesInARow = 0;
                do
                {
                    try
                    {
                        switch (rnd.Next(0, 2))
                        {
                            case 0:
                                cats[i] = new Tiger(rnd.Next(50, 160), rnd.Next(-20, 121));
                                break;
                            case 1:
                                cats[i] = new CuteCat(rnd.Next(-20, 121));
                                break;
                        }
                    }
                    catch (CatException e)
                    {
                        catchedTimesInARow++;

                        Console.WriteLine("Catched a CatException " + catchedTimesInARow + " times in a row:");
                        Console.WriteLine(e.Message);
                        Console.WriteLine();
                    }
                }
                while (cats[i] == null);
            }

            return cats;
        }

        private static string DisplayCatInfo(Cat[] cats)
        {
            StringBuilder result = new();

            foreach (Cat cat in cats)
            {
                Console.WriteLine(cat.FluffinessCheck());
                Console.WriteLine(cat.ToString());
                Console.WriteLine();

                result.AppendLine(cat.FluffinessCheck());
                result.AppendLine(cat.ToString());
                result.AppendLine();
            }

            return result.ToString();
        }
    }
}