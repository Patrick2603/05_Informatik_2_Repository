using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer
{
    class Program
    {
        public static void Main()
        {
            /* ip adress at whitch the server waits */ 
            /* 127.0.0.1 can also be expressed as "localhost" */
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            /* new socket is generated from OS */ 
            /* server waits at port 8080 for any client requests */
            TcpListener serverSocket = new TcpListener(localAddr, 8080);

            // Das Warten auf Anfragen starten
            /* server starts to wait for request */
            serverSocket.Start();

            while (true)
            {
                Console.WriteLine("Warte auf Verbindung.... ");
                // Blockierendes Warten, bis eine Verbindungsanfrage kommt
                /* program stops and just continues when connection is ok */ 
                /* if connected: client gets a new port from server so the localhost isnt blocked */
                TcpClient client = serverSocket.AcceptTcpClient();
                Console.WriteLine("Verbindung hergestellt");

                // Das Stream-Objekt des Sockets holen
                /* get stream object of the socket to later read the data */ 
                NetworkStream stream = client.GetStream();

                // Eingehende Daten aus dem Stream lesen
                int i;
                /* buffer for .read or .write, needs to be done with a buffer because of byte communication */
                /* stream.Read(buffer, offset, size) */
                Byte[] bytes = new Byte[256];
                /* server is running all the time until data comes in, then it gets decoded to string and printed in the console */ 
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    // Gelesene Bytes in einen String umwandeln
                    string text = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    Console.WriteLine("Nachricht erhalten:" + text);
                }
            }
        }
    }
}
