using System;
using System.Collections.Generic;
using System.Text;
using System.Threading; 

namespace Zeitgeber 
{
    internal class Zeitgeber
    {
        /* Schritt 1 */
        public delegate void TickChangedHandler(Zeitgeber source);
        /* Schritt 2 */ 
        public event TickChangedHandler TickChanged;

        /* Schritt 3 */
        public void Start()
        {
            Thread.Sleep(1000);

            if(TickChanged != null)
            {
                TickChanged(this);
            }
        }
    }
}
