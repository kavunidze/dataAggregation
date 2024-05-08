using MainApp.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Model
{
    class Chatter
    {
        public AbstractChat _Chat { get; set; }
        public string Name { get; set; }

        public Chatter(string name)
        {
            Name = name;
        }

        public void Send(string to, string msg)
        {
            _Chat.Send(Name, to, msg);
        }

        public virtual void Receive(string from, string msg)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, Name, msg);
        }
    }
}
