using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3
{
    class Beobachter
    {
        private void Handler(HierPassierts quelle, string name)
        {
            switch(name)
            {
                case "x":
                    Console.WriteLine(quelle);
                    break;
                case "y":
                    Console.WriteLine(quelle);
                    break; 
            }
        }


    }
}
