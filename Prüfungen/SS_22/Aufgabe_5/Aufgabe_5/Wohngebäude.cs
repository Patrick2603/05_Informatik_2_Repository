using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_5
{
    class Wohngebäude
    {
        private int _anzahlWohnungen;
        private Wohnung[] _wohnungen;
        private double _hausgeld;
        double _hausgeldpP; //pro Person

        /* a.) */
        /* Event */
        public event PropertyChangedHandler MieterGeändert;
        /* Delegate */
        public delegate void PropertyChangedHandler(); 

        
        public Wohngebäude(int anzWhg, double hg)
        {
            _anzahlWohnungen = anzWhg;
            _hausgeld = hg;
            _wohnungen = new Wohnung[anzWhg];
            /* b.) */
            MieterGeändert += HausgeldpP_Berechnen; 
        }

        public Wohnung[] Wohnungen
        {
            get { return _wohnungen;  }
            set { _wohnungen = value; }
        }

        private void HausgeldpP_Berechnen()
        {
            int summe = 0; 
            foreach(Wohnung w in _wohnungen)
            {
                summe += w.Mieter.Count; 
            }
            _hausgeldpP = _hausgeld / summe; 
        }

        public void NeuerMieter(Person p, int nummer)
        {
            int s = _wohnungen[nummer].MieterHinzufügen(p); 
            /* c.) */
            /* check if mieter is getting added correct in function MieterHinzufügen && check if event is existing */
            if((s != -1) && MieterGeändert != null)
            {
                /* execute Event */
                MieterGeändert(); 
            }
        }

        public void PrintAktKosten(int nr)
        {
            double hausgeldGes = _hausgeldpP * _wohnungen[nr].Mieter.Count;
            double kosten = hausgeldGes + _wohnungen[nr].Miete;
            Console.WriteLine("Kosten für Whg Nr." + nr + ": " + kosten);
        }
    }
}
