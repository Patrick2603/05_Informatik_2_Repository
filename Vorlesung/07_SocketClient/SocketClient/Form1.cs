using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Verbinde mich mit Server..." + Environment.NewLine;
            TcpClient client = new TcpClient("localhost", 8080);
            textBox1.Text += "Verbindung aufgebaut." + Environment.NewLine;

            string nachricht = "Palimpalam";
            // Nachricht in Byte umwandeln
            Byte[] daten = Encoding.ASCII.GetBytes(nachricht);

            NetworkStream stream = client.GetStream();

            textBox1.Text += "Sende Nachricht an Server" + Environment.NewLine;
            stream.Write(daten, 0, daten.Length);

            stream.Dispose();
            client.Close();
        }
    }
}
