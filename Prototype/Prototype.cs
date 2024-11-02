using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeTask
{
    /// <summary>
    /// Is used to copy non-struct objects while not keeping reference to original object
    /// </summary>
    public abstract class Prototype(int id)
    {
        public int id = id;

        /// <returns>New object, which is referenced by nothing, but still contains data of original</returns>
        public abstract Prototype Clone();
    }
}
