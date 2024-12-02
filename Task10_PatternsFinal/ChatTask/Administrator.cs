using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatTask
{
    internal class Administrator(IChatMediator mediator)
    {
        public void Broadcast(string msg)
        {
            mediator.Broadcast(msg);
        }
    }
}
