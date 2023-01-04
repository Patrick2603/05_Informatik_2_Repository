using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace HTTP_Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* create the Server Socket */
            TcpListener serverSocket = null;

            try
            {
                /* Initialize the Server Socket at the right Adress and Port */
                IPAddress localAdress = IPAddress.Parse("127.0.0.1");
                serverSocket = new TcpListener(localAdress, 80);
                /* Start to wait for a new Client */
                serverSocket.Start();

                while (true)
                {
                    TcpClient client = serverSocket.AcceptTcpClient();
                    /* Communication Thread */
                    Thread clientThread = new Thread(ClientHandler);
                    clientThread.Start(client);
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.Message);
                /* Stop the Server from Listening for Client requests */
                serverSocket.Stop();
            }
        }

        private static void ClientHandler(object o)
        {
            /* Communication with the Client */
            TcpClient client = o as TcpClient;
            NetworkStream clientStream = client.GetStream();
            int i;
            byte[] buffer = new byte[1024];
            while ((i = clientStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                string request = System.Text.Encoding.ASCII.GetString(buffer, 0, i);
                Console.WriteLine(request);

                string filename = request.Substring(request.IndexOf("/") + 1, (request.IndexOf("H") - request.IndexOf("/")) - 1);

                if (filename == " ")
                {
                    filename = "index.html";
                }

                if (File.Exists(filename))
                {
                    string output = "";

                    using (FileStream fileReader = new FileStream(filename, FileMode.Open, FileAccess.Read))
                    {
                        byte[] fileBuffer = new byte[fileReader.Length];
                        fileReader.Read(fileBuffer, 0, fileBuffer.Length);

                        string content = Encoding.ASCII.GetString(fileBuffer, 0, fileBuffer.Length);

                        if (filename == "favicon.ico")
                        {
                            output = "HTTP/1.1 200 OK\nContent-length:" + fileReader.Length + "\nContent-Type: image/x-icon\n\n" + content;
                        }
                        else
                        {
                            output = "HTTP/1.1 200 OK\nContent-length:" + fileReader.Length + "\nContent-Type: text/html\n\n" + content;
                        }
                    }

                    byte[] outputbuffer = Encoding.ASCII.GetBytes(output); ;

                    clientStream.Write(outputbuffer, 0, outputbuffer.Length);
                }
            }
        }
    }
}
