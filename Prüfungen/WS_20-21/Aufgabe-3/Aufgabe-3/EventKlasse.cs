using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3
{
    class EventKlasse
    {
        private int _wert;
        /* Delegate */
        public delegate void WertGeändertHandler(EventKlasse src); 
        /* Event */
        public event WertGeändertHandler WertGeändert; 

        public int Wert
        {
            get { return _wert; }
            set 
            { 
                _wert = value;
                /* Event auslösen, davor aber checken ob Handler am Event angemeldet ist um Exceptions zu vermeiden */
                if(WertGeändert != null)
                {
                    WertGeändert(this);
                }
            }
        }
    }
}
