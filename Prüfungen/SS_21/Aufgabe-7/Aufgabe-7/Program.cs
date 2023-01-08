using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Schimpfserver s = new Schimpfserver("127.0.0.1", 1234);
            s.LeseAusDatei();
            s.Start();
        }
    }
}
