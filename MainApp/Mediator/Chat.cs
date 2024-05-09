using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainApp.Model;

namespace MainApp.Mediator
{
    class Chat : AbstractChat
    {
        private Dictionary<string, Chatter> _chatters =
            new Dictionary<string, Chatter>();

        public override void Register(Chatter c)
        {
            if (!_chatters.ContainsValue(c))
            {
                _chatters[c.Name] = c;
            }
            c._Chat = this;
        }

        public override void Send(string from, string to, string msg)
        {
            Chatter chatter = _chatters[to];
            if (chatter != null)
            {
                chatter.Receive(from, msg);
            }
        }

    }
}
