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
            /* ist das wirkich -2, nicht -2 sogar chatGPT sagt das */
            list.Insert(list.Count - 1, 2); 
        }
    }
}
