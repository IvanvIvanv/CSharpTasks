using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTask
{
    public class Sparrow(int featherCount, float mass, float flightSpeed) : Bird(featherCount, mass)
    {
        public float flightSpeed = flightSpeed;

        public void Fly()
        {
            Console.WriteLine($"Sparrow flies with speed of {flightSpeed}");
        }
    }
}