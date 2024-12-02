using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineTask
{
    internal class DrinkDispension : State
    {
        public override State Next()
        {
            return new AwaitingCoin();
        }

        public override void Start()
        {
            Console.WriteLine("Dispensing drink...");
        }

        public override void Dispose()
        {
            Console.WriteLine("You can get your drink now");
        }
    }
}
