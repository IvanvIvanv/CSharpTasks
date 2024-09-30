using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndGenerics
{
    public abstract class Figure(Vector2 center)
    {
        public Vector2 center = center;

        public abstract Vector2 MinPoint { get; }
        public abstract Vector2 MaxPoint { get; }
    }
}
