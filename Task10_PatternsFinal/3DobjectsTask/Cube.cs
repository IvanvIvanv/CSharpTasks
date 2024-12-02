using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3DobjectsTask
{
    internal class Cuboid(Vector3 size, Color color, Vector3 position) : Shape(color, position), IPrototype<Cuboid>
    {
        public Vector3 size = size;

        public new Cuboid Clone()
        {
            return new Cuboid(size, color, position);
        }
    }
}
