using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name des zu öffnenden Ports: ");
            string port = Console.ReadLine();

            SerialPort serialport = new SerialPort();
            serialport.PortName = port; 
            serialport.BaudRate = 19200;
            serialport.DtrEnable = false;

            serialport.Open();
            Thread.Sleep(3000); 

            Console.WriteLine("Zu übertragender Text: ");
            string text = Console.ReadLine();

            /* method exists functionally in solutions */
            serialPort.Write(string text);
            serialport.Close(); 
        }
    }
}
