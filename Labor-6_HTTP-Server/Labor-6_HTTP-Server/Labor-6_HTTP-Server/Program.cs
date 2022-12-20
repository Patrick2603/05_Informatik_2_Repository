﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Threading; 

namespace Labor_6_HTTP_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Server Socket */
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            TcpListener serverSocket = new TcpListener(localAddr, 8080);
            serverSocket.Start(); 

            while(true)
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
                while((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    Console.WriteLine(stream);
                }
            }
        }
    }
}
