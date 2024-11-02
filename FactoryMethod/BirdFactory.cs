using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTask
{
    //Basically a creator
    /// <summary>
    /// Inherited factories can create different variations of class objects
    /// </summary>
    public abstract class BirdFactory
    {
        /// <returns>New object created and configured by inherited factory</returns>
        public abstract Bird Create();
    }
}