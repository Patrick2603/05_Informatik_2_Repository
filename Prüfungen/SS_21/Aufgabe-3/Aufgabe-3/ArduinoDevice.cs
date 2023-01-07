using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.IO; 

namespace Aufgabe_3
{
    class ArduinoDevice
    {
        private double _temperatur = 0.0;
        private SerialPort _serialPort;
        private double _grenzwert = 80.0;
        private Lüfter _lüfter1 = new Lüfter();
        /* Passendes Delegat und Event */
        public delegate void delegate_TempAlarm(); 
        public event delegate_TempAlarm LüfterEinEvent; 


        public ArduinoDevice()
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = "COM3";
            _serialPort.BaudRate = 9600;
            _serialPort.Open();
            Thread.Sleep(2000);

            /* Lüfter am Event anmelden */
            LüfterEinEvent += _lüfter1.LüfterEin;

            Thread arduinoThread = new Thread(LeseTemp);
            arduinoThread.IsBackground = true;
            arduinoThread.Start();
        }

        /* Property zu _temperatur */
        public double Temperatur
        {
            get { return _temperatur; }
            set
            {
                _temperatur = value; 
                /* Event ausführen */
                if((LüfterEinEvent != null) && (_temperatur > _grenzwert))
                {
                    LüfterEinEvent();
                }
            }
        }

        public void LüfterEin()
        {

        }

        private void LeseTemp()
        {
            while(true)
            {
                byte[] _command = new byte[] { 0x7D };
                _serialPort.Write(_command, 0, _command.Count());
                int temp = Int32.Parse(_serialPort.ReadLine()); 
                Thread.Sleep(10000); 
            }
        }
    }
}
