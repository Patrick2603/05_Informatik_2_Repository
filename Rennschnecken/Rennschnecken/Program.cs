using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rennschnecken
{
    internal static class Program 
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            const int STRECKEN_LÄNGE = 50;

            Random random = new Random();

            Rennschnecken schnecke1 = new Rennschnecken(random);
            Rennschnecken schnecke2 = new Rennschnecken(random);
            Rennschnecken schnecke3 = new Rennschnecken(random);
            
            do
            {
                schnecke1.Krieche();
                schnecke2.Krieche();
                schnecke3.Krieche();

                Thread.Sleep(250);
            }
            while ((schnecke1.Strecke < STRECKEN_LÄNGE) && (schnecke2.Strecke < STRECKEN_LÄNGE) && (schnecke3.Strecke < STRECKEN_LÄNGE));

            //Console.Clear();
            Console.WriteLine(schnecke1.Visualisierung);
            Console.WriteLine(schnecke2.Visualisierung);
            Console.WriteLine(schnecke3.Visualisierung);

            Console.ReadKey();
        }
    }
}
