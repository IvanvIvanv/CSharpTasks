using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatTask
{
    internal interface IChatMember
    {
        void Notify(string msg);
    }
}
