using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeTask
{
    //Functions as client
    public class CircleSplitter
    {
        private readonly Circle splittedPrototype;

        public CircleSplitter(Circle circlePrototype)
        {
            splittedPrototype = (Circle)circlePrototype.Clone();
            splittedPrototype.radius /= 2;
        }

        public Circle[] Split()
        {
            Circle[] splitCircles = new Circle[2];

            for (int i = 0; i < splitCircles.Length; i++)
            {
                splitCircles[i] = (Circle)splittedPrototype.Clone();
                splitCircles[i].id += i + 1;
            }

            return splitCircles;
        }
    }
}
