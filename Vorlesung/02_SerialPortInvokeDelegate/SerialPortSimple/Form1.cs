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
        private delegate void SetTextBoxDelegate();

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

                TextBoxInvoker invoker = new TextBoxInvoker(textBox1, deviceName);
                SetTextBoxDelegate setTextBox = invoker.SetText;
                textBox1.Invoke(setTextBox);
            }

            catch (IOException ex)
            {
                string message = ex.Message;
                message += Environment.NewLine;
                message += Environment.NewLine;
                message += ex.StackTrace;

                TextBoxInvoker invoker = new TextBoxInvoker(textBox1, message);
                SetTextBoxDelegate setTextBox = invoker.SetText;
                textBox1.Invoke(setTextBox);
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
