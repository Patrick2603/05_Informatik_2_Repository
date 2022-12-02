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
            /* client to server, ip adress 127.0.0.1 at port 8080 */
            /* with new already a connection is done */
            TcpClient client = new TcpClient("localhost", 8080);
            textBox1.Text += "Verbindung aufgebaut." + Environment.NewLine;

            string nachricht = "Palimpalam";
            // Nachricht in Byte umwandeln
            /* encode string to byte that it can be send */
            Byte[] daten = Encoding.ASCII.GetBytes(nachricht);

            /* referenz on networkStream, get stream object of the socket to later read the data */
            NetworkStream stream = client.GetStream();

            /* write the data on the stream with .write exactly like .read */
            textBox1.Text += "Sende Nachricht an Server" + Environment.NewLine;
            stream.Write(daten, 0, daten.Length);

            /* close open connections */
            stream.Dispose();
            client.Close();
        }
    }
}
