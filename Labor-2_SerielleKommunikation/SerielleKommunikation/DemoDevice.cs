﻿using System;
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

        CommandBytes command_Increment = CommandBytes.CounterIncrement;
        CommandBytes command_Decrement = CommandBytes.CounterDecrement;
        CommandBytes command_Reset = CommandBytes.CounterReset;
        CommandBytes command_SendCounterReading = CommandBytes.SendCounter;
        CommandBytes command_SendSerialNumber = CommandBytes.SendSerialNumber;
        CommandBytes command_SendDeviceName = CommandBytes.SendDeviceName;

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
            byte[] sendName = new byte[] { (byte)command_SendDeviceName };
            serialPort.Write(sendName, 0, 1);
            DeviceName = serialPort.ReadLine();

            //Serial Number
            byte[] sendNumber = new byte[] { (byte)command_SendSerialNumber };
            serialPort.Write(sendNumber, 0, 1);
            SerialNumber = serialPort.ReadLine();

            //Counter
            byte[] sendCounter = new byte[] { (byte)command_SendCounterReading };
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
                byte[] inc = new byte[] { (byte)command_Increment };
                serialPort.Write(inc, 0, 1); 
            }
        }

        public void Decrement()
        {
            if (serialPort.IsOpen)
            {
                byte[] dec = new byte[] { (byte)command_Decrement };
                serialPort.Write(dec, 0, 1);
            }
        }

        public void Reset()
        {
            if (serialPort.IsOpen)
            {
                byte[] res = new byte[] { (byte)command_Reset };
                serialPort.Write(res, 0, 1);
            }
        }
    }
}
