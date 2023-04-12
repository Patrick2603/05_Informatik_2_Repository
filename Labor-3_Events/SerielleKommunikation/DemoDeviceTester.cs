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
            int portNumber = 3; 
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
        private void OnDevicePropertyChanged(DemoDevice source, string propertyName)
        {
           switch(propertyName)
           {
                case "SerialNumber":
                    textBox1.Text = "Serienummer geändert! " + source.SerialNumber;
                    break;
                case "DeviceName":
                    textBox1.Text = "Gerätename geändert! " + source.DeviceName;
                    break;
                case "CurrentNumber":
                    textBox1.Text = "Zählerstand geändert! " + source.CurrentNumber;
                    break;
                default:
                    textBox1.Text = "Keine Änderung! ";
                    break; 
           }
        }
    }
}
