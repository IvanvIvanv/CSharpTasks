using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatTask
{
    internal class GroupChat : IChatMediator
    {
        private readonly List<IChatMember> chatMembers = [];

        public void Register(IChatMember chatMember)
        {
            chatMembers.Add(chatMember);
        }

        public void Unregister(IChatMember chatMember)
        {
            chatMembers.Remove(chatMember);
        }

        public void Broadcast(string msg)
        {
            foreach (IChatMember chatMember in chatMembers)
            {
                chatMember.Notify(msg);
            }
        }
    }
}
