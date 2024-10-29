using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Enemies
{
    internal class Wolf : Enemy
    {
        public override Enemy Clone()
        {
            return new Wolf();
        }
    }
}
