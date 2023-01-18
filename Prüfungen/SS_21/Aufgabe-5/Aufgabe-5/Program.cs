using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Aufgabe_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(3);
            /* oke chatGPT hatte doch nicht recht: Es wird zb eine List erstellt { 1, 2, 3, 4 } diese besitzt vier Elemente und jetzt an der Vorletzten stellte etwas hinzuschreiben: 
             Anzahl 4 - 2 = Index 2 -> vorletzte */ 
            list.Insert(list.Count - 2, 2); 
        }
    }
}
