using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerielleKommunikation
{
    class Zählerstandverwaltung
    {
        private List<int> _zählerVerlauf = new List<int>();
        private int _aktuelleID;
        private Dictionary<string, int> _produktZähler = new Dictionary<string, int>(); 

        public Zählerstandverwaltung()
        {
            /* init list, dictionary, attributes */
            List<int> _zählerVerlauf = new List<int>();
            Dictionary<string, int> _produktZähler = new Dictionary<string, int>(); 
            _aktuelleID = -1;
        }

        public List<int> Zählerstand
        {
            get
            {
                return _zählerVerlauf;
            }
        }

        public int AktuelleID
        {
            get
            {
                return _aktuelleID;
            }
            set
            {
                _aktuelleID = value;
            }
        }

        public Dictionary<string, int> ProduktZähler
        {
            get
            {
                return _produktZähler; 
            }
        }


        public void ZählerHinzufügen(int numberReset)
        {
            /* add item to List */
            _zählerVerlauf.Add(numberReset);
            _produktZähler[_aktuelleID] = ;  
        }

        public void ZählerRückgängig()
        {
            /* check if List is empty */
            if (_zählerVerlauf.Count != 0)
            {
                /* remove last item in list */
                _zählerVerlauf.RemoveAt(_zählerVerlauf.Count - 1);
            }
        }

        public void UpdateID(int ID)
        {
            _aktuelleID = ID;
            _zählerVerlauf.Clear();
        }

    }
}
