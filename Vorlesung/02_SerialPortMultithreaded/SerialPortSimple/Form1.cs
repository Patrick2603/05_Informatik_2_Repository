using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void ReadSerialNumber()
        {
            SerialPort serialPort = new SerialPort();
            serialPort.PortName = "COM5";
            serialPort.BaudRate = 9600;
            serialPort.DtrEnable = true;

            try
            {
                serialPort.Open();
                Thread.Sleep(2000);

                byte[] command = new byte[] { 0x7F };
                serialPort.Write(command, 0, 1);
                string deviceName = serialPort.ReadLine();
                textBox1.Text = deviceName;
            }

            catch (IOException ex)
            {
                textBox1.Text = ex.Message;
                textBox1.Text += Environment.NewLine;
                textBox1.Text += Environment.NewLine;
                textBox1.Text += ex.StackTrace;
            }
        }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(ReadSerialNumber);
            t.Start();
        }
    }
}
