using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3
{
    class Lüfter
    {
        private bool _isRunning = false; 
        
        /* Eventhandler */
        public void LüfterEin()
        {
            _isRunning = true;
        }
    }
}
