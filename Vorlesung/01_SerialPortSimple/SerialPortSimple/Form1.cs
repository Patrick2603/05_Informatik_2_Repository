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

            serialPort.PortName = "COM6";
            serialPort.BaudRate = 9600;
            /* Data Terminal Ready */ 
            serialPort.DtrEnable = true;

            /* is getting executed normally if error witch is handled in catch function it jumps out */
            try
            {
                serialPort.Open();
                Thread.Sleep(3000);
                byte[] command = new byte[] { 0x7F };
                serialPort.Write(command, 0, 1);
                string deviceName = serialPort.ReadLine();

                byte[]  Number = new byte[] { 126 };
                serialPort.Write(Number, 0, 1);
                string serialNumber = serialPort.ReadLine();

                textBox1.Text = "Gerät: " + deviceName + "\n" + "S/N: " + serialNumber;
                serialPort.Close();
            }

            /* catch errors */ 
            catch (IOException ex)  
            { 
                textBox1.Text = ex.Message;
            }

            /* executed in every case, needs to be specifically closed */
            finally
            {
                serialPort.Close();
            }
        }
    }
}
