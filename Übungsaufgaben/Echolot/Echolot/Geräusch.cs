using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 

namespace Echolot
{
    class Geräusch
    {
        Random _random = new Random();
        
        public void Ping()
        {
            while(true)
            {
                int time = _random.Next(250, 1000); 
                Thread.Sleep(time);
                Console.Write("Ping ");
            }
        }

        public void Pong()
        {
            while (true)
            {
                int time = _random.Next(250, 1000); 
                Thread.Sleep(time);
                Console.Write("Pong ");
            }
        }
    }
}
