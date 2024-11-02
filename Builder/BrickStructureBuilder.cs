using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTask
{
    /// <summary>
    /// Allows creation of objects with optional properties
    /// </summary>
    public abstract class BrickStructureBuilder(string name)
    {
        protected BrickStructure brickStructure = new(name);

        public BrickStructure Result => brickStructure;
    }
}
