using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vglBtn_Click(object sender, EventArgs e)
        {
            /* Read from the TextBox */
            string eingabe = pwdText.Text; 
            if(eingabe == "Test123")
            {
                /* Write on the Label */
                ergLab.Text = "korrekt";
            }
            else
            {
                ergLab.Text = "falsch";
            }
        }
    }
}
