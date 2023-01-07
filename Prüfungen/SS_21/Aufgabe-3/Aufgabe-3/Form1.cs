using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_3
{
    public partial class Form1 : Form
    {
        ArduinoDevice _ad = new ArduinoDevice(); 
        public Form1()
        {
            InitializeComponent();
            _ad.LüfterEinEvent += SchreibeAktTemp;
        }

        public void SchreibeAktTemp()
        {
            /* convert from double to string */
            /* why tB_aktTemp und nicht this?? */
            tB_aktTemp.Invoke((MethodInvoker)(() => { tB_aktTemp.Text = _ad.Temperatur.ToString(); }));
        }
    }
}
