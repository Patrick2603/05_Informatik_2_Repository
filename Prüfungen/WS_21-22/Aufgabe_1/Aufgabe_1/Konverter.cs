using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    class Konverter
    {
        private Form1 _form1;
        private int _aktLeistung;

        /* d.) */
        public Konverter(Form1 form1)
        {
            _form1 = form1; 
        }

        public int AktLeistung
        {
            get
            {
                return _aktLeistung;
            }
            set
            {
                _aktLeistung = value;
                /* Error because the class Module is not implemented, connection with server is done is that */
                form1.SchreibeLeistung(value);
            }
        }
    }
}
