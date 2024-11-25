using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3DobjectsTask
{
    internal class Shape(Color color, Vector3 position) : IPrototype<Shape>
    {
        public Color color = color;
        public Vector3 position = position;

        public Shape Clone()
        {
            return new Shape(color, position);
        }
    }
}
