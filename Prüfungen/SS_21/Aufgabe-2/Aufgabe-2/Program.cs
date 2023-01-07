using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 

namespace Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* b.) */
            /* Hintergrund-Thread */
            Thread neuerThread = new Thread(StatusAusgeben);
            neuerThread.IsBackground = true;
            neuerThread.Start();

            /* Zählung aller int-Werte, die die Ziffer "7" enthalten */
            int count = 0;
            for (int i = 0; i < Int32.MaxValue; i++)
            {
                /* Contains function only works on string so convert to string then check */
                string s = i.ToString();
                if (s.Contains("7"))
                {
                    count++;
                }
            }
            Console.WriteLine("int: {0} Werte mit Ziffer 7!", count);
        }
        static void StatusAusgeben()
        {
            /* Endlosschleife mit Ausgabe */
            while (true)
            {
                Console.WriteLine("Zählung läuft...");
            }
        }
    }
}
