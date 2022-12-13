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
        public Form1()
        {
            InitializeComponent();
        }

        /* Teilaufgabe e */
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            /* MessageBox.Show(string text, string caption) */
            MessageBox.Show(text, "Überschrift");
        }

        /* Teilaufgabe f */
        public void SetzeTextAusAnderemThread(string zuSchreibenderText)
        {
            /* Funktion wird aus anderem Thread aufgerufen */
            /* String zuSchreibenderText wird von einem anderen Thread threadsicher in die textBox1 gesetzt */
            textBox1.Invoke((MethodInvoker)(() => { textBox1.Text = zuSchreibenderText; })); 
        }
    }
}
