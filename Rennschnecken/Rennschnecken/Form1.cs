using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rennschnecken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button button1 = new Button();
            button1.DialogResult = DialogResult.OK;
            Controls.Add(button1);

            if (button1.DialogResult == DialogResult.OK)
            {
                Random random = new Random(); 
            }
            
        }
    }
}
