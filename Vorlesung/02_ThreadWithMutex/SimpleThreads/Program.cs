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
            /* create new Mutex object */ 
            Mutex mutex = new Mutex();
            
            IrgendeineKlasse obj = new IrgendeineKlasse(mutex);
            Thread neuerThread = new Thread(obj.IrgendeineMethode);
            neuerThread.Start();

            /* blockiert den aktuellen Thread */
            /* wird zb verwendet wenn man eine Datei öffnet um diese bearbeiten dann kann mit einem Mutex dies blockiert werden */
            mutex.WaitOne();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Der alte Thread läuft weiter...");
                Thread.Sleep(1000);
            }

            /* gibt den Mutex wieder frei */
            mutex.ReleaseMutex();
        }
    }
}
