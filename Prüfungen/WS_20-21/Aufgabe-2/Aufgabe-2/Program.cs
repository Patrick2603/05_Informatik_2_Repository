using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex x = new Mutex();
            KlasseA o = new KlasseA(x);
            /* new Thread is getting started and because of Sleep it is executed first */
            Thread t = new Thread(o.Methode);
            t.Start();
            Thread.Sleep(500);

            /* mutex blocks it so no one else can access it until it is getting released */
            x.WaitOne();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("B");
                Thread.Sleep(2000);
            }
            x.ReleaseMutex();
        }
    }
}
