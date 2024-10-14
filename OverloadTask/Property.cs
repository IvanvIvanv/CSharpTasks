using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadTask
{
    public abstract class Property(float worth)
    {
        public float worth = worth;

        public abstract float CalculateTax();
    }
}