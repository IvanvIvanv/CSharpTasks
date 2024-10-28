using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndGenerics
{
    public class Rectangle<T1, T2>(Vector2 center, T1 width, T2 height) : Figure(center)
    {
        public T1? width = width;
        public T2? height = height;

        public override Vector2 MinPoint => center - new Vector2(Convert.ToSingle(width), Convert.ToSingle(height));
        public override Vector2 MaxPoint => center + new Vector2(Convert.ToSingle(width), Convert.ToSingle(height));
    }
}
