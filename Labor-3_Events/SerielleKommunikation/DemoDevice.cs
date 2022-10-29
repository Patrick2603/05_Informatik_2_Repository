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
        /* Schritt 1: Delegattyp für Event-Handler anlegen */
        public delegate void PropertyChangedHandler(DemoDevice source, string propertyName);
        /* Schritt 2: Event in der auslösenden Klasse anlegen */
        public event PropertyChangedHandler PropertyChanged;
        /* Attributes */ 
        private string _serialNumber;
        private string _deviceName;
        private int _currentNumber;
        
        /* Properties */
        public string DeviceName
        {
            get
            {
                return _deviceName;
            }
            set
            {
                _deviceName = value;
                OnPropertyChanged("DeviceName");
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
                OnPropertyChanged("SerialNumber");
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
                OnPropertyChanged("CurrentNumber");
            }
        }

        private enum CommandBytes   /* defines for arduino access */ 
        {
            CounterReset = 0x7A,
            CounterDecrement = 0x7B,
            CounterIncrement = 0x7C,
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
                Thread.Sleep(2000);
                ReadDeviceInfo(); 
            }
            catch(IOException)
            {

            }
        }

        private void ReadDeviceInfo()
        {
            //Device Name
            byte[] sendName = new byte[] { (byte)CommandBytes.SendDeviceName };
            serialPort.Write(sendName, 0, 1);
            DeviceName = serialPort.ReadLine();

            //Serial Number
            byte[] sendNumber = new byte[] { (byte)CommandBytes.SendSerialNumber };
            serialPort.Write(sendNumber, 0, 1);
            SerialNumber = serialPort.ReadLine();

            //Counter
            byte[] sendCounter = new byte[] { (byte)CommandBytes.SendCounter };
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
                byte[] inc = new byte[] { (byte)CommandBytes.CounterIncrement };
                serialPort.Write(inc, 0, 1);
                CurrentNumber = _currentNumber + 1;
            }
        }

        public void Decrement()
        {
            if (serialPort.IsOpen)
            {
                byte[] dec = new byte[] { (byte)CommandBytes.CounterDecrement };
                serialPort.Write(dec, 0, 1);
                CurrentNumber = _currentNumber - 1; 
            }
        }

        public void Reset()
        {
            if (serialPort.IsOpen)
            {
                byte[] res = new byte[] { (byte)CommandBytes.CounterReset };
                serialPort.Write(res, 0, 1);
                CurrentNumber = 0; 
            }
        }

        /* Schritt 3: Zwischenfunktion die aufgerufen wird um überhaupt in den Event Handler rein zu kommen */
        private void OnPropertyChanged(string propertyName)
        {
            /* check if event is existing */
            if (PropertyChanged != null)
            {
                /* execute event */
                PropertyChanged(this, propertyName);
            }
        }
    }
}
