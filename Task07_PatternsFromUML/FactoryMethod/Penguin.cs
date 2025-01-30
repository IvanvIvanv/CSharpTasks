using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTask
{
    public class Penguin(int featherCount, float mass, float slideSpeed) : Bird(featherCount, mass)
    {
        public float slideSpeed = slideSpeed;

        public void Slide()
        {
            Console.WriteLine($"Penguin slides with speed of {slideSpeed}");
        }
    }
}
