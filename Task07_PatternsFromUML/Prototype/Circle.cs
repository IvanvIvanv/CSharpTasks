using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeTask
{
    public class Circle(int id, float radius) : Prototype(id)
    {
        public float radius = radius; 

        public override Prototype Clone()
        {
            return new Circle(id, radius);
        }

        public override string ToString()
        {
            return $"id: {id}, radius: {radius}";
        }
    }
}
