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
        public DemoDeviceTester()
        {
            InitializeComponent();
            DemoDeviceTester device = new DemoDeviceTester();
            _device = device; 
        }
        
        private DemoDeviceTester _device = new DemoDeviceTester(); 

        public void button1_Click(object sender, EventArgs e)
        {
            //connection to arduino
            int portNumber = 4;
            Connect(portNumber);

            //Device Name
            byte[] sendName = new byte[] { 0x7F };
            serialPort.Write(sendName, 0, 1);
            string deviceName = serialPort.ReadLine();

            //Serial Number
            byte[] sendNumber = new byte[] { 0x7E };
            serialPort.Write(sendNumber, 0, 1);
            string serialNumber = serialPort.ReadLine();

            textBox1.Text(deviceName);
            textBox1.Text(serialNumber);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //increase counter
            Increment(_device);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //decrease counter
            Decrement(_device);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //reset counter
            Reset(_device);
        }
    }
}
