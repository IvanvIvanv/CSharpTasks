using Patterns.Difficulties;

namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input difficulty from 1 to 3");
            int difficultyNum = Convert.ToInt32(Console.ReadLine());
            var difficulty = Difficulty.Factory.Create(difficultyNum);
            Wave wave = new(difficulty);
        }
    }
}

//Реализовать создатель разных уровней сложности с рандомом количества монстров (Пчёлы, волки, медведи)
//Реализовать ввод пользователя, пользователь вводит цифру уровня сложности.
//Для первого уровня сложности есть возможность спавна только пчел, для второго пчел и волков,
//для третьего пчел, волков и медведей. Также на каждом уровне должно увеличиваться количество монстров.
