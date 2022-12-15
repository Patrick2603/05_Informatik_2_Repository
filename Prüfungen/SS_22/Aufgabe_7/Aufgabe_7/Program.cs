using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Aufgabe_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int lfdNummer = 1;

            /* a.) */
            IPAddress localAddr = IPAddress.Parse("192.168.0.10");
            TcpListener serverSocket = new TcpListener(localAddr, 81);
            /* start of waiting request */
            serverSocket.Start(); 

            /* Server should listen all the time */
            while(true)
            {
                /* New socket: client at this is now the communication, AcceptTcpClient: Blockierendes Warten auf Verbindungsanfragen */
                TcpClient client = serverSocket.AcceptTcpClient();
                /* get Stream Object of the Socket, needed to Write */
                NetworkStream stream = client.GetStream();

                /* send the lfdNummer */
                byte[] nummer = BitConverter.GetBytes(lfdNummer);
                stream.Write(nummer, 0, nummer.Length);

                /* Read what the client send to the server */
                byte[] daten = new byte[256]; 
                int i = stream.Read(daten, 0, daten.Length);

                /* check if answer == OK */
                string answer = Encoding.ASCII.GetString(daten, 0 , i);
                if(answer == "OK")
                {
                    lfdNummer++; 
                }

                /* b.) */
                /* buffer for receive and transmit data */
                byte[] daten1 = new byte[256];
                /* set answer default to "Not OK" */
                string answer1 = "NOK";
                /* Read data */
                stream.Read(daten1);
                /* Convert Data to int number */
                int nummer1 = BitConverter.ToInt32(daten1);
                /* check if number < 20 */
                if(nummer1 < 20)
                {
                    answer1 = "OK"; 
                }
                /* encoder answer and write it into data1 for transmit */
                daten1 = Encoding.ASCII.GetBytes(answer1);
                /* write data1 */
                stream.Write(daten1, 0, answer1.Length);

                /* Close open connections */
                stream.Dispose();
                client.Close(); 
            }
        }
    }
}
