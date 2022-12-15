using System;
using System.IO; 

namespace Aufgabe_6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /* Create an instance of StreamReader to raed from the file */
                /* The using statement also closes the StreamReader */
                using (StreamReader reader = new StreamReader("faust.txt"))
                {
                    string line; 
                    /* Read and display lines from the file until the end of the file is reached */
                    while((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }

            /* catch Exceptions and print them in the Console */
            catch(Exception e)
            {
                Console.WriteLine("File could not be read");
                Console.WriteLine(e.Message);
            }
        }
    }
}
