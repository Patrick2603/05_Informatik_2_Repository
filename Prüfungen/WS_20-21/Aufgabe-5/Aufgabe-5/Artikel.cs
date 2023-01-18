using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_5
{
    class Artikel
    {
        private string _bezeichnung;
        public Artikel(string bezeichnung)
        {
            _bezeichnung = bezeichnung;
        }

        public string Bezeichnung
        {
            get
            {
                return _bezeichnung;
            }
        }
    }
}
