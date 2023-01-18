using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList l = new ArrayList();
            l.Add(new Artikel("A"));
            l.Add(new Artikel("B"));
            l.Add(new Artikel("C"));

            foreach(object o in l)
            {
                /* Downcast */
                Artikel s = o as Artikel;
                /* Get value from Property */
                Console.WriteLine(s.Bezeichnung);
            }
            
        }
    }
}
