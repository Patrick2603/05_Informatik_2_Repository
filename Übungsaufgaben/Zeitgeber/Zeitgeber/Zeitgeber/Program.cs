using System;

namespace Zeitgeber
{
    internal static class Programm 
    {
        /* Schritt 4 */
        static void TickChanged(Zeitgeber z)
        {
            Console.WriteLine("tick");
        }

        /* Schritt 5 */
        static void Main()
        {
            Zeitgeber z = new Zeitgeber();
            z.TickChanged += TickChanged;
            z.Start(); 
        }
    }
}