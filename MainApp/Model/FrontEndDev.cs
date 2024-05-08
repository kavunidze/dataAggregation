using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Model
{
    class FrontEndDev : Chatter
    {
        public FrontEndDev(string name) : base(name)
        {
        }

        public override void Receive(string from, string msg)
        {
            Console.Write("To Front-end Dev: ");
            base.Receive(from, msg);
        }
    }
}
