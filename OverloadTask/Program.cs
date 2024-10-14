using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace OverloadTask
{
    internal class Program
    {
        private static void Main()
        {
            Property[] properties =
            {
                new Appartment(6000, 200),
                new Appartment(4000, 300),
                new Appartment(3000, 400),
                new Car(6000, 200),
                new Car(4000, 300),
                new Car(3000, 400),
                new Boat(4000, 300),
                new Boat(3000, 400),
                new Countryhouse(4000, 300),
                new Countryhouse(3000, 400),
            };

            Array.ForEach(properties, property => Console.WriteLine(property.ToString()));
        }
    }
}
