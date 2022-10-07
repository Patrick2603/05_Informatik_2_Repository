using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace SerialPortSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SerialPort serialPort = new SerialPort();

            serialPort.PortName = "COM4";
            serialPort.BaudRate = 9600;
            /* Data Terminal Ready */ 
            serialPort.DtrEnable = true;

            serialPort.Open();
            Thread.Sleep(3000);

            /* is getting executed normally if error witch is handled in catch function it jumps out */ 
            try  
            {
                byte[] command = new byte[] { 0x7F };
                serialPort.Write(command, 0, 1);
                string deviceName = serialPort.ReadLine();

                byte[] command1 = new byte[] { 0x7E };
                serialPort.Write(command1, 0, 1);
                string serialNumber = serialPort.ReadLine();

                textBox1.Text = "Gerät: " + deviceName;
                textBox1.Text = "\r\n";
                textBox1.Text = "S/N: " + serialNumber;
            }

            /* catch errors and handle it */ 
            catch (IOException ex)  
            {
                textBox1.Text = "Fehler beim lesen/schreiben";
                textBox1.Text = ex.Message;
            }

            /* executed in every case, needs to be spesifically closed */
            finally 
            {
                serialPort.Close();
            }
        }
    }
}
