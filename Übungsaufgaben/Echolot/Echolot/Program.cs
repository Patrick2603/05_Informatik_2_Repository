using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 

namespace Echolot
{
    class Program
    {
        static void Main(string[] args)
        {
            Geräusch g = new Geräusch(); 

            Thread pingThread = new Thread(g.Ping);
            pingThread.IsBackground = true;
            pingThread.Start();

            Thread pongThread = new Thread(g.Pong);
            pongThread.IsBackground = true;
            pongThread.Start();

            Thread.Sleep(1000);
            Console.ReadLine(); 
        }
    }
}
