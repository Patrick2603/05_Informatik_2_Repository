using System;
using System.Threading;
using System.Net;
using System.Net.Sockets; 

namespace Labor_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Server Socket */
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            TcpListener serverSocket = new TcpListener(localAddr, 80);
            serverSocket.Start();

            while (true)
            {
                TcpClient client = serverSocket.AcceptTcpClient();
                /* Communication Thread */
                Thread clientThread = new Thread(ClientHandler);
                clientThread.Start(client);
            }

            static void ClientHandler(object o)
            {
                /* Communication with the Client */
                TcpClient client = o as TcpClient;
                NetworkStream stream = client.GetStream();
                int i;
                Byte[] bytes = new Byte[256];
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    Console.WriteLine(stream);
                }
            }

        }
    }
}
