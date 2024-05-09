using MainApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Mediator
{
    abstract class AbstractChat
    {
        public abstract void Register(Chatter c);

        public abstract void Send(string from, string to, string msg);
        
    }
}
