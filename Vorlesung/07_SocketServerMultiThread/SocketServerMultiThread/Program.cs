using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SocketServerMultiThread
{
    class Program
    {
        private static int ClientCounter = 0;

        // Methode für den Thread, der pro Client gestartet wird
        private static void ClientHandler(object o)
        {
            TcpClient client = o as TcpClient;
            int clientId = ClientCounter++;

            Console.WriteLine("Verbindung hergestellt zu Client " + clientId);

            // Das Stream-Objekt des Sockets holen
            NetworkStream stream = client.GetStream();

            // Eingehende Daten aus dem Stream lesen
            int i;
            Byte[] bytes = new Byte[256];
            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                // Gelesene Bytes in einen String umwandeln
                string text = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                Console.WriteLine("Nachricht erhalten von Client " + clientId + ": " + text);

                // Den String in Großbuchstaben umwandeln und zurück schicken
                string textGroß = text.ToUpper();
                Console.WriteLine("Sende Antwort an Client "  + clientId + ": " + textGroß);

                Byte[] daten = Encoding.ASCII.GetBytes(textGroß);
                stream.Write(daten, 0, daten.Length);
            }
        }

        static void Main(string[] args)
        {
            TcpListener serverSocket = null;
            try
            {
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                serverSocket = new TcpListener(localAddr, 8080);

                // Das Warten auf Anfragen starten
                serverSocket.Start();

                while (true)
                {
                    Console.WriteLine("Warte auf Verbindung.... ");
                    // Blockierendes Warten, bis eine Verbindungsanfrage kommt
                    TcpClient client = serverSocket.AcceptTcpClient();

                    Thread clientThread = new Thread(ClientHandler);
                    clientThread.Start(client);
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.ToString());
                serverSocket.Stop();
            }
        }
    }
}
