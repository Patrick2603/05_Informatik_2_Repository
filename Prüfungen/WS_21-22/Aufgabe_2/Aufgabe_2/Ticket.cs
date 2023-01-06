using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    class Ticket
    {
        /* a.) */
        private int _nummer;
        private string _beschreibung;
        private int _status; 
        
        /* Constructor */
        public Ticket(int Ticketnummer, string Beschreibung)
        {
            _nummer = Ticketnummer;
            _beschreibung = Beschreibung;
            _status = 0; 
        }

        /* Properties */
        public int Nummer
        {
            get { return _nummer; } 
        }
        public string Beschreibung
        {
            get { return _beschreibung;  }
        }
        public int Status
        {
            get { return _status;  }
            set { _status = value;  }
        }

        /* Override function */
        public override string ToString()
        {
            return Nummer.ToString() + "; " + Beschreibung + "; " + Status.ToString();
        }
    }
}
