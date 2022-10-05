using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LambdaDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private delegate double Rechne(double p, double q);

        private void button1_Click(object sender, EventArgs e)
        {

            Rechne rechenOperation;
            int x = 5, y = 3;

            if (checkBoxAddieren.Checked)
            {
                rechenOperation = (a,b) => {return a+b;};
            }
            else
            {
                rechenOperation = (a,b) => {return a-b;};
            }

            double ergebnis = rechenOperation(x,y); 
            textBox1.Text = "Ergebnis: " + ergebnis;  
        }
    }
}
