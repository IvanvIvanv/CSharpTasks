using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatTask
{
    internal class Dog : IChatMember
    {
        public void Notify(string msg)
        {
            Console.WriteLine("Dog: *Wiggles tail");
        }
    }
}
