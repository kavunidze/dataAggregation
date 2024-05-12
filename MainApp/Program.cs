using MainApp.Mediator;
using MainApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Chat chat = new Chat();

            Chatter Asmodei = new FrontEndDev("Asmodei");
            Chatter Boryssey = new FrontEndDev("Boryssey");
            Chatter Igor = new BackEndDev("Igor");
            Chatter Idk = new BackEndDev("Idk");

            chat.Register(Asmodei);
            chat.Register(Boryssey);
            chat.Register(Igor);
            chat.Register(Idk);

            Asmodei.Send("Boryssey", "Privet");
            Boryssey.Send("Asmodei", "Nu privet");
            Igor.Send("Idk", "Who are you?");
            Idk.Send("Igor", "Idk!");
            Console.ReadKey();
        }
    }
}
