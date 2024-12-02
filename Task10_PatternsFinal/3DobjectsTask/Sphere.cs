using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3DobjectsTask
{
    internal class Sphere(float radius, Color color, Vector3 position) : Shape(color, position), IPrototype<Sphere>
    {
        public float radius = radius;

        public new Sphere Clone()
        {
            return new Sphere(radius, color, position);
        }
    }
}
