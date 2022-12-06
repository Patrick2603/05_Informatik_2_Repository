using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerielleKommunikation
{
    class Zählerstandverwaltung
    {
        private List<int> _zählerVerlauf;
        private int _aktuelleID;
        private Dictionary<int, int> _produktZähler; 

        public Zählerstandverwaltung()
        {
            /* init list, dictionary, attributes */
            _zählerVerlauf = new List<int>();
            _produktZähler = new Dictionary<int, int>(); 
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

        public Dictionary<int, int> ProduktZähler
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
            /* add item to Dictionary, if ID is correct */
            if(_produktZähler.ContainsKey(_aktuelleID))
            {
                _produktZähler[_aktuelleID] += numberReset; 
            }
            else
            {
                _produktZähler.Add(_aktuelleID, numberReset); 
            }      
        }

        public void ZählerRückgängig()
        {
            /* check if List is empty */
            if (_zählerVerlauf.Count != 0)
            {
                if(_produktZähler[_aktuelleID] - _zählerVerlauf[_zählerVerlauf.Count - 1] != 0)
                {
                    _produktZähler[_aktuelleID] -= _zählerVerlauf[_zählerVerlauf.Count - 1]; 
                }
                else
                {
                    _produktZähler.Remove(_aktuelleID); 
                }
                /* remove last item in list */
                _zählerVerlauf.RemoveAt(_zählerVerlauf.Count - 1);
            }
        }

        public void UpdateID(int ID)
        {
            if(ID != _aktuelleID)
            {
                _aktuelleID = ID;
                _zählerVerlauf.Clear();
            }
        }
    }
}
