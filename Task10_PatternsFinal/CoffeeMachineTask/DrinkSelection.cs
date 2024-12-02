using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineTask
{
    internal class DrinkSelection : State
    {
        public override State Next()
        {
            return new DrinkDispension();
        }

        public override void Start()
        {
            Console.WriteLine("Please, select a drink");
        }

        public override void Dispose()
        {
            Console.WriteLine("Drink selected");
        }
    }
}
