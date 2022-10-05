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
            serialPort.DtrEnable = true;

            serialPort.Open();
            Thread.Sleep(3000);

            byte[] command = new byte[] { 0x7F };
            serialPort.Write(command, 0, 1);
            string deviceName = serialPort.ReadLine();

            byte[] command = new byte[] { 0x7E };
            serialPort.Write(command, 0, 1);
            string serialNumber = serialPort.ReadLine(); 

            serialPort.Close();

            textBox1.Text = deviceName;
            textBox1.Text = serialNumber; 
        }
    }
}
