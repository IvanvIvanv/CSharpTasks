using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatTask
{
    internal class Parrot : IChatMember
    {
        public void Notify(string msg)
        {
            Console.WriteLine("Parrot: " + msg);
        }
    }
}
