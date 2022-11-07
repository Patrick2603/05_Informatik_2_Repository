using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerielleKommunikation
{
    public partial class DemoDeviceTester : Form
    {
        private DemoDevice _device; 
        
        public DemoDeviceTester()
        {
            InitializeComponent();
            DemoDevice device = new DemoDevice();
            _device = device;
            /* Schritt 5: Event-Handler als Beobachter anmelden */
            _device.PropertyChanged += OnDevicePropertyChanged; 
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            //connection to arduino
            //get Port number over numericupdown 
            int portNumber = (int)numericUpDown1.Value;  
            _device.Connect(portNumber);
            textBox1.Clear();
            textBox1.Text = "Gerät: " + _device.DeviceName + Environment.NewLine;
            textBox1.Text += "S/N: " + _device.SerialNumber + Environment.NewLine;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //increase counter
            _device.Increment(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //decrease counter
            _device.Decrement(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //reset counter
            _device.Reset(); 
        }

        /* Schritt 4: Event-Handler */
        private void OnDevicePropertyChanged(DemoDevice device, string propertyName)
        {
            if (propertyName == "ConnectionState")
            {
                this.Invoke((MethodInvoker)(() => { SetConnectionState(device.ConnectionState); }));
            }
            //else if (propertyName == "DeviceName")
            //{
            //    this.Invoke((MethodInvoker)(() => { toolStripDeviceName.Text = device.DeviceName; }));
            //}
            //else if (propertyName == "SerialNumber")
            //{
            //    this.Invoke((MethodInvoker)(() => { toolStripDeviceNumber.Text = device.SerialNumber; }));

            //}
            //else if (propertyName == "CurrentNumber")
            //{
            //    this.Invoke((MethodInvoker)(() => { currentNumber.Text = device.CurrentNumber.ToString("D4"); }));
            //}
        }

        private void SetConnectionState(DemoDevice.ConnectionStates connectionState)
        {
            switch (connectionState)
            {
                case DemoDevice.ConnectionStates.Connected:
                    toolStripStatus.Text = "Verbunden";
                    break;
                case DemoDevice.ConnectionStates.Connecting:
                    toolStripStatus.Text = "Verbinde...";
                    break;
                case DemoDevice.ConnectionStates.Disconnected:
                    toolStripStatus.Text = "Nicht verbunden.";
                    break;
            }

        }
    }
}
