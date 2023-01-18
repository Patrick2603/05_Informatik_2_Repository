using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("abc.txt");
            string zeile;
            bool b = true; 

            /* Read text with StreamReader object */
            while((zeile = reader.ReadLine()) != null)
            {
                if(b)
                {
                    Console.WriteLine(zeile); 
                }
                /* Invert b so every two iterations it is displayed on the console */
                b = !b; 
            }
            reader.Close(); 
        }
    }
}
