using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    class KlasseA
    {
        private Mutex _m;
        public KlasseA(Mutex m)
        {
            _m = m;
        }

        /* 5 times A is getting printed at first. Mutex synchronises the two threads. Only one can run at a time */
        public void Methode()
        {
            _m.WaitOne();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("A");
                Thread.Sleep(1000);
            }
            _m.ReleaseMutex();
        }
    }
}
