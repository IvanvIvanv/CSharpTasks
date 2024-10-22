using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BoxingAndGenerics
{
    public class Defaultable<T>(T value)
    {
        public T? value = value;

        public T Reset()
        {
            value = default;
            return value!;
        }
    }
}
