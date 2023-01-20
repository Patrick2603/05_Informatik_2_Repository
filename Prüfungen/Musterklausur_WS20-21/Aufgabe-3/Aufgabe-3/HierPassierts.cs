using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3
{
    class HierPassierts
    {
        private int _x;
        private int _y;
        
        public delegate void WertGeändertHandler(HierPassierts quelle, string name); 
        public event WertGeändertHandler WertGeändert; 

        public HierPassierts(int x, int y)
        {
            _x = x;
            _y = y; 
        }

        public int x
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
                OnWertGeändertChanged(this, x); 
            }
        }

        public int y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
                OnWertGeändertChanged(this, y);
            }
        }

        private void OnWertGeändertChanged(string s)
        {
            if(WertGeändert != null)
            {
                WertGeändert(this, s);
            }
        }

    }
}
