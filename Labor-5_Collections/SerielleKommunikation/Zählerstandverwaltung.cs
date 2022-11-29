using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerielleKommunikation
{
    class Zählerstandverwaltung
    {
        private List<int> _zählerstandVerlauf; 

        public Zählerstandverwaltung()
        {
            
        }
        public List<int> Zählerstand
        {
            get
            {
                return _zählerstandVerlauf; 
            }
        }
    }
}
