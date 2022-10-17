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
            DemoDeviceTester odevice = new DemoDeviceTester();
            _device = odevice; 
        }

        private DemoDeviceTester _device = new DemoDeviceTester(); 

        public void button1_Click(object sender, EventArgs e)
        {
            //connection to arduino
            int COMPort = 4;
            Connect(_device); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //increase counter

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //decrease counter

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //reset counter

        }
    }
}
