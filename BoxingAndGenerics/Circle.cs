using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndGenerics
{
    internal class Circle<T>(Vector2 center, T radius) : Figure(center)
    {
        public T radius = radius;

        public double Area => Math.PI * Math.Pow(Convert.ToDouble(radius), 2);

        public override Vector2 MinPoint => center - new Vector2(Convert.ToSingle(radius), Convert.ToSingle(radius));
        public override Vector2 MaxPoint => center + new Vector2(Convert.ToSingle(radius), Convert.ToSingle(radius));

        public void SetRadius<T2>(T2 radius)
        {
            this.radius = (T)(object)radius!;
        }
    }
}