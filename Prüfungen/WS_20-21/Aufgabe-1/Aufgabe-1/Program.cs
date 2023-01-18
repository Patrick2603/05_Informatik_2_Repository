using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort serialPort = new SerialPort();
            serialPort.PortName = "COM5";
            serialPort.BaudRate = 9600;
            serialPort.DtrEnable = true;

            try
            {
                serialPort.Open();
                Thread.Sleep(3000);

                byte[] command = new byte[] { 0x00, 0x01 };
                serialPort.Write(command, 0, command.Length);
            }

            catch(IOException)
            {
                Console.WriteLine("IO Exception");
            }
            catch (TimeoutException)
            {
                Console.WriteLine("Timeout Exception");
            }
            catch
            {
                Console.WriteLine("Andere Exception");
            }

            finally
            {
                serialPort.Close(); 
            }
        }
    }
}
