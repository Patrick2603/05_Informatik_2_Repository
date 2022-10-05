using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            IrgendeineKlasse obj = new IrgendeineKlasse();
            Thread neuerThread = new Thread(obj.IrgendeineMethode);
            neuerThread.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Der alte Thread läuft weiter...");
                Thread.Sleep(1000);
            }
        }
    }
}
