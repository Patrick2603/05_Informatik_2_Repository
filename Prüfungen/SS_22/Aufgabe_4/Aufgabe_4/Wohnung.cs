using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_4
{
    class Wohnung
    {
        private double _miete;
        /* a.) */
        private Person _vermieter; 
        private List<Person> _mieter;
        
        public Wohnung(double miete, Person vermieter)
        {
            _vermieter = vermieter;
            _miete = miete;
            /* b.) */
            _mieter = new List<Person>(); 
        }

        public double Miete
        {
            get { return _miete; }
        }

        /* c.) */
        public List<Person> Mieter
        {
            get { return _mieter; }
        }

        /* d.) */
        public int MieterHinzufügen(Person p)
        {
            /* check if Anzahl Mieter >= 5 && Person schon in Liste enthalten */
            if(_mieter.Count < 5 && _mieter.Contains(p) == false)
            {
                /* add Person to List */
                _mieter.Add(p);
                /* return number of Mieter */
                return _mieter.Count;
            }
            else
            {
                return -1; 
            }
        }
    }
}
