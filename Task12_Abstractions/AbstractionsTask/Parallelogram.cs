using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionsTask
{
    public class Parallelogram : Quadrilateral
    {
        public override double Perimeter => (sideA + sideB) * 2;
        public override double Area => sideA * sideB * Math.Sin(Math.PI / 180 * angleA);
    }
}