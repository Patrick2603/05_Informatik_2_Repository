using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 

namespace Zeitgeber
{
    class Zeitgeber
    {
        public delegate void TickDelegate(Zeitgeber quelle);
        public event TickDelegate Tick;

        public void Start()
        {
            while (true)
            {
                Thread.Sleep(1000);

                if (Tick != null)
                {
                    Tick(this);
                }
            }
        }
    }
}
