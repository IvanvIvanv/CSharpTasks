using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatTask
{
    internal interface IChatMediator
    {
        void Register(IChatMember chatMember);
        void Unregister(IChatMember chatMember);
        void Broadcast(string msg);
    }
}
