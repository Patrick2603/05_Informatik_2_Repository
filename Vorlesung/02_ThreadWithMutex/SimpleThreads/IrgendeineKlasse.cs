using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleThreads
{
    class IrgendeineKlasse
    {
        public IrgendeineKlasse(Mutex m)
        {
            _mutex = m;
        }
        
        public void IrgendeineMethode()
        {
            _mutex.WaitOne();
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ich bin der neue Thread...");
                Thread.Sleep(1000);
            }

            _mutex.ReleaseMutex();
        }

        private Mutex _mutex;
    }
}
