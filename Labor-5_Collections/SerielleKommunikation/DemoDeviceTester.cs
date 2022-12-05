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
        private Zählerstandverwaltung _zv; 
        
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
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //increase counter
            if(_device != null)
            {
                _device.Increment();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //decrease counter
            if(_device != null)
            {
                _device.Decrement();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Zählerstandverwaltung.ZählerHinzufügen(_currentNumber); 
            //reset counter
            if(_device != null)
            {
                _device.Reset();
            }
        }

        /* Schritt 4: Event-Handler */
        private void OnDevicePropertyChanged(DemoDevice device, string propertyName)
        {
            if (propertyName == "ConnectionState")
            {
                this.Invoke((MethodInvoker)(() => { SetConnectionState(device.ConnectionState); }));
            }
            else if (propertyName == "DeviceName")
            {
                this.Invoke((MethodInvoker)(() => { toolStripDeviceName.Text = device.DeviceName.Trim(); }));
            }
            else if (propertyName == "SerialNumber")
            {
                this.Invoke((MethodInvoker)(() => { toolStripDeviceNumber.Text = device.SerialNumber.Trim(); }));
            }
            else if (propertyName == "CurrentNumber")
            {
                this.Invoke((MethodInvoker)(() => { textBox1.Text = device.CurrentNumber.ToString("D4"); }));
            }
        }

        /* Set the Connection States  */
        private void SetConnectionState(DemoDevice.ConnectionStates connectionState)
        {
            switch (connectionState)
            {
                case DemoDevice.ConnectionStates.Connected:
                    toolStripDeviceStatus.Text = "Verbunden";
                    break;
                case DemoDevice.ConnectionStates.Connecting:
                    toolStripDeviceStatus.Text = "Verbinde...";
                    break;
                case DemoDevice.ConnectionStates.Disconnected:
                    toolStripDeviceStatus.Text = "Nicht verbunden.";
                    break;
            }
        }

        private void speichernRückgängigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _zv.ZählerRückgängig();
        }

        private void zeigeListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //public Dictionary<int, int> ZeigeListe()
            //{
            //    foreach(KeyValuePair<int, int> zähler in tempListe)
            //    {

            //    }
            //}
            //Produktliste p = new Produktliste();
            //ZeigeListe(ProduktZähler);
        }
    }
}
