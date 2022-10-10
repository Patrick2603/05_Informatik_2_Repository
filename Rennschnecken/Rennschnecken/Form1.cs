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

            Button button1 = new Button();
            //button1.DialogResult = DialogResult.OK;
            //Controls.Add(button1);

        }
        public void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            const int STRECKEN_LÄNGE = 50;
            Rennschnecken schnecke1 = new Rennschnecken(rand);
            Rennschnecken schnecke2 = new Rennschnecken(rand);
            Rennschnecken schnecke3 = new Rennschnecken(rand);

            do
            {
                schnecke1.Krieche();
                schnecke2.Krieche();
                schnecke3.Krieche();

                textBox1.Text = schnecke1.Visualisierung + "\r\n";
                textBox1.Text += schnecke2.Visualisierung + "\r\n";
                textBox1.Text += schnecke3.Visualisierung;

                textBox1.Refresh();
                
                Thread.Sleep(250);
            }
            while ((schnecke1.Strecke < STRECKEN_LÄNGE) && (schnecke2.Strecke < STRECKEN_LÄNGE) && (schnecke3.Strecke < STRECKEN_LÄNGE));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
