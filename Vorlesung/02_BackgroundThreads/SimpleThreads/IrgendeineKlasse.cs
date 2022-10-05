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
        public void IrgendeineMethode()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ich bin der neue Thread...");
                Thread.Sleep(1000);
            }
        }
    }
}
