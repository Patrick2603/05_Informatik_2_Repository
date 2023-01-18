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
        public void Methode1()
        {
            _m.WaitOne();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("1");
                Thread.Sleep(100);
            }
            _m.ReleaseMutex();
        }
        public void Methode2()
        {
            _m.WaitOne();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("2");
                Thread.Sleep(100);
            }
            _m.ReleaseMutex();
        }
    }
}
