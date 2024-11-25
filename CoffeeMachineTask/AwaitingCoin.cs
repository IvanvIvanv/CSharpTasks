using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineTask
{
    internal class AwaitingCoin : State
    {
        public override State Next()
        {
            return new DrinkSelection();
        }

        public override void Start()
        {
            Console.WriteLine("Insert a coin to select the drink");
        }

        public override void Dispose()
        {
            Console.WriteLine("Coin inserted");
        }
    }
}
