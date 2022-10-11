using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports; 

namespace SerielleKommunikation
{
    class DemoDevice
    {
        DemoDevice geraet1 = new DemoDevice();
        SerialPort serialPort = new SerialPort();
        private string _serialNumber;
        private string _deviceName;
        private int _currentNumber;



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
            serialPort.PortName = "COM4";
            serialPort.BaudRate = 9600;
            serialPort.DtrEnable = true;

            if ()   /* if connection is ok */
            {
                ReadDeviceInfo();
            }

            
        }

        private int ReadDeviceInfo()
        {


            return 0;
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
