using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3
{
    class HandlerKlasse
    {
        /* Event-Handler mit Signatur so wie es der Delegatetyp fordert */
        public void GeänderterWert(EventKlasse src)
        {
            Console.WriteLine(src.Wert);
        }
    }
}
