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
            button1.DialogResult = DialogResult.OK;
            Controls.Add(button1);

            if (button1.DialogResult == DialogResult.OK)
            {
                Random random = new Random();

                Rennschnecken schnecke1 = new Rennschnecken(random);
                Rennschnecken schnecke2 = new Rennschnecken(random);
                Rennschnecken schnecke3 = new Rennschnecken(random);

                
            }

            do
            {
                schnecke1.Krieche();
                schnecke2.Krieche();
                schnecke3.Krieche();

                Thread.Sleep(250);
            }
            while ((schnecke1.Strecke < STRECKEN_LÄNGE) && (schnecke2.Strecke < STRECKEN_LÄNGE) && (schnecke3.Strecke < STRECKEN_LÄNGE));

            //Console.Clear();
            Console.WriteLine(schnecke1.Visualisierung);
            Console.WriteLine(schnecke2.Visualisierung);
            Console.WriteLine(schnecke3.Visualisierung);

            
        }
    }
}
