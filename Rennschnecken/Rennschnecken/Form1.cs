using System;
using System.Threading; 
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

            const int STRECKEN_LÄNGE = 50;
             
            Button button1 = new Button();
            //button1.DialogResult = DialogResult.OK;
            //Controls.Add(button1);

            do
            {
                schnecke1.Krieche();
                schnecke2.Krieche();
                schnecke3.Krieche();

                Thread.Sleep(250);
            }
            while ((schnecke1.Strecke < STRECKEN_LÄNGE) && (schnecke2.Strecke < STRECKEN_LÄNGE) && (schnecke3.Strecke < STRECKEN_LÄNGE));

            Console.Clear();
            textBox1.Text(schnecke1.Visualisierung);
            textBox1.Text(schnecke2.Visualisierung);
            textBox1.Text(schnecke3.Visualisierung); 
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            Rennschnecken schnecke1 = new Rennschnecken(rand);
            Rennschnecken schnecke2 = new Rennschnecken(rand);
            Rennschnecken schnecke3 = new Rennschnecken(rand);

        }
    }
}
