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
        private Dictionary<string, int> 

        public Zählerstandverwaltung()
        {
            /* init list */
            List<int> _zählerVerlauf = new List<int>(); 
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


        public void ZählerHinzufügen(int numberReset)
        {
            /* add item to List */
            _zählerVerlauf.Add(numberReset); 
        }
        
        public void ZählerRückgängig()
        {
            /* check if List is empty */
            if(_zählerVerlauf.Count != 0)
            {
                /* remove last item in list */
                _zählerVerlauf.RemoveAt(_zählerVerlauf.Count - 1);
            }
        }

        //public int UpdateID(int ID)
        //{

        //}


    }
}
