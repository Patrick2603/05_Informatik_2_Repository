using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3
{
    class Kontakt
    {
        public Kontakt(string zeile)
        {
            string[] s = datum.Split(';');
            _vorname = s[0];
            _name = s[1];
            _telNummer = s[2]; 
        }

        /* b.) */
        public override string ToString()
        {
            return _vorname + " | " + _name + " | " + _telNummer; 
        }

        public string SpeicherString()
        {
            return _vorname + ";" + _name + ";" + _telNummer; 
        }
    }
}
