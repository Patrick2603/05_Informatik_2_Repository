using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Aufgabe_7
{
    class Schimpfserver
    {
        private string _adresse;
        private int _port;
        private string[] _schimpfwörter;
        private Random _rand;
        public Schimpfserver(string adresse, int port)
        {
            _adresse = adresse;
            _port = port;
            _rand = new Random();
            _schimpfwörter = new string[] { "Lauch", "Trottel" };
        }

        public void Start()
        {
            IPAddress localAddr = IPAddress.Parse(_adresse);
            TcpListener serverSocket = new TcpListener(localAddr, _port);
            serverSocket.Start(); 

            while(true)
            {
                TcpClient client = serverSocket.AcceptTcpClient();
                Thread clientThread = new Thread(ClientKommunikation);
                clientThread.Start(client); 
            }
        }

        private void ClientKommunikation(object o)
        {
            TcpClient client = o as TcpClient;
            NetworkStream stream = client.GetStream();

            int i;
            Byte[] bytes = new Byte[256]; 
            while((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                string text = System.Text.Encoding.ASCII.GetString(bytes, 0, i);

                String wort = _schimpfwörter[_rand.Next(0, _schimpfwörter.Length)]; 

                Byte[] daten = { }; 
                if(text == "KLARTEXT")
                {
                    daten = Encoding.ASCII.GetBytes(wort); 
                }
                if(text == "ZENSIERT")
                {
                    daten = Encoding.ASCII.GetBytes(ZensiereText(wort));
                }
                stream.Write(daten, 0, daten.Length);
            }
        }

        private string ZensiereText(string text)
        {
            string ret = text.Replace('a', '*');
            ret = ret.Replace('e', '*');
            ret = ret.Replace('i', '*');
            ret = ret.Replace('o', '*');
            ret = ret.Replace('u', '*');
            return ret;
        }

        public void LeseAusDatei()
        {
            using (StreamReader file = new StreamReader(„filename.txt“))
            {
                string text = file.ReadToEnd();
                string[] wörter = text.Split(',');
                _schimpfwörter = wörter;
            }
        }
    }
}
