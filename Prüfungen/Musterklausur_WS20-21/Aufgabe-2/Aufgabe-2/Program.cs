using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex m = new Mutex(); 
            KlasseA obj = new KlasseA(m); 

            Thread thread1 = new Thread(obj.Methode1);
            Thread thread2 = new Thread(obj.Methode2);

            thread1.Start();
            thread2.Start(); 
        }
    }
}
