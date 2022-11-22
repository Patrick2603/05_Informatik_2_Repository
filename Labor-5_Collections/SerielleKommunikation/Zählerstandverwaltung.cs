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

        public Zählerstandverwaltung()
        {
            //init _zählerVerlauf 
            //_zählerVerlauf; 
        }

        public List<int> Zählerverlauf
        {
            get
            {
                return _zählerVerlauf;
            }
        }

        public List<int> ZählerHinzufügen()
        {
            List.add(_zählerVerlauf);
        }
    }
}
