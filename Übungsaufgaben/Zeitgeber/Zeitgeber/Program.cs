using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeitgeber
{
    class Program
    {
        static void Main(string[] args)
        {
            void Ausgabe(Zeitgeber z)
            {
                Console.WriteLine("tick");
            }

            void Main()
            {
                Zeitgeber z = new Zeitgeber();
                z.Tick += Ausgabe;
                z.Start();
            }
        }
    }
}
