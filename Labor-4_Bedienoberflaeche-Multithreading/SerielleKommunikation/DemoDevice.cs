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
        public SerialPort serialPort = new SerialPort();
        /* Schritt 1: Delegattyp für Event-Handler anlegen */
        public delegate void PropertyChangedHandler(DemoDevice source, string propertyName);
        /* Schritt 2: Event in der auslösenden Klasse anlegen */
        public event PropertyChangedHandler PropertyChanged;
        /* Attributes */ 
        private string _serialNumber;
        private string _deviceName;
        private int _currentNumber;
        private ConnectionStates _connectionState = ConnectionStates.Disconnected;

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
                if(_currentNumber != value)
                {
                    _currentNumber = value;
                    OnPropertyChanged("CurrentNumber");
                }
            }
        }

        public ConnectionStates ConnectionState
        {
            get
            {
                return _connectionState; 
            }
            set
            {
                _connectionState = value;
                OnPropertyChanged("ConnectionState");
            }
        }

        public enum CommandBytes   /* defines for arduino access */ 
        {
            CounterReset = 0x7A,
            CounterDecrement = 0x7B,
            CounterIncrement = 0x7C,
            SendCounter = 0x7D,
            SendSerialNumber = 0x7E,
            SendDeviceName = 0x7F
        }
	
        public enum ConnectionStates
        {
            Disconnected, 
            Connecting, 
            Connected
        }
        
        public void Connect(int portNumber)     /* connect to arduino */
        {

            ConnectionState = ConnectionStates.Connecting;

            
            try
            {
                serialPort = new System.IO.Ports.SerialPort(); 
                serialPort.PortName = "COM" + portNumber;
                serialPort.BaudRate = 9600;
                serialPort.DtrEnable = true;
                serialPort.Open();
                ConnectionState = ConnectionStates.Connected; 

                //ThreadClass obj = new ThreadClass();
                Thread newThread = new Thread(new ThreadStart(ReadDeviceInfo));
                newThread.IsBackground = true;
                newThread.Start();
            }
            
            catch(IOException)
            {
               ConnectionState = ConnectionStates.Disconnected; 
            }
        }

        public void ReadDeviceInfo()
        {
            //Device Name
            byte[] sendName = new byte[] { (byte)CommandBytes.SendDeviceName };
            serialPort.Write(sendName, 0, 1);
            DeviceName = serialPort.ReadLine();

            //Serial Number
            byte[] sendNumber = new byte[] { (byte)CommandBytes.SendSerialNumber };
            serialPort.Write(sendNumber, 0, 1);
            SerialNumber = serialPort.ReadLine();

            while (true)
            {
                //Counter
                byte[] sendCounter = new byte[] { (byte)CommandBytes.SendCounter };
                serialPort.Write(sendCounter, 0, 1);
                CurrentNumber = Int16.Parse(serialPort.ReadLine());
                Thread.Sleep(200);
            }
        }

        public void Disconnect()
        {
            serialPort.Close();
            ConnectionState = ConnectionStates.Disconnected; 
        }

        public void Increment()
        {
            byte[] commandBuffer = new byte[] { (byte)CommandBytes.CounterIncrement };
            if ((serialPort != null) && (serialPort.IsOpen))
            {
                serialPort.Write(commandBuffer, 0, commandBuffer.Count());
            }
            if(_currentNumber == 9999)
            {
                CurrentNumber = 0; 
            }
            else
            {
                CurrentNumber = _currentNumber + 1;
            }
        }

        public void Decrement()
        {
            
            byte[] commandBuffer = new byte[] { (byte)CommandBytes.CounterDecrement };
            if ((serialPort != null) && (serialPort.IsOpen))
            {
                serialPort.Write(commandBuffer, 0, commandBuffer.Count());
            }
            if(_currentNumber == 0)
            {
                CurrentNumber = 9999; 
            }
            else
            {
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
    class ThreadClass : DemoDevice
    {
        public void Threadmethod()
        {
            ReadDeviceInfo();
            ConnectionState = ConnectionStates.Connected;
        }
    }
}
