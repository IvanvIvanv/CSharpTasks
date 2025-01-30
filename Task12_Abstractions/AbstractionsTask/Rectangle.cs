using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionsTask
{
    public class Rectangle : Parallelogram
    {
        public override double Area => sideA * sideB;
    }
}
