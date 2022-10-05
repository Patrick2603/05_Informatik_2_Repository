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
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            TcpListener serverSocket = new TcpListener(localAddr, 8080);

            // Das Warten auf Anfragen starten
            serverSocket.Start();

            while (true)
            {
                Console.WriteLine("Warte auf Verbindung.... ");
                // Blockierendes Warten, bis eine Verbindungsanfrage kommt
                TcpClient client = serverSocket.AcceptTcpClient();
                Console.WriteLine("Verbindung hergestellt");

                // Das Stream-Objekt des Sockets holen
                NetworkStream stream = client.GetStream();

                // Eingehende Daten aus dem Stream lesen
                int i;
                Byte[] bytes = new Byte[256];
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
