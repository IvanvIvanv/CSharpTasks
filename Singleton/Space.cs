using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTask
{
    public class Space
    {
        public float volume;

        private static Space? instance;

        public static Space Instance
        {
            get
            {
                instance ??= new Space();
                return instance;
            }
        }
    }
}