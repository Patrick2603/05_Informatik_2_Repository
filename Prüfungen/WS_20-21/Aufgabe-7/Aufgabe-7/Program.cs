using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe_7
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            TcpListener serverSocket = new TcpListener(localAddr, 4711);
            serverSocket.Start(); 

            while(true)
            {
                TcpClient client = serverSocket.AcceptTcpClient();
                Thread clientThread = new Thread(ClientHandler); 
                clientThread.Start(clientThread); 
            }
        }

        private static void ClientHandler(object o)
        {
            TcpClient client = o as TcpClient;
            NetworkStream stream = client.GetStream();

            int i;
            Byte[] bytes = new byte[256]; 
            while((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                string text = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                int value = Int32.Parse(text);
                value = value * value;

                Byte[] daten = Encoding.ASCII.GetBytes(value.ToString());
                stream.Write(daten, 0, daten.Length); 
            }
            stream.Dispose();
            client.Close(); 
        }
    }
}
