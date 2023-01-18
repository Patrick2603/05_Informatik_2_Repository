using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            EventKlasse eventKlasse = new EventKlasse();
            HandlerKlasse handlerKlasse = new HandlerKlasse();

            /* Event-Handler am Beobachter anmelden */
            eventKlasse.WertGeändert += handlerKlasse.GeänderterWert;

            eventKlasse.Wert = 10;
            Console.ReadKey(); 
        }
    }
}
