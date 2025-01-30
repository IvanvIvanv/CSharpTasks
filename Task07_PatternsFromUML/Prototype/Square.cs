using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeTask
{
    public class Square(int id, float size) : Prototype(id)
    {
        public float size = size; 

        public override Prototype Clone()
        {
            return new Square(id, size);
        }
    }
}
