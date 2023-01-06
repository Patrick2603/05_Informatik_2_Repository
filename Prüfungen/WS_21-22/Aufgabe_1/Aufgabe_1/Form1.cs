using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Unnötig */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /* b.) */
        private int BerechneEigenverbrauch()
        {
            int Eigenverbrauch = 0;
            if(chBWaschmaschine.Checked)
            {
                Eigenverbrauch += 800; 
            }
            if (chBTrockner.Checked)
            {
                Eigenverbrauch += 800;
            }
            if (chBSpülmaschine.Checked)
            {
                Eigenverbrauch += 800;
            }
            return Eigenverbrauch; 
        }

        /* c.) */
        public void SchreibeLeistung(int Leistung)
        {
            tBaktLeistung.Text = Leistung.ToString();
            /* with Thread */
            tBaktLeistung.Invoke((MethodInvoker)(() => { tBaktLeistung.Text = Leistung.ToString(); }));
        }
    }
}
