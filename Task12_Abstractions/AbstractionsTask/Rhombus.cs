using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionsTask
{
    public class Rhombus : Parallelogram
    {
        public override double Perimeter => sideA * 4;
        public override double Area => sideA * sideA * Math.Sin(angleA);
    }
}