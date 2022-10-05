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
            serialPort.PortName = "COM8";
            serialPort.BaudRate = 9600;
            serialPort.DtrEnable = true;

            try
            {
                serialPort.Open();
                Thread.Sleep(2000);

                byte[] command = new byte[] { 0x7F };
                serialPort.Write(command, 0, 1);
                string deviceName = serialPort.ReadLine();

                textBox1.Invoke( (MethodInvoker) (() => { textBox1.Text = deviceName; }) );
            }

            catch (IOException ex)
            {
                string s = ex.Message;
                s += Environment.NewLine;
                s += Environment.NewLine;
                s += ex.StackTrace;

                textBox1.Invoke((MethodInvoker)(() => { textBox1.Text = s; }));
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
