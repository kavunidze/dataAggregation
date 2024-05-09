using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Model
{
    class BackEndDev : Chatter
    {
        public BackEndDev(string name) : base(name)
        {
        }
        public override void Receive(string from, string msg)
        {
            Console.Write("To Back-end Dev: ");
            base.Receive(from, msg);
        }
    }
}
