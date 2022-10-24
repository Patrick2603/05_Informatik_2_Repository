using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.IO; 

namespace SerielleKommunikation
{
    class DemoDevice
    {
        SerialPort serialPort = new SerialPort();
        private string _serialNumber;
        private string _deviceName;
        private int _currentNumber;

        public string DeviceName
        {
            get
            {
                return _deviceName;
            }
            set
            {
                _deviceName = value;
            }
        }

        public string SerialNumber
        {
            get
            {
                return _serialNumber; 
            }
            set
            {
                _serialNumber = value; 
            }
        }

        public int CurrentNumber
        {
            get
            {
                return _currentNumber;
            }
            set
            {
                _currentNumber = value;
            }
        }


        private enum CommandBytes   /* defines for arduino access */ 
        {
            SetCounterzero = 0x7A,
            CounterDecrease = 0x7B,
            CounterIncrease = 0x7C,
            SendCounter = 0x7D,
            SendSerialNumber = 0x7E,
            SendDeviceName = 0x7F
        }
	
        public void Connect(int portNumber)     /* connect to arduino */
        {
            serialPort.PortName = "COM" + portNumber;
            serialPort.BaudRate = 9600;
            serialPort.DtrEnable = true;
            try
            {
                serialPort.Open();
                Thread.Sleep(500);
                ReadDeviceInfo();
            }
            catch(IOException)
            {

            }
            
        }

        private void ReadDeviceInfo()
        {
            //Device Name
            byte[] sendName = new byte[] { 0x7F };
            serialPort.Write(sendName, 0, 1);
            DeviceName = serialPort.ReadLine();

            //Serial Number
            byte[] sendNumber = new byte[] { 0x7E };
            serialPort.Write(sendNumber, 0, 1);
            SerialNumber = serialPort.ReadLine();

            //Counter
            byte[] sendCounter = new byte[] { 0x7D };
            serialPort.Write(sendCounter, 0 ,1);
            CurrentNumber = Int16.Parse(serialPort.ReadLine()); 
        }

        public void Disconnect()
        {
            serialPort.Close();
        }

        public void Increment()
        {
            if (serialPort.IsOpen)
            { 
                byte[] inc = new byte[] { 0x7C };
                serialPort.Write(inc, 0, 1); 
            }
        }

        public void Decrement()
        {
            if (serialPort.IsOpen)
            {
                byte[] dec = new byte[] { 0x7B };
                serialPort.Write(dec, 0, 1);
            }
        }

        public void Reset()
        {
            if (serialPort.IsOpen)
            {
                byte[] res = new byte[] { 0x7A };
                serialPort.Write(res, 0, 1);
            }
        }
    }
}
